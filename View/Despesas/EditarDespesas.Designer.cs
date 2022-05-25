namespace MinhasContas.View.Despesas
{
    partial class FormEditarDespesas
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
            this.Lbl_EditarValorDespesa = new System.Windows.Forms.Label();
            this.Lbl_EditarDescricaoDespesa = new System.Windows.Forms.Label();
            this.Txt_EditarDescricaoDespesa = new System.Windows.Forms.TextBox();
            this.Lbl_EditarDataDespesa = new System.Windows.Forms.Label();
            this.Dtp_EditarDataDespesa = new System.Windows.Forms.DateTimePicker();
            this.Lbl_EditarPagaDespesa = new System.Windows.Forms.Label();
            this.Cbo_EditarPagaDespesa = new System.Windows.Forms.ComboBox();
            this.Btn_EditarSalvarDespesa = new System.Windows.Forms.Button();
            this.Lbl_EditarTipoDespesa = new System.Windows.Forms.Label();
            this.Cbo_EditarTipoDespesa = new System.Windows.Forms.ComboBox();
            this.Msk_EditarValorDespesa = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Lbl_EditarValorDespesa
            // 
            this.Lbl_EditarValorDespesa.AutoSize = true;
            this.Lbl_EditarValorDespesa.Location = new System.Drawing.Point(32, 15);
            this.Lbl_EditarValorDespesa.Name = "Lbl_EditarValorDespesa";
            this.Lbl_EditarValorDespesa.Size = new System.Drawing.Size(31, 13);
            this.Lbl_EditarValorDespesa.TabIndex = 7;
            this.Lbl_EditarValorDespesa.Text = "Valor";
            // 
            // Lbl_EditarDescricaoDespesa
            // 
            this.Lbl_EditarDescricaoDespesa.AutoSize = true;
            this.Lbl_EditarDescricaoDespesa.Location = new System.Drawing.Point(8, 45);
            this.Lbl_EditarDescricaoDespesa.Name = "Lbl_EditarDescricaoDespesa";
            this.Lbl_EditarDescricaoDespesa.Size = new System.Drawing.Size(55, 13);
            this.Lbl_EditarDescricaoDespesa.TabIndex = 8;
            this.Lbl_EditarDescricaoDespesa.Text = "Descrição";
            // 
            // Txt_EditarDescricaoDespesa
            // 
            this.Txt_EditarDescricaoDespesa.Location = new System.Drawing.Point(69, 45);
            this.Txt_EditarDescricaoDespesa.Name = "Txt_EditarDescricaoDespesa";
            this.Txt_EditarDescricaoDespesa.Size = new System.Drawing.Size(146, 20);
            this.Txt_EditarDescricaoDespesa.TabIndex = 2;
            // 
            // Lbl_EditarDataDespesa
            // 
            this.Lbl_EditarDataDespesa.AutoSize = true;
            this.Lbl_EditarDataDespesa.Location = new System.Drawing.Point(33, 112);
            this.Lbl_EditarDataDespesa.Name = "Lbl_EditarDataDespesa";
            this.Lbl_EditarDataDespesa.Size = new System.Drawing.Size(30, 13);
            this.Lbl_EditarDataDespesa.TabIndex = 10;
            this.Lbl_EditarDataDespesa.Text = "Data";
            // 
            // Dtp_EditarDataDespesa
            // 
            this.Dtp_EditarDataDespesa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_EditarDataDespesa.Location = new System.Drawing.Point(69, 112);
            this.Dtp_EditarDataDespesa.Name = "Dtp_EditarDataDespesa";
            this.Dtp_EditarDataDespesa.Size = new System.Drawing.Size(146, 20);
            this.Dtp_EditarDataDespesa.TabIndex = 4;
            // 
            // Lbl_EditarPagaDespesa
            // 
            this.Lbl_EditarPagaDespesa.AutoSize = true;
            this.Lbl_EditarPagaDespesa.Location = new System.Drawing.Point(25, 141);
            this.Lbl_EditarPagaDespesa.Name = "Lbl_EditarPagaDespesa";
            this.Lbl_EditarPagaDespesa.Size = new System.Drawing.Size(38, 13);
            this.Lbl_EditarPagaDespesa.TabIndex = 11;
            this.Lbl_EditarPagaDespesa.Text = "Paga?";
            // 
            // Cbo_EditarPagaDespesa
            // 
            this.Cbo_EditarPagaDespesa.FormattingEnabled = true;
            this.Cbo_EditarPagaDespesa.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.Cbo_EditarPagaDespesa.Location = new System.Drawing.Point(69, 141);
            this.Cbo_EditarPagaDespesa.Name = "Cbo_EditarPagaDespesa";
            this.Cbo_EditarPagaDespesa.Size = new System.Drawing.Size(146, 21);
            this.Cbo_EditarPagaDespesa.TabIndex = 5;
            this.Cbo_EditarPagaDespesa.Text = "Selecione";
            // 
            // Btn_EditarSalvarDespesa
            // 
            this.Btn_EditarSalvarDespesa.Location = new System.Drawing.Point(140, 178);
            this.Btn_EditarSalvarDespesa.Name = "Btn_EditarSalvarDespesa";
            this.Btn_EditarSalvarDespesa.Size = new System.Drawing.Size(75, 23);
            this.Btn_EditarSalvarDespesa.TabIndex = 6;
            this.Btn_EditarSalvarDespesa.Text = "Salvar";
            this.Btn_EditarSalvarDespesa.UseVisualStyleBackColor = true;
            this.Btn_EditarSalvarDespesa.Click += new System.EventHandler(this.Btn_EditarSalvarDespesa_Click);
            // 
            // Lbl_EditarTipoDespesa
            // 
            this.Lbl_EditarTipoDespesa.AutoSize = true;
            this.Lbl_EditarTipoDespesa.Location = new System.Drawing.Point(35, 82);
            this.Lbl_EditarTipoDespesa.Name = "Lbl_EditarTipoDespesa";
            this.Lbl_EditarTipoDespesa.Size = new System.Drawing.Size(28, 13);
            this.Lbl_EditarTipoDespesa.TabIndex = 9;
            this.Lbl_EditarTipoDespesa.Text = "Tipo";
            // 
            // Cbo_EditarTipoDespesa
            // 
            this.Cbo_EditarTipoDespesa.FormattingEnabled = true;
            this.Cbo_EditarTipoDespesa.Items.AddRange(new object[] {
            "Alimentação",
            "Animais",
            "Beleza/Estética",
            "Contas",
            "Diversão",
            "Saúde",
            "Transporte",
            "Vestimenta"});
            this.Cbo_EditarTipoDespesa.Location = new System.Drawing.Point(69, 79);
            this.Cbo_EditarTipoDespesa.Name = "Cbo_EditarTipoDespesa";
            this.Cbo_EditarTipoDespesa.Size = new System.Drawing.Size(146, 21);
            this.Cbo_EditarTipoDespesa.TabIndex = 3;
            this.Cbo_EditarTipoDespesa.Text = "Selecione";
            // 
            // Msk_EditarValorDespesa
            // 
            this.Msk_EditarValorDespesa.Location = new System.Drawing.Point(69, 15);
            this.Msk_EditarValorDespesa.Mask = "$#####,##";
            this.Msk_EditarValorDespesa.Name = "Msk_EditarValorDespesa";
            this.Msk_EditarValorDespesa.Size = new System.Drawing.Size(146, 20);
            this.Msk_EditarValorDespesa.TabIndex = 1;
            this.Msk_EditarValorDespesa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Msk_EditarValorDespesa_KeyDown);
            // 
            // FormEditarDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 210);
            this.Controls.Add(this.Msk_EditarValorDespesa);
            this.Controls.Add(this.Cbo_EditarTipoDespesa);
            this.Controls.Add(this.Lbl_EditarTipoDespesa);
            this.Controls.Add(this.Btn_EditarSalvarDespesa);
            this.Controls.Add(this.Cbo_EditarPagaDespesa);
            this.Controls.Add(this.Lbl_EditarPagaDespesa);
            this.Controls.Add(this.Dtp_EditarDataDespesa);
            this.Controls.Add(this.Lbl_EditarDataDespesa);
            this.Controls.Add(this.Txt_EditarDescricaoDespesa);
            this.Controls.Add(this.Lbl_EditarDescricaoDespesa);
            this.Controls.Add(this.Lbl_EditarValorDespesa);
            this.Name = "FormEditarDespesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.FormEditarDespesas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_EditarValorDespesa;
        private System.Windows.Forms.Label Lbl_EditarDescricaoDespesa;
        private System.Windows.Forms.TextBox Txt_EditarDescricaoDespesa;
        private System.Windows.Forms.Label Lbl_EditarDataDespesa;
        private System.Windows.Forms.DateTimePicker Dtp_EditarDataDespesa;
        private System.Windows.Forms.Label Lbl_EditarPagaDespesa;
        private System.Windows.Forms.ComboBox Cbo_EditarPagaDespesa;
        private System.Windows.Forms.Button Btn_EditarSalvarDespesa;
        private System.Windows.Forms.Label Lbl_EditarTipoDespesa;
        private System.Windows.Forms.ComboBox Cbo_EditarTipoDespesa;
        private System.Windows.Forms.MaskedTextBox Msk_EditarValorDespesa;
    }
}