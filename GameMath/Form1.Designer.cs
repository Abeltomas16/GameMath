namespace GameMath
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
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.N1_lbl = new System.Windows.Forms.Label();
            this.N2_lbl = new System.Windows.Forms.Label();
            this.Sinal_lbl = new System.Windows.Forms.Label();
            this.Resposta_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // N1_lbl
            // 
            this.N1_lbl.AutoSize = true;
            this.N1_lbl.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N1_lbl.Location = new System.Drawing.Point(42, 105);
            this.N1_lbl.Name = "N1_lbl";
            this.N1_lbl.Size = new System.Drawing.Size(102, 116);
            this.N1_lbl.TabIndex = 0;
            this.N1_lbl.Text = "0";
            // 
            // N2_lbl
            // 
            this.N2_lbl.AutoSize = true;
            this.N2_lbl.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N2_lbl.Location = new System.Drawing.Point(254, 104);
            this.N2_lbl.Name = "N2_lbl";
            this.N2_lbl.Size = new System.Drawing.Size(102, 116);
            this.N2_lbl.TabIndex = 1;
            this.N2_lbl.Text = "0";
            // 
            // Sinal_lbl
            // 
            this.Sinal_lbl.AutoSize = true;
            this.Sinal_lbl.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sinal_lbl.Location = new System.Drawing.Point(168, 142);
            this.Sinal_lbl.Name = "Sinal_lbl";
            this.Sinal_lbl.Size = new System.Drawing.Size(49, 58);
            this.Sinal_lbl.TabIndex = 2;
            this.Sinal_lbl.Text = "x";
            // 
            // Resposta_txt
            // 
            this.Resposta_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Resposta_txt.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resposta_txt.Location = new System.Drawing.Point(396, 104);
            this.Resposta_txt.Multiline = true;
            this.Resposta_txt.Name = "Resposta_txt";
            this.Resposta_txt.Size = new System.Drawing.Size(160, 117);
            this.Resposta_txt.TabIndex = 3;
            this.Resposta_txt.TextChanged += new System.EventHandler(this.tb1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(619, 306);
            this.Controls.Add(this.Resposta_txt);
            this.Controls.Add(this.Sinal_lbl);
            this.Controls.Add(this.N2_lbl);
            this.Controls.Add(this.N1_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GameMath";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label N1_lbl;
        private System.Windows.Forms.Label N2_lbl;
        private System.Windows.Forms.Label Sinal_lbl;
        private System.Windows.Forms.TextBox Resposta_txt;
    }
}

