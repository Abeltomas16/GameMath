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
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.N1_lbl = new System.Windows.Forms.Label();
            this.N2_lbl = new System.Windows.Forms.Label();
            this.Sinal_lbl = new System.Windows.Forms.Label();
            this.Resposta_txt = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Discarte os números depois da vírgula se existir.";
            this.label1.Visible = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(11, 255);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(239, 23);
            this.bunifuSeparator1.TabIndex = 11;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // N1_lbl
            // 
            this.N1_lbl.AutoSize = true;
            this.N1_lbl.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N1_lbl.Location = new System.Drawing.Point(65, 42);
            this.N1_lbl.Name = "N1_lbl";
            this.N1_lbl.Size = new System.Drawing.Size(102, 116);
            this.N1_lbl.TabIndex = 0;
            this.N1_lbl.Text = "0";
            this.N1_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // N2_lbl
            // 
            this.N2_lbl.AutoSize = true;
            this.N2_lbl.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N2_lbl.Location = new System.Drawing.Point(65, 147);
            this.N2_lbl.Name = "N2_lbl";
            this.N2_lbl.Size = new System.Drawing.Size(102, 116);
            this.N2_lbl.TabIndex = 1;
            this.N2_lbl.Text = "0";
            this.N2_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sinal_lbl
            // 
            this.Sinal_lbl.AutoSize = true;
            this.Sinal_lbl.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sinal_lbl.Location = new System.Drawing.Point(10, 205);
            this.Sinal_lbl.Name = "Sinal_lbl";
            this.Sinal_lbl.Size = new System.Drawing.Size(49, 58);
            this.Sinal_lbl.TabIndex = 2;
            this.Sinal_lbl.Text = "x";
            this.Sinal_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Resposta_txt
            // 
            this.Resposta_txt.BackColor = System.Drawing.Color.White;
            this.Resposta_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Resposta_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resposta_txt.Location = new System.Drawing.Point(85, 275);
            this.Resposta_txt.Mask = "-000";
            this.Resposta_txt.Name = "Resposta_txt";
            this.Resposta_txt.Size = new System.Drawing.Size(193, 109);
            this.Resposta_txt.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Está Certo?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Número Negativo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Número Positivo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lime;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(295, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 146);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(477, 398);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Resposta_txt);
            this.Controls.Add(this.Sinal_lbl);
            this.Controls.Add(this.N2_lbl);
            this.Controls.Add(this.N1_lbl);
            this.Controls.Add(this.bunifuSeparator1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GameMath";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label N1_lbl;
        private System.Windows.Forms.Label N2_lbl;
        private System.Windows.Forms.Label Sinal_lbl;
        private System.Windows.Forms.MaskedTextBox Resposta_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

