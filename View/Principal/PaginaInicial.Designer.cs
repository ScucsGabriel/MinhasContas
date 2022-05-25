namespace MinhasContas.View
{
    partial class FormPrincipal
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Tsl_Receita = new System.Windows.Forms.ToolStripLabel();
            this.Tsl_Despesa = new System.Windows.Forms.ToolStripLabel();
            this.Tsl_Relatorio = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsl_Receita,
            this.Tsl_Despesa,
            this.Tsl_Relatorio});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Tsl_Receita
            // 
            this.Tsl_Receita.Name = "Tsl_Receita";
            this.Tsl_Receita.Size = new System.Drawing.Size(45, 22);
            this.Tsl_Receita.Text = "Receita";
            this.Tsl_Receita.Click += new System.EventHandler(this.Tsl_Receita_Click);
            // 
            // Tsl_Despesa
            // 
            this.Tsl_Despesa.Name = "Tsl_Despesa";
            this.Tsl_Despesa.Size = new System.Drawing.Size(50, 22);
            this.Tsl_Despesa.Text = "Despesa";
            this.Tsl_Despesa.Click += new System.EventHandler(this.Tsl_Despesa_Click);
            // 
            // Tsl_Relatorio
            // 
            this.Tsl_Relatorio.Name = "Tsl_Relatorio";
            this.Tsl_Relatorio.Size = new System.Drawing.Size(54, 22);
            this.Tsl_Relatorio.Text = "Relatório";
            this.Tsl_Relatorio.Click += new System.EventHandler(this.Tsl_Relatorio_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaginaInicial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel Tsl_Receita;
        private System.Windows.Forms.ToolStripLabel Tsl_Despesa;
        private System.Windows.Forms.ToolStripLabel Tsl_Relatorio;
    }
}