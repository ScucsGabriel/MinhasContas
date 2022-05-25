using MinhasContas.Controller;
using MinhasContas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhasContas.View.Despesas
{
    public partial class FormEditarDespesas : Form
    {
        private int idDespesa;
        private double valorDespesa;
        private string tipoDespesa;
        private string despesaPaga;
        public FormEditarDespesas(List<Despesa> listaDespesa)
        {
            InitializeComponent();
            foreach (var item in listaDespesa)
            {
                idDespesa = item.idDespesa;
                valorDespesa = item.valorDespesa;
                Msk_EditarValorDespesa.Text = item.valorDespesa.ToString();
                while (double.Parse(Msk_EditarValorDespesa.Text.Replace(" ", "").Replace("R$", ""), CultureInfo.InvariantCulture) != valorDespesa)
                {
                    Msk_EditarValorDespesa.Text = " " + Msk_EditarValorDespesa.Text;
                }
                Txt_EditarDescricaoDespesa.Text = item.descricaoDespesa;
                tipoDespesa = item.tipoDespesa;
                Dtp_EditarDataDespesa.Value = Convert.ToDateTime(item.dataDespesa);
                despesaPaga = item.despesaPaga;
            }
        }

        private void Limpar()
        {
            Msk_EditarValorDespesa.Text = "";
            Txt_EditarDescricaoDespesa.Text = "";
            Cbo_EditarTipoDespesa.Text = "Selecione";
            Dtp_EditarDataDespesa.Value = DateTime.Now;
            Cbo_EditarPagaDespesa.Text = "Selecione";
        }

        private void Btn_EditarSalvarDespesa_Click(object sender, EventArgs e)
        {
            if (!ValidarPreenchimento())
                return;

            string descricaoDespesa = RemoveSpecialCharacters(Txt_EditarDescricaoDespesa.Text);

            double valorDespesa;
            string despesaPaga;

            DespesaController editarDespesa = new DespesaController();
            string formatadorValorDespesa = Msk_EditarValorDespesa.Text.Replace(" ", "").Replace("R$", "").Trim();
            if (formatadorValorDespesa != ".")
                valorDespesa = double.Parse(formatadorValorDespesa, CultureInfo.InvariantCulture);
            else
                valorDespesa = 0;

            if (Cbo_EditarPagaDespesa.Text == "Sim")
                despesaPaga = "S";
            else
                despesaPaga = "N";

            editarDespesa.EditarDespesa(idDespesa, valorDespesa, descricaoDespesa,
                Cbo_EditarTipoDespesa.Text, Convert.ToDateTime(Dtp_EditarDataDespesa.Value),
                despesaPaga);

            MessageBox.Show("Despesa atualizada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpar();
            this.Close();
        }

        private void Msk_EditarValorDespesa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod)
            {
                string buscaPonto = Msk_EditarValorDespesa.Text;
                int resultado = buscaPonto.IndexOf(".");
                Msk_EditarValorDespesa.SelectionStart = resultado;
                if (e.KeyCode == Keys.Oemcomma)
                    Msk_EditarValorDespesa.SelectionStart = resultado + 1;
                else
                    Msk_EditarValorDespesa.SelectionStart = resultado;
            }
        }

        private bool ValidarPreenchimento()
        {
            if (Msk_EditarValorDespesa.Text == "R$     .")
            {
                MessageBox.Show("Valor da Despesa está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_EditarDescricaoDespesa.Text == "")
            {
                MessageBox.Show("Descrição da Despesa está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_EditarDescricaoDespesa.Text.Length > 50)
            {
                MessageBox.Show("Descrição da Despesa está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Cbo_EditarTipoDespesa.Text == "Selecione")
            {
                MessageBox.Show("Selecione o Tipo de Despesa.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Cbo_EditarPagaDespesa.Text == "Selecione")
            {
                MessageBox.Show("Selecione se a Despesa foi paga ou não.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void FormEditarDespesas_Load(object sender, EventArgs e)
        {
            Cbo_EditarTipoDespesa.Text = tipoDespesa;
            Cbo_EditarPagaDespesa.Text = despesaPaga;
        }

        public static string RemoveSpecialCharacters(string text, bool allowSpace = false)
        {
            string ret;

            if (allowSpace)
                ret = System.Text.RegularExpressions.Regex.Replace(text, @"[^0-9a-zA-ZéúíóáÉÚÍÓÁèùìòàÈÙÌÒÀõãñÕÃÑêûîôâÊÛÎÔÂëÿüïöäËYÜÏÖÄçÇ\s]+?", string.Empty);
            else
                ret = System.Text.RegularExpressions.Regex.Replace(text, @"[^0-9a-zA-ZéúíóáÉÚÍÓÁèùìòàÈÙÌÒÀõãñÕÃÑêûîôâÊÛÎÔÂëÿüïöäËYÜÏÖÄçÇ]+?", string.Empty);

            return ret;
        }
    }
}
