namespace Parcelas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnParcelar = new System.Windows.Forms.Button();
            this.lstParcela = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor gasto:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(122, 21);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(79, 20);
            this.txtValor.TabIndex = 1;
            // 
            // btnParcelar
            // 
            this.btnParcelar.Location = new System.Drawing.Point(84, 77);
            this.btnParcelar.Name = "btnParcelar";
            this.btnParcelar.Size = new System.Drawing.Size(95, 41);
            this.btnParcelar.TabIndex = 2;
            this.btnParcelar.Text = "Parcelar";
            this.btnParcelar.UseVisualStyleBackColor = true;
            this.btnParcelar.Click += new System.EventHandler(this.btnParcelar_Click);
            // 
            // lstParcela
            // 
            this.lstParcela.FormattingEnabled = true;
            this.lstParcela.Location = new System.Drawing.Point(59, 138);
            this.lstParcela.Name = "lstParcela";
            this.lstParcela.Size = new System.Drawing.Size(141, 95);
            this.lstParcela.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lstParcela);
            this.Controls.Add(this.btnParcelar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnParcelar;
        private System.Windows.Forms.ListBox lstParcela;
    }
}

