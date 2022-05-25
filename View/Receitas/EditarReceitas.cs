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

namespace MinhasContas.View.Receitas
{
    public partial class FormEditarReceitas : Form
    {
        private int idReceita;
        private double valorReceita;
        public FormEditarReceitas(List<Receita> listaReceita)
        {
            InitializeComponent();
            foreach (var item in listaReceita)
            {
                idReceita = item.idReceita;
                valorReceita = item.valorReceita;
                Msk_EditarValorReceita.Text = item.valorReceita.ToString();
                while (double.Parse(Msk_EditarValorReceita.Text.Replace(" ", "").Replace("R$", ""), CultureInfo.InvariantCulture) != valorReceita)
                {
                    Msk_EditarValorReceita.Text = " " + Msk_EditarValorReceita.Text;
                }
                Txt_EditarDescricaoReceita.Text = item.descricaoReceita;
                Dtp_EditarDataReceita.Value = Convert.ToDateTime(item.dataReceita);
            }
        }

        private void Limpar()
        {
            Msk_EditarValorReceita.Text = "";
            Txt_EditarDescricaoReceita.Text = "";
            Dtp_EditarDataReceita.Value = DateTime.Now;
        }

        private void Btn_EditarSalvarReceita_Click(object sender, EventArgs e)
        {
            if (!ValidarPreenchimento())
                return;

            string descricaoReceita = RemoveSpecialCharacters(Txt_EditarDescricaoReceita.Text);

            double valorReceita;
            ReceitaController atualizarReceita = new ReceitaController();
            string formatadorValorReceita = Msk_EditarValorReceita.Text.Replace(" ", "").Replace("R$", "").Trim();
            if (formatadorValorReceita != ".")
                valorReceita = double.Parse(formatadorValorReceita, CultureInfo.InvariantCulture);
            else
                valorReceita = 0;

            atualizarReceita.EditarReceita(idReceita, valorReceita, descricaoReceita,
                Convert.ToDateTime(Dtp_EditarDataReceita.Value));

            MessageBox.Show("Receita atualizada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
            this.Close();
        }

        private void Msk_EditarValorReceita_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod)
            {
                string buscaPonto = Msk_EditarValorReceita.Text;
                int resultado = buscaPonto.IndexOf(".");
                Msk_EditarValorReceita.SelectionStart = resultado;
                if (e.KeyCode == Keys.Oemcomma)
                    Msk_EditarValorReceita.SelectionStart = resultado + 1;
                else
                    Msk_EditarValorReceita.SelectionStart = resultado;
            }
        }

        private bool ValidarPreenchimento()
        {
            if (Msk_EditarValorReceita.Text == "R$     .")
            {
                MessageBox.Show("Valor da Receita está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_EditarDescricaoReceita.Text == "")
            {
                MessageBox.Show("Descrição da Receita está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_EditarDescricaoReceita.Text.Length > 50)
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
