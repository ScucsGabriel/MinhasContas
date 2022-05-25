using MinhasContas.Controller;
using System;
using System.Collections.Generic;
using MinhasContas.Model;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NUnit.Framework;

namespace MinhasContas.View.Receitas
{
    public partial class FormReceitas : Form
    {
        public FormReceitas()
        {
            InitializeComponent();
        }

        private void Btn_IncluirReceita_Click(object sender, EventArgs e)
        {
            FormIncluirReceitas formIncluirReceita = new FormIncluirReceitas();
            formIncluirReceita.ShowDialog();
        }

        private void Btn_EditarReceita_Click(object sender, EventArgs e)
        {
            if (LstView_Receita.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (LstView_Receita.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ReceitaController listarReceita = new ReceitaController();
            List<Receita> receitasSelecionadas = new List<Receita>();
            int idReceita = Convert.ToInt32(LstView_Receita.SelectedItems[0].SubItems[0].Text);
            foreach (var item in listarReceita.ConsultarReceitaPorId(idReceita))
            {
                Receita receita = new Receita();
                receita.idReceita = item.idReceita;
                receita.valorReceita = item.valorReceita;
                receita.descricaoReceita = item.descricaoReceita;
                receita.dataReceita = item.dataReceita;

                receitasSelecionadas.Add(receita);
            }

            FormEditarReceitas formEditarReceita = new FormEditarReceitas(receitasSelecionadas);
            formEditarReceita.ShowDialog();

            if (txt_DescricaoReceita.Text != "")
                PreencherListView_DescricaoReceita(txt_DescricaoReceita.Text);
            else
            {
                DateTime dataMinimaReceita = Dtp_DataMinimaReceita.Value;
                DateTime dataMaximaReceita = Dtp_DataMaximaReceita.Value;
                string stringDataMinimaReceita = dataMinimaReceita.ToString("yyyy-MM-dd");
                string stringDataMaximaReceita = dataMaximaReceita.ToString("yyyy-MM-dd");
                PreencherListView_DataReceita(stringDataMinimaReceita, stringDataMaximaReceita);
            }
        }

        private void Btn_BuscaDescricaoReceita_Click(object sender, EventArgs e)
        {
            Dtp_DataMinimaReceita.Value = DateTime.Now;
            Dtp_DataMaximaReceita.Value = DateTime.Now;

            if (txt_DescricaoReceita.Text == "")
            {
                MessageBox.Show("Descrição está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (txt_DescricaoReceita.Text.Length > 50)
            {
                MessageBox.Show("Descrição está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BuscarPorDescricao(txt_DescricaoReceita.Text);
        }

        private void Btn_BuscaDataReceita_Click(object sender, EventArgs e)
        {
            txt_DescricaoReceita.Text = "";
            if (Dtp_DataMaximaReceita.Value < Dtp_DataMinimaReceita.Value)
            {
                MessageBox.Show("A data máxima não pode ser menor que a data mínima!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BuscarPorDataReceita(Convert.ToDateTime(Dtp_DataMinimaReceita.Value),
                Convert.ToDateTime(Dtp_DataMaximaReceita.Value));
        }

        private void BuscarPorDescricao(string descricaoReceita)
        {
            LimparFormLista();
            PreencherColumnHeader();
            PreencherListView_DescricaoReceita(descricaoReceita);
            LstView_Receita.View = System.Windows.Forms.View.Details;
        }

        private void BuscarPorDataReceita(DateTime dataMinimaReceita, DateTime dataMaximaReceita)
        {
            string stringDataMinimaReceita = dataMinimaReceita.ToString("yyyy-MM-dd");
            string stringDataMaximaReceita = dataMaximaReceita.ToString("yyyy-MM-dd");
            LstView_Receita.Columns.Clear();
            LstView_Receita.Items.Clear();
            LstView_Receita.Refresh();
            PreencherColumnHeader();
            PreencherListView_DataReceita(stringDataMinimaReceita, stringDataMaximaReceita);
            LstView_Receita.View = System.Windows.Forms.View.Details;
        }

        private void LimparFormLista()
        {
            LstView_Receita.Columns.Clear();
            LstView_Receita.Items.Clear();
            LstView_Receita.FullRowSelect = true;
            Lbl_QuantReceitas.Text = "0";
            Lbl_TotalReceitas.Text = "R$0,00";
        }

        private void PreencherColumnHeader()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            ColumnHeader columnHeader4 = new ColumnHeader();

            columnHeader1.Text = "Código";
            columnHeader2.Text = "Valor";
            columnHeader3.Text = "Descrição";
            columnHeader4.Text = "Data";

            LstView_Receita.Columns.Add(columnHeader1);
            LstView_Receita.Columns.Add(columnHeader2);
            LstView_Receita.Columns.Add(columnHeader3);
            LstView_Receita.Columns.Add(columnHeader4);

            LstView_Receita.GridLines = true;
        }

        private void PreencherListView_DescricaoReceita(string descricaoReceita)
        {
            LimparFormLista();
            PreencherColumnHeader();
            ReceitaController listarReceita = new ReceitaController();
            int resultadoBusca = listarReceita.ConsultarReceitaPorDescricao(descricaoReceita).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para este tipo de receita!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarReceita.ConsultarReceitaPorDescricao(descricaoReceita))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idReceita.ToString(), "R$" + item.valorReceita.ToString(), item.descricaoReceita,
                      item.dataReceita.ToString("dd-MM-yyyy")});
                    LstView_Receita.Items.Add(listViewItem);

                    Lbl_QuantReceitas.Text = Convert.ToString(LstView_Receita.Items.Count);
                    Lbl_TotalReceitas.Text = "R$" + (double.Parse(Lbl_TotalReceitas.Text.Replace("R$", "")) +
                        item.valorReceita).ToString();
                }
            }
        }
        private void PreencherListView_DataReceita(string dataMinimaReceita, string dataMaximaReceita)
        {
            LimparFormLista();
            PreencherColumnHeader();
            ReceitaController listarReceita = new ReceitaController();
            int resultadoBusca = listarReceita.ConsultarReceita(dataMinimaReceita, dataMaximaReceita).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para o período selecionado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarReceita.ConsultarReceita(dataMinimaReceita, dataMaximaReceita))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idReceita.ToString(), "R$" + item.valorReceita.ToString(), item.descricaoReceita.ToString(),
                        item.dataReceita.ToString("dd-MM-yyyy")});
                    LstView_Receita.Items.Add(listViewItem);

