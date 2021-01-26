namespace comboparcels
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
            this.txtVal = new System.Windows.Forms.TextBox();
            this.cmbPars = new System.Windows.Forms.ComboBox();
            this.lstPars = new System.Windows.Forms.ListBox();
            this.btnPars = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVal
            // 
            this.txtVal.Location = new System.Drawing.Point(68, 39);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(118, 20);
            this.txtVal.TabIndex = 0;
            // 
            // cmbPars
            // 
            this.cmbPars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPars.FormattingEnabled = true;
            this.cmbPars.Location = new System.Drawing.Point(70, 88);
            this.cmbPars.Name = "cmbPars";
            this.cmbPars.Size = new System.Drawing.Size(116, 21);
            this.cmbPars.TabIndex = 1;
            // 
            // lstPars
            // 
            this.lstPars.FormattingEnabled = true;
            this.lstPars.Location = new System.Drawing.Point(69, 174);
            this.lstPars.Name = "lstPars";
            this.lstPars.Size = new System.Drawing.Size(114, 199);
            this.lstPars.TabIndex = 2;
            // 
            // btnPars
            // 
            this.btnPars.Location = new System.Drawing.Point(70, 136);
            this.btnPars.Name = "btnPars";
            this.btnPars.Size = new System.Drawing.Size(115, 25);
            this.btnPars.TabIndex = 3;
            this.btnPars.Text = "button1";
            this.btnPars.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 443);
            this.Controls.Add(this.btnPars);
            this.Controls.Add(this.lstPars);
            this.Controls.Add(this.cmbPars);
            this.Controls.Add(this.txtVal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.ComboBox cmbPars;
        private System.Windows.Forms.ListBox lstPars;
        private System.Windows.Forms.Button btnPars;
    }
}

