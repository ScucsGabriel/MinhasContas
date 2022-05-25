namespace MinhasContas.View.Relatorios
{
    partial class FormRelatorios
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
            this.Lbl_DataMinimaRelatorio = new System.Windows.Forms.Label();
            this.Dtp_DataMinimaRelatorio = new System.Windows.Forms.DateTimePicker();
            this.Lbl_DataMaximaRelatorio = new System.Windows.Forms.Label();
            this.Dtp_DataMaximaRelatorio = new System.Windows.Forms.DateTimePicker();
            this.Btn_GerarRelatorio = new System.Windows.Forms.Button();
            this.LstView_Relatorio = new System.Windows.Forms.ListView();
            this.Btn_SalvarXLS = new System.Windows.Forms.Button();
            this.Btn_SalvarPDF = new System.Windows.Forms.Button();
            this.Salvar_XLS = new System.Windows.Forms.SaveFileDialog();
            this.Salvar_PDF = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // Lbl_DataMinimaRelatorio
            // 
            this.Lbl_DataMinimaRelatorio.AutoSize = true;
            this.Lbl_DataMinimaRelatorio.Location = new System.Drawing.Point(28, 28);
            this.Lbl_DataMinimaRelatorio.Name = "Lbl_DataMinimaRelatorio";
            this.Lbl_DataMinimaRelatorio.Size = new System.Drawing.Size(68, 13);
            this.Lbl_DataMinimaRelatorio.TabIndex = 7;
            this.Lbl_DataMinimaRelatorio.Text = "Data Mínima";
            // 
            // Dtp_DataMinimaRelatorio
            // 
            this.Dtp_DataMinimaRelatorio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_DataMinimaRelatorio.Location = new System.Drawing.Point(102, 22);
            this.Dtp_DataMinimaRelatorio.Name = "Dtp_DataMinimaRelatorio";
            this.Dtp_DataMinimaRelatorio.Size = new System.Drawing.Size(117, 20);
            this.Dtp_DataMinimaRelatorio.TabIndex = 1;
            // 
            // Lbl_DataMaximaRelatorio
            // 
            this.Lbl_DataMaximaRelatorio.AutoSize = true;
            this.Lbl_DataMaximaRelatorio.Location = new System.Drawing.Point(237, 28);
            this.Lbl_DataMaximaRelatorio.Name = "Lbl_DataMaximaRelatorio";
            this.Lbl_DataMaximaRelatorio.Size = new System.Drawing.Size(69, 13);
            this.Lbl_DataMaximaRelatorio.TabIndex = 8;
            this.Lbl_DataMaximaRelatorio.Text = "Data Máxima";
            // 
            // Dtp_DataMaximaRelatorio
            // 
            this.Dtp_DataMaximaRelatorio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_DataMaximaRelatorio.Location = new System.Drawing.Point(312, 22);
            this.Dtp_DataMaximaRelatorio.Name = "Dtp_DataMaximaRelatorio";
            this.Dtp_DataMaximaRelatorio.Size = new System.Drawing.Size(117, 20);
            this.Dtp_DataMaximaRelatorio.TabIndex = 2;
            // 
            // Btn_GerarRelatorio
            // 
            this.Btn_GerarRelatorio.Location = new System.Drawing.Point(450, 12);
            this.Btn_GerarRelatorio.Name = "Btn_GerarRelatorio";
            this.Btn_GerarRelatorio.Size = new System.Drawing.Size(118, 44);
            this.Btn_GerarRelatorio.TabIndex = 3;
            this.Btn_GerarRelatorio.Text = "Gerar Relatório";
            this.Btn_GerarRelatorio.UseVisualStyleBackColor = true;
            this.Btn_GerarRelatorio.Click += new System.EventHandler(this.Btn_GerarRelatorio_Click);
            // 
            // LstView_Relatorio
            // 
            this.LstView_Relatorio.HideSelection = false;
            this.LstView_Relatorio.Location = new System.Drawing.Point(31, 71);
            this.LstView_Relatorio.Name = "LstView_Relatorio";
            this.LstView_Relatorio.Size = new System.Drawing.Size(537, 322);
            this.LstView_Relatorio.TabIndex = 4;
            this.LstView_Relatorio.UseCompatibleStateImageBehavior = false;
            // 
            // Btn_SalvarXLS
            // 
            this.Btn_SalvarXLS.Location = new System.Drawing.Point(332, 410);
            this.Btn_SalvarXLS.Name = "Btn_SalvarXLS";
            this.Btn_SalvarXLS.Size = new System.Drawing.Size(115, 28);
            this.Btn_SalvarXLS.TabIndex = 5;
            this.Btn_SalvarXLS.Text = "Salvar XLS";
            this.Btn_SalvarXLS.UseVisualStyleBackColor = true;
            this.Btn_SalvarXLS.Click += new System.EventHandler(this.Btn_SalvarXLS_Click);
            // 
            // Btn_SalvarPDF
            // 
            this.Btn_SalvarPDF.Location = new System.Drawing.Point(453, 410);
            this.Btn_SalvarPDF.Name = "Btn_SalvarPDF";
            this.Btn_SalvarPDF.Size = new System.Drawing.Size(115, 28);
            this.Btn_SalvarPDF.TabIndex = 6;
            this.Btn_SalvarPDF.Text = "Salvar PDF";
            this.Btn_SalvarPDF.UseVisualStyleBackColor = true;
            this.Btn_SalvarPDF.Click += new System.EventHandler(this.Btn_SalvarPDF_Click);
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_SalvarPDF);
            this.Controls.Add(this.Btn_SalvarXLS);
            this.Controls.Add(this.LstView_Relatorio);
            this.Controls.Add(this.Btn_GerarRelatorio);
            this.Controls.Add(this.Dtp_DataMaximaRelatorio);
            this.Controls.Add(this.Lbl_DataMaximaRelatorio);
            this.Controls.Add(this.Dtp_DataMinimaRelatorio);
            this.Controls.Add(this.Lbl_DataMinimaRelatorio);
            this.Name = "FormRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_DataMinimaRelatorio;
        private System.Windows.Forms.DateTimePicker Dtp_DataMinimaRelatorio;
        private System.Windows.Forms.Label Lbl_DataMaximaRelatorio;
        private System.Windows.Forms.DateTimePicker Dtp_DataMaximaRelatorio;
        private System.Windows.Forms.Button Btn_GerarRelatorio;
        private System.Windows.Forms.ListView LstView_Relatorio;
        private System.Windows.Forms.Button Btn_SalvarXLS;
        private System.Windows.Forms.Button Btn_SalvarPDF;
        private System.Windows.Forms.SaveFileDialog Salvar_XLS;
        private System.Windows.Forms.SaveFileDialog Salvar_PDF;
    }
}