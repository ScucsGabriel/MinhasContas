namespace MinhasContas.View.Receitas
{
    partial class FormIncluirReceitas
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
            this.Lbl_IncluirValorReceita = new System.Windows.Forms.Label();
            this.Lbl_IncluirDescricaoReceita = new System.Windows.Forms.Label();
            this.Txt_IncluirDescricaoReceita = new System.Windows.Forms.TextBox();
            this.Lbl_IncluirDataReceita = new System.Windows.Forms.Label();
            this.Dtp_IncluirDataReceita = new System.Windows.Forms.DateTimePicker();
            this.Btn_IncluirSalvarReceita = new System.Windows.Forms.Button();
            this.Msk_IncluirValorReceita = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Lbl_IncluirValorReceita
            // 
            this.Lbl_IncluirValorReceita.AutoSize = true;
            this.Lbl_IncluirValorReceita.Location = new System.Drawing.Point(36, 25);
            this.Lbl_IncluirValorReceita.Name = "Lbl_IncluirValorReceita";
            this.Lbl_IncluirValorReceita.Size = new System.Drawing.Size(31, 13);
            this.Lbl_IncluirValorReceita.TabIndex = 5;
            this.Lbl_IncluirValorReceita.Text = "Valor";
            // 
            // Lbl_IncluirDescricaoReceita
            // 
            this.Lbl_IncluirDescricaoReceita.AutoSize = true;
            this.Lbl_IncluirDescricaoReceita.Location = new System.Drawing.Point(12, 55);
            this.Lbl_IncluirDescricaoReceita.Name = "Lbl_IncluirDescricaoReceita";
            this.Lbl_IncluirDescricaoReceita.Size = new System.Drawing.Size(55, 13);
            this.Lbl_IncluirDescricaoReceita.TabIndex = 6;
            this.Lbl_IncluirDescricaoReceita.Text = "Descrição";
            // 
            // Txt_IncluirDescricaoReceita
            // 
            this.Txt_IncluirDescricaoReceita.Location = new System.Drawing.Point(73, 55);
            this.Txt_IncluirDescricaoReceita.Name = "Txt_IncluirDescricaoReceita";
            this.Txt_IncluirDescricaoReceita.Size = new System.Drawing.Size(146, 20);
            this.Txt_IncluirDescricaoReceita.TabIndex = 2;
            // 
            // Lbl_IncluirDataReceita
            // 
            this.Lbl_IncluirDataReceita.AutoSize = true;
            this.Lbl_IncluirDataReceita.Location = new System.Drawing.Point(36, 87);
            this.Lbl_IncluirDataReceita.Name = "Lbl_IncluirDataReceita";
            this.Lbl_IncluirDataReceita.Size = new System.Drawing.Size(30, 13);
            this.Lbl_IncluirDataReceita.TabIndex = 7;
            this.Lbl_IncluirDataReceita.Text = "Data";
            // 
            // Dtp_IncluirDataReceita
            // 
            this.Dtp_IncluirDataReceita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_IncluirDataReceita.Location = new System.Drawing.Point(73, 87);
            this.Dtp_IncluirDataReceita.Name = "Dtp_IncluirDataReceita";
            this.Dtp_IncluirDataReceita.Size = new System.Drawing.Size(146, 20);
            this.Dtp_IncluirDataReceita.TabIndex = 3;
            // 
            // Btn_IncluirSalvarReceita
            // 
            this.Btn_IncluirSalvarReceita.Location = new System.Drawing.Point(144, 125);
            this.Btn_IncluirSalvarReceita.Name = "Btn_IncluirSalvarReceita";
            this.Btn_IncluirSalvarReceita.Size = new System.Drawing.Size(75, 23);
            this.Btn_IncluirSalvarReceita.TabIndex = 4;
            this.Btn_IncluirSalvarReceita.Text = "Salvar";
            this.Btn_IncluirSalvarReceita.UseVisualStyleBackColor = true;
            this.Btn_IncluirSalvarReceita.Click += new System.EventHandler(this.Btn_IncluirSalvarReceita_Click);
            // 
            // Msk_IncluirValorReceita
            // 
            this.Msk_IncluirValorReceita.Location = new System.Drawing.Point(73, 22);
            this.Msk_IncluirValorReceita.Mask = "$#####,##";
            this.Msk_IncluirValorReceita.Name = "Msk_IncluirValorReceita";
            this.Msk_IncluirValorReceita.Size = new System.Drawing.Size(146, 20);
            this.Msk_IncluirValorReceita.TabIndex = 1;
            this.Msk_IncluirValorReceita.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Msk_IncluirValorReceita_KeyDown);
            // 
            // FormIncluirReceitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 159);
            this.Controls.Add(this.Msk_IncluirValorReceita);
            this.Controls.Add(this.Btn_IncluirSalvarReceita);
            this.Controls.Add(this.Dtp_IncluirDataReceita);
            this.Controls.Add(this.Lbl_IncluirDataReceita);
            this.Controls.Add(this.Txt_IncluirDescricaoReceita);
            this.Controls.Add(this.Lbl_IncluirDescricaoReceita);
            this.Controls.Add(this.Lbl_IncluirValorReceita);
            this.Name = "FormIncluirReceitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incluir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_IncluirValorReceita;
        private System.Windows.Forms.Label Lbl_IncluirDescricaoReceita;
        private System.Windows.Forms.TextBox Txt_IncluirDescricaoReceita;
        private System.Windows.Forms.Label Lbl_IncluirDataReceita;
        private System.Windows.Forms.DateTimePicker Dtp_IncluirDataReceita;
        private System.Windows.Forms.Button Btn_IncluirSalvarReceita;
        private System.Windows.Forms.MaskedTextBox Msk_IncluirValorReceita;
    }
}