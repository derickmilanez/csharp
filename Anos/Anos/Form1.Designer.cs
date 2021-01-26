namespace Anos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.lstBis = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(44, 64);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(133, 32);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "button1";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(44, 12);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(133, 20);
            this.txtAno.TabIndex = 1;
            // 
            // lstBis
            // 
            this.lstBis.FormattingEnabled = true;
            this.lstBis.Location = new System.Drawing.Point(44, 115);
            this.lstBis.Name = "lstBis";
            this.lstBis.Size = new System.Drawing.Size(132, 303);
            this.lstBis.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 492);
            this.Controls.Add(this.lstBis);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.ListBox lstBis;
    }
}

