using MinhasContas.Controller;
using MinhasContas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhasContas.View.Despesas
{
    public partial class FormDespesas : Form
    {
        private string filtro;
        public FormDespesas()
        {
            InitializeComponent();
        }

        private void Btn_IncluirDespesa_Click(object sender, EventArgs e)
        {
            FormIncluirDespesas formIncluirDespesa = new FormIncluirDespesas();
            formIncluirDespesa.ShowDialog();
        }

        private void Btn_EditarDespesa_Click(object sender, EventArgs e)
        {
            if (LstView_Despesa.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (LstView_Despesa.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DespesaController listarDespesa = new DespesaController();
            List<Despesa> despesasSelecionadas = new List<Despesa>();
            int idDespesa = Convert.ToInt32(LstView_Despesa.SelectedItems[0].SubItems[0].Text);
            foreach (var item in listarDespesa.ConsultarDespesaPorId(idDespesa))
            {
                Despesa despesa = new Despesa();
                despesa.idDespesa = item.idDespesa;
                despesa.valorDespesa = item.valorDespesa;
                despesa.descricaoDespesa = item.descricaoDespesa;
                despesa.tipoDespesa = item.tipoDespesa;
                despesa.dataDespesa = item.dataDespesa;
                despesa.despesaPaga = item.despesaPaga;

                despesasSelecionadas.Add(despesa);
            }

            FormEditarDespesas formEditarDespesa = new FormEditarDespesas(despesasSelecionadas);
            formEditarDespesa.ShowDialog();

            if (Rdb_FiltrarDespesasNaoPagas.Checked)
                filtro = "fdnp";
            else if (Rdb_FiltrarDespesasPagas.Checked)
                filtro = "fdp";
            else
                filtro = "sf";

            if (txt_DescricaoDespesa.Text != "")                
                PreencherListView_DescricaoDespesa(txt_DescricaoDespesa.Text, filtro);
            else if(Cbo_BuscaTipoDespesa.Text != "Selecione")
                PreencherListView_TipoDespesa(Cbo_BuscaTipoDespesa.Text, filtro);
            else
            {
                DateTime dataMinimaDespesa = Dtp_DataMinimaDespesa.Value;
                DateTime dataMaximaDespesa = Dtp_DataMaximaDespesa.Value;
                string stringDataMinimaDespesa = dataMinimaDespesa.ToString("yyyy-MM-dd");
                string stringDataMaximaDespesa = dataMaximaDespesa.ToString("yyyy-MM-dd");
                PreencherListView_DataDespesa(stringDataMinimaDespesa, stringDataMaximaDespesa, filtro);
            }
        }

        private void Btn_BuscaDescricaoDespesa_Click(object sender, EventArgs e)
        {            
            Dtp_DataMinimaDespesa.Value = DateTime.Now;
            Dtp_DataMaximaDespesa.Value = DateTime.Now;
            Cbo_BuscaTipoDespesa.Text = "Selecione";

            if (txt_DescricaoDespesa.Text == "")
            {
                MessageBox.Show("Descrição está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (txt_DescricaoDespesa.Text.Length > 50)
            {
                MessageBox.Show("Descrição está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if((!Rdb_FiltrarDespesasNaoPagas.Checked) && (!Rdb_FiltrarDespesasPagas.Checked) && (!Rdb_SemFiltro.Checked))
            {
                MessageBox.Show("Selecione a opção de filtro.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Rdb_FiltrarDespesasNaoPagas.Checked)
                filtro = "fdnp";
            else if (Rdb_FiltrarDespesasPagas.Checked)
                filtro = "fdp";
            else
                filtro = "sf";
            BuscarPorDescricao(txt_DescricaoDespesa.Text, filtro);
        }

        private void BuscarPorDescricao(string descricaoDespesa, string filtro)
        {
            LimparFormLista();
            PreencherColumnHeader();
            PreencherListView_DescricaoDespesa(descricaoDespesa, filtro);
            LstView_Despesa.View = System.Windows.Forms.View.Details;
        }

        private void PreencherListView_DescricaoDespesa(string descricaoDespesa, string filtro)
        {
            LimparFormLista();
            PreencherColumnHeader();
            DespesaController listarDespesa = new DespesaController();
            int resultadoBusca = listarDespesa.ConsultarDespesaPorDescricao(descricaoDespesa, filtro).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para este tipo de receita!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarDespesa.ConsultarDespesaPorDescricao(descricaoDespesa, filtro))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idDespesa.ToString(), "R$" + item.valorDespesa.ToString(), item.descricaoDespesa,
                    item.tipoDespesa, item.dataDespesa.ToString("dd-MM-yyyy"), item.despesaPaga});
                    LstView_Despesa.Items.Add(listViewItem);

                    Lbl_QuantDespesas.Text = Convert.ToString(LstView_Despesa.Items.Count);
                    Lbl_TotalDespesas.Text = "R$" + (double.Parse(Lbl_TotalDespesas.Text.Replace("R$", "")) +
                        item.valorDespesa).ToString();
                }
            }
        }

        private void LimparFormLista()
        {
            LstView_Despesa.Columns.Clear();
            LstView_Despesa.Items.Clear();
            LstView_Despesa.FullRowSelect = true;
            Lbl_QuantDespesas.Text = "0";
            Lbl_TotalDespesas.Text = "R$0,00";
        }

        private void PreencherColumnHeader()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            ColumnHeader columnHeader4 = new ColumnHeader();
            ColumnHeader columnHeader5 = new ColumnHeader();
            ColumnHeader columnHeader6 = new ColumnHeader();

            columnHeader1.Text = "Código";
            columnHeader2.Text = "Valor";
            columnHeader3.Text = "Descrição";
            columnHeader4.Text = "Tipo";
            columnHeader5.Text = "Data";
            columnHeader6.Text = "Paga?";

            LstView_Despesa.Columns.Add(columnHeader1);
            LstView_Despesa.Columns.Add(columnHeader2);
            LstView_Despesa.Columns.Add(columnHeader3);
            LstView_Despesa.Columns.Add(columnHeader4);
            LstView_Despesa.Columns.Add(columnHeader5);
            LstView_Despesa.Columns.Add(columnHeader6);

            LstView_Despesa.GridLines = true;
        }

        private void Btn_BuscaDataDespesa_Click(object sender, EventArgs e)
        {
            txt_DescricaoDespesa.Text = "";
            Cbo_BuscaTipoDespesa.Text = "Selecione";
            if (Dtp_DataMaximaDespesa.Value < Dtp_DataMinimaDespesa.Value)
            {
                MessageBox.Show("A data máxima não pode ser menor que a data mínima!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if ((!Rdb_FiltrarDespesasNaoPagas.Checked) && (!Rdb_FiltrarDespesasPagas.Checked) && (!Rdb_SemFiltro.Checked))
            {
                MessageBox.Show("Selecione a opção de filtro.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Rdb_FiltrarDespesasNaoPagas.Checked)
                filtro = "fdnp";
            else if (Rdb_FiltrarDespesasPagas.Checked)
                filtro = "fdp";
            else
                filtro = "sf";

            BuscarPorDataDespesa(Convert.ToDateTime(Dtp_DataMinimaDespesa.Value),
                Convert.ToDateTime(Dtp_DataMaximaDespesa.Value), filtro);
        }

        private void BuscarPorDataDespesa(DateTime dataMinimaDespesa, DateTime dataMaximaDespesa, string filtro)
        {
            string stringDataMinimaDespesa = dataMinimaDespesa.ToString("yyyy-MM-dd");
            string stringDataMaximaDespesa = dataMaximaDespesa.ToString("yyyy-MM-dd");
            LstView_Despesa.Columns.Clear();
            LstView_Despesa.Items.Clear();
            LstView_Despesa.Refresh();
            PreencherColumnHeader();
            PreencherListView_DataDespesa(stringDataMinimaDespesa, stringDataMaximaDespesa, filtro);
            LstView_Despesa.View = System.Windows.Forms.View.Details;
        }

        private void PreencherListView_DataDespesa(string dataMinimaDespesa, string dataMaximaDespesa, string filtro)
        {
            LimparFormLista();
            PreencherColumnHeader();
            DespesaController listarDespesa = new DespesaController();
            int resultadoBusca = listarDespesa.ConsultarDespesa(dataMinimaDespesa, dataMaximaDespesa, filtro).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para o período selecionado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarDespesa.ConsultarDespesa(dataMinimaDespesa, dataMaximaDespesa, filtro))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idDespesa.ToString(), "R$" + item.valorDespesa.ToString(), item.descricaoDespesa,
                    item.tipoDespesa, item.dataDespesa.ToString("dd-MM-yyyy"), item.despesaPaga});
                    LstView_Despesa.Items.Add(listViewItem);

                    Lbl_QuantDespesas.Text = Convert.ToString(LstView_Despesa.Items.Count);
                    Lbl_TotalDespesas.Text = "R$" + (double.Parse(Lbl_TotalDespesas.Text.Replace("R$", "")) +
                        item.valorDespesa).ToString();
                }
            }
        }

        private void Btn_BuscarTipoDespesa_Click(object sender, EventArgs e)
        {
            Dtp_DataMinimaDespesa.Value = DateTime.Now;
            Dtp_DataMaximaDespesa.Value = DateTime.Now;
            txt_DescricaoDespesa.Text = "";

            if (Cbo_BuscaTipoDespesa.Text == "Selecione")
            {
                MessageBox.Show("Selecione o tipo de despesa.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if ((!Rdb_FiltrarDespesasNaoPagas.Checked) && (!Rdb_FiltrarDespesasPagas.Checked) && (!Rdb_SemFiltro.Checked))
            {
                MessageBox.Show("Selecione a opção de filtro.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Rdb_FiltrarDespesasNaoPagas.Checked)
                filtro = "fdnp";
            else if (Rdb_FiltrarDespesasPagas.Checked)
                filtro = "fdp";
            else
                filtro = "sf";
            BuscarPorTipo(Cbo_BuscaTipoDespesa.Text, filtro);
        }

        private void BuscarPorTipo(string tipoDespesa, string filtro)
        {
            LimparFormLista();
            PreencherColumnHeader();
            PreencherListView_TipoDespesa(tipoDespesa, filtro);
            LstView_Despesa.View = System.Windows.Forms.View.Details;
        }

        private void PreencherListView_TipoDespesa(string tipoDespesa, string filtro)
        {
            LimparFormLista();
            PreencherColumnHeader();
            DespesaController listarDespesa = new DespesaController();
            int resultadoBusca = listarDespesa.ConsultarDespesaPorTipo(tipoDespesa, filtro).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para este tipo de receita!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarDespesa.ConsultarDespesaPorTipo(tipoDespesa, filtro))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idDespesa.ToString(), "R$" + item.valorDespesa.ToString(), item.descricaoDespesa,
                    item.tipoDespesa, item.dataDespesa.ToString("dd-MM-yyyy"), item.despesaPaga});
                    LstView_Despesa.Items.Add(listViewItem);

                    Lbl_QuantDespesas.Text = Convert.ToString(LstView_Despesa.Items.Count);
                    Lbl_TotalDespesas.Text = "R$" + (double.Parse(Lbl_TotalDespesas.Text.Replace("R$", "")) +
                        item.valorDespesa).ToString();
                }
            }
        }

        private void Btn_RemoverDespesa_Click(object sender, EventArgs e)
        {
            if (LstView_Despesa.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (LstView_Despesa.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Você irá excluir o registro permanentemente!", "Deseja continuar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (MessageBox.Show("Confirma a exclusão?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    DespesaController listarDespesa = new DespesaController();
                    int idDespesa = Convert.ToInt32(LstView_Despesa.SelectedItems[0].SubItems[0].Text);
                    Lbl_TotalDespesas.Text = "R$0,00";
                    listarDespesa.ExcluirDespesa(idDespesa);
                    MessageBox.Show("Registro deletado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int i = LstView_Despesa.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem lstRemove = LstView_Despesa.SelectedItems[i];
                        LstView_Despesa.Items.Remove(lstRemove);
                    }
                    LstView_Despesa.Refresh();

                    Lbl_QuantDespesas.Text = Convert.ToString(LstView_Despesa.Items.Count);
                    for (int item = 0; item < LstView_Despesa.Items.Count; item++)
                    {
                        Lbl_TotalDespesas.Text = "R$" + (double.Parse(Lbl_TotalDespesas.Text.Replace("R$", "")) +
                            double.Parse(LstView_Despesa.Items[item].SubItems[1].Text.Replace("R$", ""))).ToString();
                    }
                }
            }
        }
    }
}