                    Lbl_QuantReceitas.Text = Convert.ToString(LstView_Receita.Items.Count);
                    Lbl_TotalReceitas.Text = "R$" + (double.Parse(Lbl_TotalReceitas.Text.Replace("R$", "")) +
                        item.valorReceita).ToString();
                }
            }
        }

        private void Btn_RemoverReceita_Click(object sender, EventArgs e)
        {
            if (LstView_Receita.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (LstView_Receita.SelectedItems.Count > 1)
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
                    ReceitaController listarReceita = new ReceitaController();
                    int idReceita = Convert.ToInt32(LstView_Receita.SelectedItems[0].SubItems[0].Text);
                    Lbl_TotalReceitas.Text = "R$0,00";
                    listarReceita.ExcluirReceita(idReceita);
                    MessageBox.Show("Registro deletado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int i = LstView_Receita.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem lstRemove = LstView_Receita.SelectedItems[i];
                        LstView_Receita.Items.Remove(lstRemove);
                    }
                    LstView_Receita.Refresh();

                    Lbl_QuantReceitas.Text = Convert.ToString(LstView_Receita.Items.Count);
                    for (int item = 0; item < LstView_Receita.Items.Count; item++)
                    {
                        Lbl_TotalReceitas.Text = "R$" + (double.Parse(Lbl_TotalReceitas.Text.Replace("R$", "")) +
                            double.Parse(LstView_Receita.Items[item].SubItems[1].Text.Replace("R$", ""))).ToString();                        
                    }
                }
            }
        }
    }
}
