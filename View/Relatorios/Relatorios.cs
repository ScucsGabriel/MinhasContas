using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Excel;
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

namespace MinhasContas.View.Relatorios
{
    public partial class FormRelatorios : Form
    {
        private double receita = 0;
        private double despesa = 0;
        private double saldo = 0;
        public FormRelatorios()
        {
            InitializeComponent();
        }

        private void Btn_GerarRelatorio_Click(object sender, EventArgs e)
        {
            string dataMinima = Dtp_DataMinimaRelatorio.Value.ToString();
            string dataMaxima = Dtp_DataMaximaRelatorio.Value.ToString();
            if (Convert.ToDateTime(dataMaxima) < Convert.ToDateTime(dataMinima))
            {
                MessageBox.Show("A Data Máxima não pode ser menor que a Data Mínima!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GerarRelatorio(Convert.ToDateTime(Dtp_DataMinimaRelatorio.Value), Convert.ToDateTime(Dtp_DataMaximaRelatorio.Value));
        }

        private void GerarRelatorio(DateTime dataMinimaRelatorio, DateTime dataMaximaRelatorio)
        {
            string stringDataMinimaRelatorio = dataMinimaRelatorio.ToString("yyyy-MM-dd");
            string stringDataMaximaRelatorio = dataMaximaRelatorio.ToString("yyyy-MM-dd");
            PreencherListView_GerarRelatorio(stringDataMinimaRelatorio, stringDataMaximaRelatorio);
            LstView_Relatorio.View = System.Windows.Forms.View.Details;
        }

        private void LimparFormLista()
        {
            LstView_Relatorio.Columns.Clear();
            LstView_Relatorio.Items.Clear();
            LstView_Relatorio.FullRowSelect = true;
            receita = 0;
            despesa = 0;
            saldo = 0;
        }
        private void PreencherColumnHeader_GerarRelatorio()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();

            columnHeader1.Text = "Data";
            columnHeader2.Text = "Transação";
            columnHeader3.Text = "Valor";

            LstView_Relatorio.Columns.Add(columnHeader1);
            LstView_Relatorio.Columns.Add(columnHeader2);
            LstView_Relatorio.Columns.Add(columnHeader3);

            LstView_Relatorio.GridLines = true;
        }

        private void PreencherListView_GerarRelatorio(string stringDataMinimaRelatorio, string stringDataMaximaRelatorio)
        {
            LimparFormLista();
            PreencherColumnHeader_GerarRelatorio();
            RelatorioController gerarRelatorio = new RelatorioController();

            int resultadoBusca = gerarRelatorio.GerarRelatorio(stringDataMinimaRelatorio, stringDataMaximaRelatorio).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para o período selecionado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in gerarRelatorio.GerarRelatorio(stringDataMinimaRelatorio, stringDataMaximaRelatorio))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.dataTransacao.ToString("dd/MM/yyyy"), item.descricaoTransacao,
                        item.descricaoTransacao.Contains("Receita") ? "R$+" + item.valorTransacao.ToString() : 
                        "R$-" + item.valorTransacao.ToString()});
                    LstView_Relatorio.Items.Add(listViewItem);
                }
                for (int i = 0; i < LstView_Relatorio.Items.Count; i++)
                {
                    if (LstView_Relatorio.Items[i].SubItems[1].Text.Contains("Despesa"))
                        despesa = despesa + double.Parse(LstView_Relatorio.Items[i].SubItems[2].Text.Replace("R$-", "").Replace(",", "."), CultureInfo.InvariantCulture);

                    else if (LstView_Relatorio.Items[i].SubItems[1].Text.Contains("Receita"))
                        receita = receita + double.Parse(LstView_Relatorio.Items[i].SubItems[2].Text.Replace("R$+", "").Replace(",", "."), CultureInfo.InvariantCulture);
                }

                saldo = receita - despesa;

                ListViewItem saldoFinal = new ListViewItem(new[]
                { Dtp_DataMaximaRelatorio.Value.ToString("dd/MM/yyyy"), "Saldo", "R$" + saldo.ToString() });
                LstView_Relatorio.Items.Add(saldoFinal);

                Colorir_FluxoCaixa();
            }
        }

        private void Colorir_FluxoCaixa()
        {
            for (int i = 0; i < LstView_Relatorio.Items.Count; i++)
            {
                if (LstView_Relatorio.Items[i].SubItems[1].Text.Contains("Despesa"))
                    LstView_Relatorio.Items[i].BackColor = Color.Tomato;

                else if (LstView_Relatorio.Items[i].SubItems[1].Text.Contains("Receita"))
                    LstView_Relatorio.Items[i].BackColor = Color.LightGreen;
            }
        }

        private void Btn_SalvarXLS_Click(object sender, EventArgs e)
        {
            if (LstView_Relatorio.Items.Count == 0)
            {
                MessageBox.Show("Necessário gerar dados para salvar em XLS!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else 
            {
                if (!GerarXls_Relatorio())
                    return;
            }
        }

        private bool GerarXls_Relatorio()
        {
            Salvar_XLS.Title = "Salvar Relatório";
            Salvar_XLS.Filter = "XLS file (*.xlsx)|*.xlsx";
            Salvar_XLS.FileName = "Relatório - " + Dtp_DataMaximaRelatorio.Value.ToString("MM-yyyy");
            Salvar_XLS.DefaultExt = ".xlsx";
            Salvar_XLS.InitialDirectory = @"C:\";
            Salvar_XLS.RestoreDirectory = true;
            DialogResult resultado = Salvar_XLS.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                if (xlApp == null)
                {
                    MessageBox.Show("Excel não está instalado!");
                    return false;
                }
                string caminho = Salvar_XLS.FileName;

                try
                {
                    Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                    Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[1];

                    int row = 1;
                    xlWorksheet.Cells[row, 1] = "Data";
                    xlWorksheet.Cells[row, 2] = "Transação";
                    xlWorksheet.Cells[row, 3] = "Valor";

                    xlWorksheet.get_Range("A1", "C1").Font.Bold = true;
                    xlWorksheet.get_Range("A1", "C1").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                    for (int i = 0; i < LstView_Relatorio.Items.Count; i++)
                    {
                        row++;
                        int col = 1;
                        xlWorksheet.Cells[row, col] = "'" + LstView_Relatorio.Items[i].SubItems[0].Text;
                        col++;
                        xlWorksheet.Cells[row, col] = LstView_Relatorio.Items[i].SubItems[1].Text;
                        col++;
                        xlWorksheet.Cells[row, col] = LstView_Relatorio.Items[i].SubItems[2].Text;
                        xlWorksheet.get_Range("A" + row, "C" + row).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                        if (LstView_Relatorio.Items[i].SubItems[1].Text.Contains("Despesa"))
                        {
                            xlWorksheet.get_Range("A" + row, "C" + row).Interior.Color =
                                System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Tomato);
                        }
                        else if (LstView_Relatorio.Items[i].SubItems[1].Text.Contains("Receita"))
                        {
                            xlWorksheet.get_Range("A" + row, "C" + row).Interior.Color =
                                System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGreen);
                        }
                        else if (LstView_Relatorio.Items[i].SubItems[1].Text.Contains("Saldo"))
                        {
                            xlWorksheet.get_Range("A" + row, "C" + row).Font.Bold = true;
                        }
                    }

                    xlWorkbook.SaveAs(Salvar_XLS.FileName, XlFileFormat.xlOpenXMLWorkbook);
                    xlWorkbook.Close();

                    DialogResult resposta = MessageBox.Show("Documento salvo! Deseja abrir o documento?", "Informação",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (resposta == DialogResult.Yes)
                        System.Diagnostics.Process.Start(Salvar_XLS.FileName);
                }
                catch (Exception e)
                {
                    MessageBox.Show("O documento anteriormente salvo está aberto ou sendo usado por outro processo!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    xlApp.Quit();
                }
            }
            else
            {
                MessageBox.Show("Operação cancelada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void Btn_SalvarPDF_Click(object sender, EventArgs e)
        {
            if (LstView_Relatorio.Items.Count == 0)
            {
                MessageBox.Show("Necessário gerar dados para salvar em PDF!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (!GerarPdf_Relatorio())
                    return;
            }
        }

        private bool GerarPdf_Relatorio()
        {

            Salvar_PDF.Title = "Salvar Relatório";
            Salvar_PDF.Filter = "PDF file (*.pdf)|*.pdf";
            Salvar_PDF.FileName = "Relatório - " + Dtp_DataMaximaRelatorio.Value.ToString("MM-yyyy");
            Salvar_PDF.DefaultExt = ".pdf";
            Salvar_PDF.InitialDirectory = @"C:\";
            Salvar_PDF.RestoreDirectory = true;
            DialogResult resultado = Salvar_PDF.ShowDialog();

            if (resultado == DialogResult.OK)
            {

                Document documento = new Document(PageSize.A4);
                documento.SetMargins(40, 40, 40, 80);
                documento.AddCreationDate();
                string caminho = Salvar_PDF.FileName;

                try
                {
                    PdfWriter writer = PdfWriter.GetInstance(documento, new System.IO.FileStream(caminho, System.IO.FileMode.Create));
                    documento.Open();

                    iTextSharp.text.Font fonteTitulo = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 22, Convert.ToInt32(FontStyle.Bold));
                    iTextSharp.text.Font fonteSubTitulos = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 14, Convert.ToInt32(FontStyle.Bold));
                    iTextSharp.text.Font fonteSaldo = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 14, Convert.ToInt32(FontStyle.Bold));

                    Paragraph titulo = new Paragraph();
                    Paragraph espacamento = new Paragraph();
                    titulo.Alignment = Element.ALIGN_CENTER;
                    titulo.Font = fonteTitulo;
                    titulo.Add("Relatório");
                    espacamento.Add(" ");
                    documento.Add(titulo);
                    documento.Add(espacamento);

                    PdfPTable tabela = new PdfPTable(3);
                    Paragraph coluna1 = new Paragraph("Data");
                    Paragraph coluna2 = new Paragraph("Transação");
                    Paragraph coluna3 = new Paragraph("Valor");

                    coluna1.Alignment = Element.ALIGN_CENTER;
                    coluna2.Alignment = Element.ALIGN_CENTER;
                    coluna3.Alignment = Element.ALIGN_CENTER;

                    coluna1.Font = fonteSubTitulos;
                    coluna2.Font = fonteSubTitulos;
                    coluna3.Font = fonteSubTitulos;

                    var cel1 = new PdfPCell();
                    var cel2 = new PdfPCell();
                    var cel3 = new PdfPCell();

                    cel1.AddElement(coluna1);
                    cel2.AddElement(coluna2);
                    cel3.AddElement(coluna3);

                    tabela.AddCell(cel1);
                    tabela.AddCell(cel2);
                    tabela.AddCell(cel3);

                    for (int i = 0; i < LstView_Relatorio.Items.Count; i++)
                    {
                        if (LstView_Relatorio.Items[i].SubItems[1].Text.Contains("Despesa"))
                        {
                            Paragraph data = new Paragraph(LstView_Relatorio.Items[i].SubItems[0].Text);
                            Paragraph transacao = new Paragraph(LstView_Relatorio.Items[i].SubItems[1].Text);
                            Paragraph valor = new Paragraph(LstView_Relatorio.Items[i].SubItems[2].Text);

                            var celDataDespesa = new PdfPCell();
                            var celTransacaoDespesa = new PdfPCell();
                            var celValorDespesa = new PdfPCell();

                            celDataDespesa.AddElement(data);
                            celTransacaoDespesa.AddElement(transacao);
                            celValorDespesa.AddElement(valor);

                            celDataDespesa.BackgroundColor = BaseColor.RED;
                            celTransacaoDespesa.BackgroundColor = BaseColor.RED;
                            celValorDespesa.BackgroundColor = BaseColor.RED;

                            tabela.AddCell(celDataDespesa);
                            tabela.AddCell(celTransacaoDespesa);
                            tabela.AddCell(celValorDespesa);
                        }
                        else if (LstView_Relatorio.Items[i].SubItems[1].Text.Contains("Receita"))
                        {
                            Paragraph data = new Paragraph(LstView_Relatorio.Items[i].SubItems[0].Text);
                            Paragraph transacao = new Paragraph(LstView_Relatorio.Items[i].SubItems[1].Text);
                            Paragraph valor = new Paragraph(LstView_Relatorio.Items[i].SubItems[2].Text);

                            var celDataReceita = new PdfPCell();
                            var celTransacaoReceita = new PdfPCell();
                            var celValorReceita = new PdfPCell();

                            celDataReceita.AddElement(data);
                            celTransacaoReceita.AddElement(transacao);
                            celValorReceita.AddElement(valor);

                            celDataReceita.BackgroundColor = BaseColor.GREEN;
                            celTransacaoReceita.BackgroundColor = BaseColor.GREEN;
                            celValorReceita.BackgroundColor = BaseColor.GREEN;

                            tabela.AddCell(celDataReceita);
                            tabela.AddCell(celTransacaoReceita);
                            tabela.AddCell(celValorReceita);
                        }
                        else if (LstView_Relatorio.Items[i].SubItems[1].Text.Contains("Saldo"))
                        {
                            Paragraph data = new Paragraph(LstView_Relatorio.Items[i].SubItems[0].Text);
                            Paragraph transacao = new Paragraph(LstView_Relatorio.Items[i].SubItems[1].Text);
                            Paragraph valor = new Paragraph(LstView_Relatorio.Items[i].SubItems[2].Text);

                            var celDataSaldo = new PdfPCell();
                            var celTransacaoSaldo = new PdfPCell();
                            var celValorSaldo = new PdfPCell();

                            celDataSaldo.AddElement(data);
                            celTransacaoSaldo.AddElement(transacao);
                            celValorSaldo.AddElement(valor);

                            tabela.AddCell(celDataSaldo);
                            tabela.AddCell(celTransacaoSaldo);
                            tabela.AddCell(celValorSaldo);
                        }
                    }

                    documento.Add(tabela);
                    DialogResult resposta = MessageBox.Show("Documento salvo! Deseja abrir o documento?", "Informação",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (resposta == DialogResult.Yes)
                        System.Diagnostics.Process.Start(Salvar_PDF.FileName);
                }
                catch (Exception e)
                {
                    MessageBox.Show("O documento anteriormente salvo está aberto ou sendo usado por outro processo!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    documento.Close();
                }
            }
            else
            {
                MessageBox.Show("Operação cancelada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
    }
}
