namespace MinhasContas.View.Receitas
{
    partial class FormEditarReceitas
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
            this.Dtp_EditarDataReceita = new System.Windows.Forms.DateTimePicker();
            this.Lbl_EditarDataReceita = new System.Windows.Forms.Label();
            this.Txt_EditarDescricaoReceita = new System.Windows.Forms.TextBox();
            this.Lbl_EditarDescricaoReceita = new System.Windows.Forms.Label();
            this.Lbl_EditarValorReceita = new System.Windows.Forms.Label();
            this.Btn_EditarSalvarReceita = new System.Windows.Forms.Button();
            this.Msk_EditarValorReceita = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Dtp_EditarDataReceita
            // 
            this.Dtp_EditarDataReceita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_EditarDataReceita.Location = new System.Drawing.Point(76, 89);
            this.Dtp_EditarDataReceita.Name = "Dtp_EditarDataReceita";
            this.Dtp_EditarDataReceita.Size = new System.Drawing.Size(146, 20);
            this.Dtp_EditarDataReceita.TabIndex = 3;
            // 
            // Lbl_EditarDataReceita
            // 
            this.Lbl_EditarDataReceita.AutoSize = true;
            this.Lbl_EditarDataReceita.Location = new System.Drawing.Point(39, 89);
            this.Lbl_EditarDataReceita.Name = "Lbl_EditarDataReceita";
            this.Lbl_EditarDataReceita.Size = new System.Drawing.Size(30, 13);
            this.Lbl_EditarDataReceita.TabIndex = 7;
            this.Lbl_EditarDataReceita.Text = "Data";
            // 
            // Txt_EditarDescricaoReceita
            // 
            this.Txt_EditarDescricaoReceita.Location = new System.Drawing.Point(76, 57);
            this.Txt_EditarDescricaoReceita.Name = "Txt_EditarDescricaoReceita";
            this.Txt_EditarDescricaoReceita.Size = new System.Drawing.Size(146, 20);
            this.Txt_EditarDescricaoReceita.TabIndex = 2;
            // 
            // Lbl_EditarDescricaoReceita
            // 
            this.Lbl_EditarDescricaoReceita.AutoSize = true;
            this.Lbl_EditarDescricaoReceita.Location = new System.Drawing.Point(15, 57);
            this.Lbl_EditarDescricaoReceita.Name = "Lbl_EditarDescricaoReceita";
            this.Lbl_EditarDescricaoReceita.Size = new System.Drawing.Size(55, 13);
            this.Lbl_EditarDescricaoReceita.TabIndex = 6;
            this.Lbl_EditarDescricaoReceita.Text = "Descrição";
            // 
            // Lbl_EditarValorReceita
            // 
            this.Lbl_EditarValorReceita.AutoSize = true;
            this.Lbl_EditarValorReceita.Location = new System.Drawing.Point(39, 27);
            this.Lbl_EditarValorReceita.Name = "Lbl_EditarValorReceita";
            this.Lbl_EditarValorReceita.Size = new System.Drawing.Size(31, 13);
            this.Lbl_EditarValorReceita.TabIndex = 5;
            this.Lbl_EditarValorReceita.Text = "Valor";
            // 
            // Btn_EditarSalvarReceita
            // 
            this.Btn_EditarSalvarReceita.Location = new System.Drawing.Point(147, 128);
            this.Btn_EditarSalvarReceita.Name = "Btn_EditarSalvarReceita";
            this.Btn_EditarSalvarReceita.Size = new System.Drawing.Size(75, 23);
            this.Btn_EditarSalvarReceita.TabIndex = 4;
            this.Btn_EditarSalvarReceita.Text = "Salvar";
            this.Btn_EditarSalvarReceita.UseVisualStyleBackColor = true;
            this.Btn_EditarSalvarReceita.Click += new System.EventHandler(this.Btn_EditarSalvarReceita_Click);
            // 
            // Msk_EditarValorReceita
            // 
            this.Msk_EditarValorReceita.Location = new System.Drawing.Point(76, 24);
            this.Msk_EditarValorReceita.Mask = "$#####,##";
            this.Msk_EditarValorReceita.Name = "Msk_EditarValorReceita";
            this.Msk_EditarValorReceita.Size = new System.Drawing.Size(146, 20);
            this.Msk_EditarValorReceita.TabIndex = 1;
            this.Msk_EditarValorReceita.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Msk_EditarValorReceita_KeyDown);
            // 
            // FormEditarReceitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 165);
            this.Controls.Add(this.Msk_EditarValorReceita);
            this.Controls.Add(this.Btn_EditarSalvarReceita);
            this.Controls.Add(this.Dtp_EditarDataReceita);
            this.Controls.Add(this.Lbl_EditarDataReceita);
            this.Controls.Add(this.Txt_EditarDescricaoReceita);
            this.Controls.Add(this.Lbl_EditarDescricaoReceita);
            this.Controls.Add(this.Lbl_EditarValorReceita);
            this.Name = "FormEditarReceitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Dtp_EditarDataReceita;
        private System.Windows.Forms.Label Lbl_EditarDataReceita;
        private System.Windows.Forms.TextBox Txt_EditarDescricaoReceita;
        private System.Windows.Forms.Label Lbl_EditarDescricaoReceita;
        private System.Windows.Forms.Label Lbl_EditarValorReceita;
        private System.Windows.Forms.Button Btn_EditarSalvarReceita;
        private System.Windows.Forms.MaskedTextBox Msk_EditarValorReceita;
    }
}