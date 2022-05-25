namespace MinhasContas.View.Receitas
{
    partial class FormReceitas
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
            this.Lbl_DescricaoReceita = new System.Windows.Forms.Label();
            this.txt_DescricaoReceita = new System.Windows.Forms.TextBox();
            this.Lbl_DataMinimaReceita = new System.Windows.Forms.Label();
            this.Dtp_DataMinimaReceita = new System.Windows.Forms.DateTimePicker();
            this.Lbl_DataMaximaReceita = new System.Windows.Forms.Label();
            this.Dtp_DataMaximaReceita = new System.Windows.Forms.DateTimePicker();
            this.Btn_BuscaDescricaoReceita = new System.Windows.Forms.Button();
            this.Btn_BuscaDataReceita = new System.Windows.Forms.Button();
            this.Btn_IncluirReceita = new System.Windows.Forms.Button();
            this.Btn_EditarReceita = new System.Windows.Forms.Button();
            this.Btn_RemoverReceita = new System.Windows.Forms.Button();
            this.LstView_Receita = new System.Windows.Forms.ListView();
            this.Lbl_CalcQuantReceitas = new System.Windows.Forms.Label();
            this.Lbl_QuantReceitas = new System.Windows.Forms.Label();
            this.Lbl_CalcTotalReceitas = new System.Windows.Forms.Label();
            this.Lbl_TotalReceitas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_DescricaoReceita
            // 
            this.Lbl_DescricaoReceita.AutoSize = true;
            this.Lbl_DescricaoReceita.Location = new System.Drawing.Point(17, 28);
            this.Lbl_DescricaoReceita.Name = "Lbl_DescricaoReceita";
            this.Lbl_DescricaoReceita.Size = new System.Drawing.Size(55, 13);
            this.Lbl_DescricaoReceita.TabIndex = 10;
            this.Lbl_DescricaoReceita.Text = "Descrição";
            // 
            // txt_DescricaoReceita
            // 
            this.txt_DescricaoReceita.Location = new System.Drawing.Point(78, 25);
            this.txt_DescricaoReceita.Name = "txt_DescricaoReceita";
            this.txt_DescricaoReceita.Size = new System.Drawing.Size(243, 20);
            this.txt_DescricaoReceita.TabIndex = 1;
            // 
            // Lbl_DataMinimaReceita
            // 
            this.Lbl_DataMinimaReceita.AutoSize = true;
            this.Lbl_DataMinimaReceita.Location = new System.Drawing.Point(339, 28);
            this.Lbl_DataMinimaReceita.Name = "Lbl_DataMinimaReceita";
            this.Lbl_DataMinimaReceita.Size = new System.Drawing.Size(68, 13);
            this.Lbl_DataMinimaReceita.TabIndex = 11;
            this.Lbl_DataMinimaReceita.Text = "Data Mínima";
            // 
            // Dtp_DataMinimaReceita
            // 
            this.Dtp_DataMinimaReceita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_DataMinimaReceita.Location = new System.Drawing.Point(413, 25);
            this.Dtp_DataMinimaReceita.Name = "Dtp_DataMinimaReceita";
            this.Dtp_DataMinimaReceita.Size = new System.Drawing.Size(123, 20);
            this.Dtp_DataMinimaReceita.TabIndex = 2;
            // 
            // Lbl_DataMaximaReceita
            // 
            this.Lbl_DataMaximaReceita.AutoSize = true;
            this.Lbl_DataMaximaReceita.Location = new System.Drawing.Point(554, 28);
            this.Lbl_DataMaximaReceita.Name = "Lbl_DataMaximaReceita";
            this.Lbl_DataMaximaReceita.Size = new System.Drawing.Size(69, 13);
            this.Lbl_DataMaximaReceita.TabIndex = 12;
            this.Lbl_DataMaximaReceita.Text = "Data Máxima";
            // 
            // Dtp_DataMaximaReceita
            // 
            this.Dtp_DataMaximaReceita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_DataMaximaReceita.Location = new System.Drawing.Point(629, 25);
            this.Dtp_DataMaximaReceita.Name = "Dtp_DataMaximaReceita";
            this.Dtp_DataMaximaReceita.Size = new System.Drawing.Size(121, 20);
            this.Dtp_DataMaximaReceita.TabIndex = 3;
            // 
            // Btn_BuscaDescricaoReceita
            // 
            this.Btn_BuscaDescricaoReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BuscaDescricaoReceita.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscaDescricaoReceita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_BuscaDescricaoReceita.Location = new System.Drawing.Point(20, 65);
            this.Btn_BuscaDescricaoReceita.Name = "Btn_BuscaDescricaoReceita";
            this.Btn_BuscaDescricaoReceita.Size = new System.Drawing.Size(121, 36);
            this.Btn_BuscaDescricaoReceita.TabIndex = 5;
            this.Btn_BuscaDescricaoReceita.Text = "Buscar por Descrição";
            this.Btn_BuscaDescricaoReceita.UseVisualStyleBackColor = true;
            this.Btn_BuscaDescricaoReceita.Click += new System.EventHandler(this.Btn_BuscaDescricaoReceita_Click);
            // 
            // Btn_BuscaDataReceita
            // 
            this.Btn_BuscaDataReceita.Location = new System.Drawing.Point(169, 65);
            this.Btn_BuscaDataReceita.Name = "Btn_BuscaDataReceita";
            this.Btn_BuscaDataReceita.Size = new System.Drawing.Size(121, 36);
            this.Btn_BuscaDataReceita.TabIndex = 6;
            this.Btn_BuscaDataReceita.Text = "Buscar por Data";
            this.Btn_BuscaDataReceita.UseVisualStyleBackColor = true;
            this.Btn_BuscaDataReceita.Click += new System.EventHandler(this.Btn_BuscaDataReceita_Click);
            // 
            // Btn_IncluirReceita
            // 
            this.Btn_IncluirReceita.Location = new System.Drawing.Point(324, 65);
            this.Btn_IncluirReceita.Name = "Btn_IncluirReceita";
            this.Btn_IncluirReceita.Size = new System.Drawing.Size(121, 36);
            this.Btn_IncluirReceita.TabIndex = 7;
            this.Btn_IncluirReceita.Text = "Incluir";
            this.Btn_IncluirReceita.UseVisualStyleBackColor = true;
            this.Btn_IncluirReceita.Click += new System.EventHandler(this.Btn_IncluirReceita_Click);
            // 
            // Btn_EditarReceita
            // 
            this.Btn_EditarReceita.Location = new System.Drawing.Point(478, 65);
            this.Btn_EditarReceita.Name = "Btn_EditarReceita";
            this.Btn_EditarReceita.Size = new System.Drawing.Size(121, 36);
            this.Btn_EditarReceita.TabIndex = 8;
            this.Btn_EditarReceita.Text = "Editar";
            this.Btn_EditarReceita.UseVisualStyleBackColor = true;
            this.Btn_EditarReceita.Click += new System.EventHandler(this.Btn_EditarReceita_Click);
            // 
            // Btn_RemoverReceita
            // 
            this.Btn_RemoverReceita.Location = new System.Drawing.Point(629, 65);
            this.Btn_RemoverReceita.Name = "Btn_RemoverReceita";
            this.Btn_RemoverReceita.Size = new System.Drawing.Size(121, 36);
            this.Btn_RemoverReceita.TabIndex = 9;
            this.Btn_RemoverReceita.Text = "Remover";
            this.Btn_RemoverReceita.UseVisualStyleBackColor = true;
            this.Btn_RemoverReceita.Click += new System.EventHandler(this.Btn_RemoverReceita_Click);
            // 
            // LstView_Receita
            // 
            this.LstView_Receita.HideSelection = false;
            this.LstView_Receita.Location = new System.Drawing.Point(20, 107);
            this.LstView_Receita.Name = "LstView_Receita";
            this.LstView_Receita.Size = new System.Drawing.Size(730, 468);
            this.LstView_Receita.TabIndex = 4;
            this.LstView_Receita.UseCompatibleStateImageBehavior = false;
            // 
            // Lbl_CalcQuantReceitas
            // 
            this.Lbl_CalcQuantReceitas.AutoSize = true;
            this.Lbl_CalcQuantReceitas.Location = new System.Drawing.Point(17, 592);
            this.Lbl_CalcQuantReceitas.Name = "Lbl_CalcQuantReceitas";
            this.Lbl_CalcQuantReceitas.Size = new System.Drawing.Size(49, 13);
            this.Lbl_CalcQuantReceitas.TabIndex = 13;
            this.Lbl_CalcQuantReceitas.Text = "Receitas";
            // 
            // Lbl_QuantReceitas
            // 
            this.Lbl_QuantReceitas.AutoSize = true;
            this.Lbl_QuantReceitas.Location = new System.Drawing.Point(17, 615);
            this.Lbl_QuantReceitas.Name = "Lbl_QuantReceitas";
            this.Lbl_QuantReceitas.Size = new System.Drawing.Size(13, 13);
            this.Lbl_QuantReceitas.TabIndex = 14;
            this.Lbl_QuantReceitas.Text = "0";
            // 
            // Lbl_CalcTotalReceitas
            // 
            this.Lbl_CalcTotalReceitas.AutoSize = true;
            this.Lbl_CalcTotalReceitas.Location = new System.Drawing.Point(92, 592);
            this.Lbl_CalcTotalReceitas.Name = "Lbl_CalcTotalReceitas";
            this.Lbl_CalcTotalReceitas.Size = new System.Drawing.Size(96, 13);
            this.Lbl_CalcTotalReceitas.TabIndex = 15;
            this.Lbl_CalcTotalReceitas.Text = "Total das Receitas";
            // 
            // Lbl_TotalReceitas
            // 
            this.Lbl_TotalReceitas.AutoSize = true;
            this.Lbl_TotalReceitas.Location = new System.Drawing.Point(92, 615);
            this.Lbl_TotalReceitas.Name = "Lbl_TotalReceitas";
            this.Lbl_TotalReceitas.Size = new System.Drawing.Size(42, 13);
            this.Lbl_TotalReceitas.TabIndex = 16;
            this.Lbl_TotalReceitas.Text = "R$0,00";
            // 
            // FormReceitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 653);
            this.Controls.Add(this.Lbl_TotalReceitas);
            this.Controls.Add(this.Lbl_CalcTotalReceitas);
            this.Controls.Add(this.Lbl_QuantReceitas);
            this.Controls.Add(this.Lbl_CalcQuantReceitas);
            this.Controls.Add(this.LstView_Receita);
            this.Controls.Add(this.Btn_RemoverReceita);
            this.Controls.Add(this.Btn_EditarReceita);
            this.Controls.Add(this.Btn_IncluirReceita);
            this.Controls.Add(this.Btn_BuscaDataReceita);
            this.Controls.Add(this.Btn_BuscaDescricaoReceita);
            this.Controls.Add(this.Dtp_DataMaximaReceita);
            this.Controls.Add(this.Lbl_DataMaximaReceita);
            this.Controls.Add(this.Dtp_DataMinimaReceita);
            this.Controls.Add(this.Lbl_DataMinimaReceita);
            this.Controls.Add(this.txt_DescricaoReceita);
            this.Controls.Add(this.Lbl_DescricaoReceita);
            this.Name = "FormReceitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_DescricaoReceita;
        private System.Windows.Forms.TextBox txt_DescricaoReceita;
        private System.Windows.Forms.Label Lbl_DataMinimaReceita;
        private System.Windows.Forms.DateTimePicker Dtp_DataMinimaReceita;
        private System.Windows.Forms.Label Lbl_DataMaximaReceita;
        private System.Windows.Forms.DateTimePicker Dtp_DataMaximaReceita;
        private System.Windows.Forms.Button Btn_BuscaDescricaoReceita;
        private System.Windows.Forms.Button Btn_BuscaDataReceita;
        private System.Windows.Forms.Button Btn_IncluirReceita;
        private System.Windows.Forms.Button Btn_EditarReceita;
        private System.Windows.Forms.Button Btn_RemoverReceita;
        private System.Windows.Forms.ListView LstView_Receita;
        private System.Windows.Forms.Label Lbl_CalcQuantReceitas;
        private System.Windows.Forms.Label Lbl_QuantReceitas;
        private System.Windows.Forms.Label Lbl_CalcTotalReceitas;
        private System.Windows.Forms.Label Lbl_TotalReceitas;
    }
}