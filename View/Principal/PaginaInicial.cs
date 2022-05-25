using MinhasContas.View.Despesas;
using MinhasContas.View.Receitas;
using MinhasContas.View.Relatorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhasContas.View
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Tsl_Receita_Click(object sender, EventArgs e)
        {
            FormReceitas formReceita = new FormReceitas();
            formReceita.ShowDialog();
        }

        private void Tsl_Despesa_Click(object sender, EventArgs e)
        {
            FormDespesas formDespesa = new FormDespesas();
            formDespesa.ShowDialog();
        }

        private void Tsl_Relatorio_Click(object sender, EventArgs e)
        {
            FormRelatorios formRelatorio = new FormRelatorios();
            formRelatorio.ShowDialog();
        }
    }
}
