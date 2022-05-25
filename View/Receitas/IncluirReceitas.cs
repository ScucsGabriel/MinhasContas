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

namespace MinhasContas.View.Receitas
{
    public partial class FormIncluirReceitas : Form
    {
        public FormIncluirReceitas()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            Msk_IncluirValorReceita.Text = "";
            Txt_IncluirDescricaoReceita.Text = "";
            Dtp_IncluirDataReceita.Value = DateTime.Now;
        }

        private void Btn_IncluirSalvarReceita_Click(object sender, EventArgs e)
        {
            if (!ValidarPreenchimento())
                return;

            string descricaoReceita = RemoveSpecialCharacters(Txt_IncluirDescricaoReceita.Text);

            double valorReceita;

            ReceitaController inserirReceita = new ReceitaController();
            string formatadorValorReceita = Msk_IncluirValorReceita.Text.Replace(" ", "").Replace("R$", "").Trim();
            if (formatadorValorReceita != ".")
                valorReceita = double.Parse(formatadorValorReceita, CultureInfo.InvariantCulture);
            else
                valorReceita = 0;

            inserirReceita.InserirReceita(valorReceita, descricaoReceita, Convert.ToDateTime(Dtp_IncluirDataReceita.Value));

            MessageBox.Show("Receita incluída com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
        }

        private void Msk_IncluirValorReceita_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod)
            {
                string buscaPonto = Msk_IncluirValorReceita.Text;
                int resultado = buscaPonto.IndexOf(".");
                if (e.KeyCode == Keys.Oemcomma)
                    Msk_IncluirValorReceita.SelectionStart = resultado + 1;
                else
                    Msk_IncluirValorReceita.SelectionStart = resultado;
            }
        }

        private bool ValidarPreenchimento()
        {
            if (Msk_IncluirValorReceita.Text == "R$     .")
            {
                MessageBox.Show("Valor da Receita está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_IncluirDescricaoReceita.Text == "")
            {
                MessageBox.Show("Descrição da Receita está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_IncluirDescricaoReceita.Text.Length > 50)
            {
                MessageBox.Show("Descrição da Receita está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
