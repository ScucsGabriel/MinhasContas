namespace MinhasContas.View.Despesas
{
    partial class FormIncluirDespesas
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
            this.Lbl_IncluirValorDespesa = new System.Windows.Forms.Label();
            this.Lbl_IncluirDescricaoDespesa = new System.Windows.Forms.Label();
            this.Txt_IncluirDescricaoDespesa = new System.Windows.Forms.TextBox();
            this.Lbl_IncluirDataDespesa = new System.Windows.Forms.Label();
            this.Dtp_IncluirDataDespesa = new System.Windows.Forms.DateTimePicker();
            this.Lbl_IncluirPagaDespesa = new System.Windows.Forms.Label();
            this.Cbo_IncluirPagaDespesa = new System.Windows.Forms.ComboBox();
            this.Btn_IncluirSalvarDespesa = new System.Windows.Forms.Button();
            this.Lbl_IncluirTipoDespesa = new System.Windows.Forms.Label();
            this.Cbo_IncluirTipoDespesa = new System.Windows.Forms.ComboBox();
            this.Msk_IncluirValorDespesa = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Lbl_IncluirValorDespesa
            // 
            this.Lbl_IncluirValorDespesa.AutoSize = true;
            this.Lbl_IncluirValorDespesa.Location = new System.Drawing.Point(32, 15);
            this.Lbl_IncluirValorDespesa.Name = "Lbl_IncluirValorDespesa";
            this.Lbl_IncluirValorDespesa.Size = new System.Drawing.Size(31, 13);
            this.Lbl_IncluirValorDespesa.TabIndex = 7;
            this.Lbl_IncluirValorDespesa.Text = "Valor";
            // 
            // Lbl_IncluirDescricaoDespesa
            // 
            this.Lbl_IncluirDescricaoDespesa.AutoSize = true;
            this.Lbl_IncluirDescricaoDespesa.Location = new System.Drawing.Point(8, 45);
            this.Lbl_IncluirDescricaoDespesa.Name = "Lbl_IncluirDescricaoDespesa";
            this.Lbl_IncluirDescricaoDespesa.Size = new System.Drawing.Size(55, 13);
            this.Lbl_IncluirDescricaoDespesa.TabIndex = 8;
            this.Lbl_IncluirDescricaoDespesa.Text = "Descrição";
            // 
            // Txt_IncluirDescricaoDespesa
            // 
            this.Txt_IncluirDescricaoDespesa.Location = new System.Drawing.Point(69, 45);
            this.Txt_IncluirDescricaoDespesa.Name = "Txt_IncluirDescricaoDespesa";
            this.Txt_IncluirDescricaoDespesa.Size = new System.Drawing.Size(146, 20);
            this.Txt_IncluirDescricaoDespesa.TabIndex = 2;
            // 
            // Lbl_IncluirDataDespesa
            // 
            this.Lbl_IncluirDataDespesa.AutoSize = true;
            this.Lbl_IncluirDataDespesa.Location = new System.Drawing.Point(32, 114);
            this.Lbl_IncluirDataDespesa.Name = "Lbl_IncluirDataDespesa";
            this.Lbl_IncluirDataDespesa.Size = new System.Drawing.Size(30, 13);
            this.Lbl_IncluirDataDespesa.TabIndex = 10;
            this.Lbl_IncluirDataDespesa.Text = "Data";
            // 
            // Dtp_IncluirDataDespesa
            // 
            this.Dtp_IncluirDataDespesa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_IncluirDataDespesa.Location = new System.Drawing.Point(69, 114);
            this.Dtp_IncluirDataDespesa.Name = "Dtp_IncluirDataDespesa";
            this.Dtp_IncluirDataDespesa.Size = new System.Drawing.Size(146, 20);
            this.Dtp_IncluirDataDespesa.TabIndex = 4;
            // 
            // Lbl_IncluirPagaDespesa
            // 
            this.Lbl_IncluirPagaDespesa.AutoSize = true;
            this.Lbl_IncluirPagaDespesa.Location = new System.Drawing.Point(25, 147);
            this.Lbl_IncluirPagaDespesa.Name = "Lbl_IncluirPagaDespesa";
            this.Lbl_IncluirPagaDespesa.Size = new System.Drawing.Size(38, 13);
            this.Lbl_IncluirPagaDespesa.TabIndex = 11;
            this.Lbl_IncluirPagaDespesa.Text = "Paga?";
            // 
            // Cbo_IncluirPagaDespesa
            // 
            this.Cbo_IncluirPagaDespesa.FormattingEnabled = true;
            this.Cbo_IncluirPagaDespesa.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.Cbo_IncluirPagaDespesa.Location = new System.Drawing.Point(69, 147);
            this.Cbo_IncluirPagaDespesa.Name = "Cbo_IncluirPagaDespesa";
            this.Cbo_IncluirPagaDespesa.Size = new System.Drawing.Size(146, 21);
            this.Cbo_IncluirPagaDespesa.TabIndex = 5;
            this.Cbo_IncluirPagaDespesa.Text = "Selecione";
            // 
            // Btn_IncluirSalvarDespesa
            // 
            this.Btn_IncluirSalvarDespesa.Location = new System.Drawing.Point(139, 191);
            this.Btn_IncluirSalvarDespesa.Name = "Btn_IncluirSalvarDespesa";
            this.Btn_IncluirSalvarDespesa.Size = new System.Drawing.Size(75, 23);
            this.Btn_IncluirSalvarDespesa.TabIndex = 6;
            this.Btn_IncluirSalvarDespesa.Text = "Salvar";
            this.Btn_IncluirSalvarDespesa.UseVisualStyleBackColor = true;
            this.Btn_IncluirSalvarDespesa.Click += new System.EventHandler(this.Btn_IncluirSalvarDespesa_Click);
            // 
            // Lbl_IncluirTipoDespesa
            // 
            this.Lbl_IncluirTipoDespesa.AutoSize = true;
            this.Lbl_IncluirTipoDespesa.Location = new System.Drawing.Point(35, 82);
            this.Lbl_IncluirTipoDespesa.Name = "Lbl_IncluirTipoDespesa";
            this.Lbl_IncluirTipoDespesa.Size = new System.Drawing.Size(28, 13);
            this.Lbl_IncluirTipoDespesa.TabIndex = 9;
            this.Lbl_IncluirTipoDespesa.Text = "Tipo";
            // 
            // Cbo_IncluirTipoDespesa
            // 
            this.Cbo_IncluirTipoDespesa.FormattingEnabled = true;
            this.Cbo_IncluirTipoDespesa.Items.AddRange(new object[] {
            "Alimentação",
            "Animais",
            "Beleza/Estética",
            "Contas",
            "Diversão",
            "Saúde",
            "Transporte",
            "Vestimenta"});
            this.Cbo_IncluirTipoDespesa.Location = new System.Drawing.Point(69, 79);
            this.Cbo_IncluirTipoDespesa.Name = "Cbo_IncluirTipoDespesa";
            this.Cbo_IncluirTipoDespesa.Size = new System.Drawing.Size(146, 21);
            this.Cbo_IncluirTipoDespesa.TabIndex = 3;
            this.Cbo_IncluirTipoDespesa.Text = "Selecione";
            // 
            // Msk_IncluirValorDespesa
            // 
            this.Msk_IncluirValorDespesa.Location = new System.Drawing.Point(69, 12);
            this.Msk_IncluirValorDespesa.Mask = "$#####,##";
            this.Msk_IncluirValorDespesa.Name = "Msk_IncluirValorDespesa";
            this.Msk_IncluirValorDespesa.Size = new System.Drawing.Size(146, 20);
            this.Msk_IncluirValorDespesa.TabIndex = 1;
            this.Msk_IncluirValorDespesa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Msk_IncluirValorDespesa_KeyDown);
            // 
            // FormIncluirDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 226);
            this.Controls.Add(this.Msk_IncluirValorDespesa);
            this.Controls.Add(this.Cbo_IncluirTipoDespesa);
            this.Controls.Add(this.Lbl_IncluirTipoDespesa);
            this.Controls.Add(this.Btn_IncluirSalvarDespesa);
            this.Controls.Add(this.Cbo_IncluirPagaDespesa);
            this.Controls.Add(this.Lbl_IncluirPagaDespesa);
            this.Controls.Add(this.Dtp_IncluirDataDespesa);
            this.Controls.Add(this.Lbl_IncluirDataDespesa);
            this.Controls.Add(this.Txt_IncluirDescricaoDespesa);
            this.Controls.Add(this.Lbl_IncluirDescricaoDespesa);
            this.Controls.Add(this.Lbl_IncluirValorDespesa);
            this.Name = "FormIncluirDespesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incluir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_IncluirValorDespesa;
        private System.Windows.Forms.Label Lbl_IncluirDescricaoDespesa;
        private System.Windows.Forms.TextBox Txt_IncluirDescricaoDespesa;
        private System.Windows.Forms.Label Lbl_IncluirDataDespesa;
        private System.Windows.Forms.DateTimePicker Dtp_IncluirDataDespesa;
        private System.Windows.Forms.Label Lbl_IncluirPagaDespesa;
        private System.Windows.Forms.ComboBox Cbo_IncluirPagaDespesa;
        private System.Windows.Forms.Button Btn_IncluirSalvarDespesa;
        private System.Windows.Forms.Label Lbl_IncluirTipoDespesa;
        private System.Windows.Forms.ComboBox Cbo_IncluirTipoDespesa;
        private System.Windows.Forms.MaskedTextBox Msk_IncluirValorDespesa;
    }
}