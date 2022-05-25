using MinhasContas.Controller;
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
    public partial class FormIncluirDespesas : Form
    {
        public FormIncluirDespesas()
        {
            InitializeComponent();
        }
        private void Limpar()
        {
            Msk_IncluirValorDespesa.Text = "";
            Txt_IncluirDescricaoDespesa.Text = "";
            Cbo_IncluirTipoDespesa.Text = "Selecione";
            Dtp_IncluirDataDespesa.Value = DateTime.Now;
            Cbo_IncluirPagaDespesa.Text = "Selecione";
        }

        private void Btn_IncluirSalvarDespesa_Click(object sender, EventArgs e)
        {
            if (!ValidarPreenchimento())
                return;

            string descricaoDespesa = RemoveSpecialCharacters(Txt_IncluirDescricaoDespesa.Text);

            double valorDespesa;
            string despesaPaga;

            DespesaController inserirDespesa = new DespesaController();
            string formatadorValorDespesa = Msk_IncluirValorDespesa.Text.Replace(" ", "").Replace("R$", "").Trim();
            if (formatadorValorDespesa != ".")
                valorDespesa = double.Parse(formatadorValorDespesa, CultureInfo.InvariantCulture);
            else
                valorDespesa = 0;

            if (Cbo_IncluirPagaDespesa.Text == "Sim")
                despesaPaga = "S";
            else
                despesaPaga = "N";

            inserirDespesa.InserirDespesa(valorDespesa, descricaoDespesa,
                Cbo_IncluirTipoDespesa.Text, Convert.ToDateTime(Dtp_IncluirDataDespesa.Value),
                despesaPaga);

            MessageBox.Show("Despesa incluída com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpar();
        }

        private void Msk_IncluirValorDespesa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod)
            {
                string buscaPonto = Msk_IncluirValorDespesa.Text;
                int resultado = buscaPonto.IndexOf(".");
                Msk_IncluirValorDespesa.SelectionStart = resultado;
                if (e.KeyCode == Keys.Oemcomma)
                    Msk_IncluirValorDespesa.SelectionStart = resultado + 1;
                else
                    Msk_IncluirValorDespesa.SelectionStart = resultado;
            }
        }

        private bool ValidarPreenchimento()
        {
            if (Msk_IncluirValorDespesa.Text == "R$     .")
            {
                MessageBox.Show("Valor da Despesa está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_IncluirDescricaoDespesa.Text == "")
            {
                MessageBox.Show("Descrição da Despesa está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_IncluirDescricaoDespesa.Text.Length > 50)
            {
                MessageBox.Show("Descrição da Despesa está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Cbo_IncluirTipoDespesa.Text == "Selecione")
            {
                MessageBox.Show("Selecione o Tipo de Despesa.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Cbo_IncluirPagaDespesa.Text == "Selecione")
            {
                MessageBox.Show("Selecione se a despesa foi paga ou não.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
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
