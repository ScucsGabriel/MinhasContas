namespace MinhasContas.View.Despesas
{
    partial class FormDespesas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_DescricaoDespesa = new System.Windows.Forms.Label();
            this.txt_DescricaoDespesa = new System.Windows.Forms.TextBox();
            this.Lbl_DataMinimaDespesa = new System.Windows.Forms.Label();
            this.Dtp_DataMinimaDespesa = new System.Windows.Forms.DateTimePicker();
            this.Lbl_DataMaximaDespesa = new System.Windows.Forms.Label();
            this.Dtp_DataMaximaDespesa = new System.Windows.Forms.DateTimePicker();
            this.Btn_BuscaDescricaoDespesa = new System.Windows.Forms.Button();
            this.Btn_BuscaDataDespesa = new System.Windows.Forms.Button();
            this.Btn_IncluirDespesa = new System.Windows.Forms.Button();
            this.Btn_EditarDespesa = new System.Windows.Forms.Button();
            this.Btn_RemoverDespesa = new System.Windows.Forms.Button();
            this.LstView_Despesa = new System.Windows.Forms.ListView();
            this.Lbl_CalcQuantDespesas = new System.Windows.Forms.Label();
            this.Lbl_QuantDespesas = new System.Windows.Forms.Label();
            this.Lbl_CalcTotalDespesas = new System.Windows.Forms.Label();
            this.Lbl_TotalDespesas = new System.Windows.Forms.Label();
            this.Lbl_BuscaTipoDespesa = new System.Windows.Forms.Label();
            this.Cbo_BuscaTipoDespesa = new System.Windows.Forms.ComboBox();
            this.Btn_BuscarTipoDespesa = new System.Windows.Forms.Button();
            this.Rdb_FiltrarDespesasPagas = new System.Windows.Forms.RadioButton();
            this.Rdb_FiltrarDespesasNaoPagas = new System.Windows.Forms.RadioButton();
            this.Rdb_SemFiltro = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Lbl_DescricaoDespesa
            // 
            this.Lbl_DescricaoDespesa.AutoSize = true;
            this.Lbl_DescricaoDespesa.Location = new System.Drawing.Point(17, 28);
            this.Lbl_DescricaoDespesa.Name = "Lbl_DescricaoDespesa";
            this.Lbl_DescricaoDespesa.Size = new System.Drawing.Size(55, 13);
            this.Lbl_DescricaoDespesa.TabIndex = 15;
            this.Lbl_DescricaoDespesa.Text = "Descrição";
            // 
            // txt_DescricaoDespesa
            // 
            this.txt_DescricaoDespesa.Location = new System.Drawing.Point(78, 25);
            this.txt_DescricaoDespesa.Name = "txt_DescricaoDespesa";
            this.txt_DescricaoDespesa.Size = new System.Drawing.Size(243, 20);
            this.txt_DescricaoDespesa.TabIndex = 1;
            // 
            // Lbl_DataMinimaDespesa
            // 
            this.Lbl_DataMinimaDespesa.AutoSize = true;
            this.Lbl_DataMinimaDespesa.Location = new System.Drawing.Point(368, 31);
            this.Lbl_DataMinimaDespesa.Name = "Lbl_DataMinimaDespesa";
            this.Lbl_DataMinimaDespesa.Size = new System.Drawing.Size(68, 13);
            this.Lbl_DataMinimaDespesa.TabIndex = 16;
            this.Lbl_DataMinimaDespesa.Text = "Data Mínima";
            // 
            // Dtp_DataMinimaDespesa
            // 
            this.Dtp_DataMinimaDespesa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_DataMinimaDespesa.Location = new System.Drawing.Point(442, 28);
            this.Dtp_DataMinimaDespesa.Name = "Dtp_DataMinimaDespesa";
            this.Dtp_DataMinimaDespesa.Size = new System.Drawing.Size(123, 20);
            this.Dtp_DataMinimaDespesa.TabIndex = 2;
            // 
            // Lbl_DataMaximaDespesa
            // 
            this.Lbl_DataMaximaDespesa.AutoSize = true;
            this.Lbl_DataMaximaDespesa.Location = new System.Drawing.Point(580, 31);
            this.Lbl_DataMaximaDespesa.Name = "Lbl_DataMaximaDespesa";
            this.Lbl_DataMaximaDespesa.Size = new System.Drawing.Size(69, 13);
            this.Lbl_DataMaximaDespesa.TabIndex = 17;
            this.Lbl_DataMaximaDespesa.Text = "Data Máxima";
            // 
            // Dtp_DataMaximaDespesa
            // 
            this.Dtp_DataMaximaDespesa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_DataMaximaDespesa.Location = new System.Drawing.Point(655, 28);
            this.Dtp_DataMaximaDespesa.Name = "Dtp_DataMaximaDespesa";
            this.Dtp_DataMaximaDespesa.Size = new System.Drawing.Size(121, 20);
            this.Dtp_DataMaximaDespesa.TabIndex = 3;
            // 
            // Btn_BuscaDescricaoDespesa
            // 
            this.Btn_BuscaDescricaoDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BuscaDescricaoDespesa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscaDescricaoDespesa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_BuscaDescricaoDespesa.Location = new System.Drawing.Point(20, 86);
            this.Btn_BuscaDescricaoDespesa.Name = "Btn_BuscaDescricaoDespesa";
            this.Btn_BuscaDescricaoDespesa.Size = new System.Drawing.Size(121, 36);
            this.Btn_BuscaDescricaoDespesa.TabIndex = 9;
            this.Btn_BuscaDescricaoDespesa.Text = "Buscar por Descrição";
            this.Btn_BuscaDescricaoDespesa.UseVisualStyleBackColor = true;
            this.Btn_BuscaDescricaoDespesa.Click += new System.EventHandler(this.Btn_BuscaDescricaoDespesa_Click);
            // 
            // Btn_BuscaDataDespesa
            // 
            this.Btn_BuscaDataDespesa.Location = new System.Drawing.Point(274, 86);
            this.Btn_BuscaDataDespesa.Name = "Btn_BuscaDataDespesa";
            this.Btn_BuscaDataDespesa.Size = new System.Drawing.Size(121, 36);
            this.Btn_BuscaDataDespesa.TabIndex = 11;
            this.Btn_BuscaDataDespesa.Text = "Buscar por Data";
            this.Btn_BuscaDataDespesa.UseVisualStyleBackColor = true;
            this.Btn_BuscaDataDespesa.Click += new System.EventHandler(this.Btn_BuscaDataDespesa_Click);
            // 
            // Btn_IncluirDespesa
            // 
            this.Btn_IncluirDespesa.Location = new System.Drawing.Point(401, 86);
            this.Btn_IncluirDespesa.Name = "Btn_IncluirDespesa";
            this.Btn_IncluirDespesa.Size = new System.Drawing.Size(121, 36);
            this.Btn_IncluirDespesa.TabIndex = 12;
            this.Btn_IncluirDespesa.Text = "Incluir";
            this.Btn_IncluirDespesa.UseVisualStyleBackColor = true;
            this.Btn_IncluirDespesa.Click += new System.EventHandler(this.Btn_IncluirDespesa_Click);
            // 
            // Btn_EditarDespesa
            // 
            this.Btn_EditarDespesa.Location = new System.Drawing.Point(528, 86);
            this.Btn_EditarDespesa.Name = "Btn_EditarDespesa";
            this.Btn_EditarDespesa.Size = new System.Drawing.Size(121, 36);
            this.Btn_EditarDespesa.TabIndex = 13;
            this.Btn_EditarDespesa.Text = "Editar";
            this.Btn_EditarDespesa.UseVisualStyleBackColor = true;
            this.Btn_EditarDespesa.Click += new System.EventHandler(this.Btn_EditarDespesa_Click);
            // 
            // Btn_RemoverDespesa
            // 
            this.Btn_RemoverDespesa.Location = new System.Drawing.Point(655, 86);
            this.Btn_RemoverDespesa.Name = "Btn_RemoverDespesa";
            this.Btn_RemoverDespesa.Size = new System.Drawing.Size(121, 36);
            this.Btn_RemoverDespesa.TabIndex = 14;
            this.Btn_RemoverDespesa.Text = "Remover";
            this.Btn_RemoverDespesa.UseVisualStyleBackColor = true;
            this.Btn_RemoverDespesa.Click += new System.EventHandler(this.Btn_RemoverDespesa_Click);
            // 
            // LstView_Despesa
            // 
            this.LstView_Despesa.HideSelection = false;
            this.LstView_Despesa.Location = new System.Drawing.Point(20, 128);
            this.LstView_Despesa.Name = "LstView_Despesa";
            this.LstView_Despesa.Size = new System.Drawing.Size(756, 447);
            this.LstView_Despesa.TabIndex = 8;
            this.LstView_Despesa.UseCompatibleStateImageBehavior = false;
            // 
            // Lbl_CalcQuantDespesas
            // 
            this.Lbl_CalcQuantDespesas.AutoSize = true;
            this.Lbl_CalcQuantDespesas.Location = new System.Drawing.Point(17, 592);
            this.Lbl_CalcQuantDespesas.Name = "Lbl_CalcQuantDespesas";
            this.Lbl_CalcQuantDespesas.Size = new System.Drawing.Size(54, 13);
            this.Lbl_CalcQuantDespesas.TabIndex = 19;
            this.Lbl_CalcQuantDespesas.Text = "Despesas";
            // 
            // Lbl_QuantDespesas
            // 
            this.Lbl_QuantDespesas.AutoSize = true;
            this.Lbl_QuantDespesas.Location = new System.Drawing.Point(17, 615);
            this.Lbl_QuantDespesas.Name = "Lbl_QuantDespesas";
            this.Lbl_QuantDespesas.Size = new System.Drawing.Size(13, 13);
            this.Lbl_QuantDespesas.TabIndex = 20;
            this.Lbl_QuantDespesas.Text = "0";
            // 
            // Lbl_CalcTotalDespesas
            // 
            this.Lbl_CalcTotalDespesas.AutoSize = true;
            this.Lbl_CalcTotalDespesas.Location = new System.Drawing.Point(92, 592);
            this.Lbl_CalcTotalDespesas.Name = "Lbl_CalcTotalDespesas";
            this.Lbl_CalcTotalDespesas.Size = new System.Drawing.Size(101, 13);
            this.Lbl_CalcTotalDespesas.TabIndex = 21;
            this.Lbl_CalcTotalDespesas.Text = "Total das Despesas";
            // 
            // Lbl_TotalDespesas
            // 
            this.Lbl_TotalDespesas.AutoSize = true;
            this.Lbl_TotalDespesas.Location = new System.Drawing.Point(92, 615);
            this.Lbl_TotalDespesas.Name = "Lbl_TotalDespesas";
            this.Lbl_TotalDespesas.Size = new System.Drawing.Size(42, 13);
            this.Lbl_TotalDespesas.TabIndex = 22;
            this.Lbl_TotalDespesas.Text = "R$0,00";
            // 
            // Lbl_BuscaTipoDespesa
            // 
            this.Lbl_BuscaTipoDespesa.AutoSize = true;
            this.Lbl_BuscaTipoDespesa.Location = new System.Drawing.Point(37, 56);
            this.Lbl_BuscaTipoDespesa.Name = "Lbl_BuscaTipoDespesa";
            this.Lbl_BuscaTipoDespesa.Size = new System.Drawing.Size(28, 13);
            this.Lbl_BuscaTipoDespesa.TabIndex = 18;
            this.Lbl_BuscaTipoDespesa.Text = "Tipo";
            // 
            // Cbo_BuscaTipoDespesa
            // 
            this.Cbo_BuscaTipoDespesa.FormattingEnabled = true;
            this.Cbo_BuscaTipoDespesa.Items.AddRange(new object[] {
            "Alimentação",
            "Animais",
            "Beleza/Estética",
            "Contas",
            "Diversão",
            "Saúde",
            "Transporte",
            "Vestimenta"});
            this.Cbo_BuscaTipoDespesa.Location = new System.Drawing.Point(78, 53);
            this.Cbo_BuscaTipoDespesa.Name = "Cbo_BuscaTipoDespesa";
            this.Cbo_BuscaTipoDespesa.Size = new System.Drawing.Size(243, 21);
            this.Cbo_BuscaTipoDespesa.TabIndex = 4;
            this.Cbo_BuscaTipoDespesa.Text = "Selecione";
            // 
            // Btn_BuscarTipoDespesa
            // 
            this.Btn_BuscarTipoDespesa.Location = new System.Drawing.Point(147, 86);
            this.Btn_BuscarTipoDespesa.Name = "Btn_BuscarTipoDespesa";
            this.Btn_BuscarTipoDespesa.Size = new System.Drawing.Size(121, 36);
            this.Btn_BuscarTipoDespesa.TabIndex = 10;
            this.Btn_BuscarTipoDespesa.Text = "Buscar por Tipo";
            this.Btn_BuscarTipoDespesa.UseVisualStyleBackColor = true;
            this.Btn_BuscarTipoDespesa.Click += new System.EventHandler(this.Btn_BuscarTipoDespesa_Click);
            // 
            // Rdb_FiltrarDespesasPagas
            // 
            this.Rdb_FiltrarDespesasPagas.AutoSize = true;
            this.Rdb_FiltrarDespesasPagas.Location = new System.Drawing.Point(371, 57);
            this.Rdb_FiltrarDespesasPagas.Name = "Rdb_FiltrarDespesasPagas";
            this.Rdb_FiltrarDespesasPagas.Size = new System.Drawing.Size(130, 17);
            this.Rdb_FiltrarDespesasPagas.TabIndex = 5;
            this.Rdb_FiltrarDespesasPagas.TabStop = true;
            this.Rdb_FiltrarDespesasPagas.Text = "Filtrar despesas pagas";
            this.Rdb_FiltrarDespesasPagas.UseVisualStyleBackColor = true;
            // 
            // Rdb_FiltrarDespesasNaoPagas
            // 
            this.Rdb_FiltrarDespesasNaoPagas.AutoSize = true;
            this.Rdb_FiltrarDespesasNaoPagas.Location = new System.Drawing.Point(528, 57);
            this.Rdb_FiltrarDespesasNaoPagas.Name = "Rdb_FiltrarDespesasNaoPagas";
            this.Rdb_FiltrarDespesasNaoPagas.Size = new System.Drawing.Size(151, 17);
            this.Rdb_FiltrarDespesasNaoPagas.TabIndex = 6;
            this.Rdb_FiltrarDespesasNaoPagas.TabStop = true;
            this.Rdb_FiltrarDespesasNaoPagas.Text = "Filtrar despesas não pagas";
            this.Rdb_FiltrarDespesasNaoPagas.UseVisualStyleBackColor = true;
            // 
            // Rdb_SemFiltro
            // 
            this.Rdb_SemFiltro.AutoSize = true;
            this.Rdb_SemFiltro.Location = new System.Drawing.Point(705, 57);
            this.Rdb_SemFiltro.Name = "Rdb_SemFiltro";
            this.Rdb_SemFiltro.Size = new System.Drawing.Size(71, 17);
            this.Rdb_SemFiltro.TabIndex = 7;
            this.Rdb_SemFiltro.TabStop = true;
            this.Rdb_SemFiltro.Text = "Sem Filtro";
            this.Rdb_SemFiltro.UseVisualStyleBackColor = true;
            // 
            // FormDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 653);
            this.Controls.Add(this.Rdb_SemFiltro);
            this.Controls.Add(this.Rdb_FiltrarDespesasNaoPagas);
            this.Controls.Add(this.Rdb_FiltrarDespesasPagas);
            this.Controls.Add(this.Btn_BuscarTipoDespesa);
            this.Controls.Add(this.Cbo_BuscaTipoDespesa);
            this.Controls.Add(this.Lbl_BuscaTipoDespesa);
            this.Controls.Add(this.Lbl_TotalDespesas);
            this.Controls.Add(this.Lbl_CalcTotalDespesas);
            this.Controls.Add(this.Lbl_QuantDespesas);
            this.Controls.Add(this.Lbl_CalcQuantDespesas);
            this.Controls.Add(this.LstView_Despesa);
            this.Controls.Add(this.Btn_RemoverDespesa);
            this.Controls.Add(this.Btn_EditarDespesa);
            this.Controls.Add(this.Btn_IncluirDespesa);
            this.Controls.Add(this.Btn_BuscaDataDespesa);
            this.Controls.Add(this.Btn_BuscaDescricaoDespesa);
            this.Controls.Add(this.Dtp_DataMaximaDespesa);
            this.Controls.Add(this.Lbl_DataMaximaDespesa);
            this.Controls.Add(this.Dtp_DataMinimaDespesa);
            this.Controls.Add(this.Lbl_DataMinimaDespesa);
            this.Controls.Add(this.txt_DescricaoDespesa);
            this.Controls.Add(this.Lbl_DescricaoDespesa);
            this.Name = "FormDespesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despesa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_DescricaoDespesa;
        private System.Windows.Forms.TextBox txt_DescricaoDespesa;
        private System.Windows.Forms.Label Lbl_DataMinimaDespesa;
        private System.Windows.Forms.DateTimePicker Dtp_DataMinimaDespesa;
        private System.Windows.Forms.Label Lbl_DataMaximaDespesa;
        private System.Windows.Forms.DateTimePicker Dtp_DataMaximaDespesa;
        private System.Windows.Forms.Button Btn_BuscaDescricaoDespesa;
        private System.Windows.Forms.Button Btn_BuscaDataDespesa;
        private System.Windows.Forms.Button Btn_IncluirDespesa;
        private System.Windows.Forms.Button Btn_EditarDespesa;
        private System.Windows.Forms.Button Btn_RemoverDespesa;
        private System.Windows.Forms.ListView LstView_Despesa;
        private System.Windows.Forms.Label Lbl_CalcQuantDespesas;
        private System.Windows.Forms.Label Lbl_QuantDespesas;
        private System.Windows.Forms.Label Lbl_CalcTotalDespesas;
        private System.Windows.Forms.Label Lbl_TotalDespesas;
        private System.Windows.Forms.Label Lbl_BuscaTipoDespesa;
        private System.Windows.Forms.ComboBox Cbo_BuscaTipoDespesa;
        private System.Windows.Forms.Button Btn_BuscarTipoDespesa;
        private System.Windows.Forms.RadioButton Rdb_FiltrarDespesasPagas;
        private System.Windows.Forms.RadioButton Rdb_FiltrarDespesasNaoPagas;
        private System.Windows.Forms.RadioButton Rdb_SemFiltro;
    }
}