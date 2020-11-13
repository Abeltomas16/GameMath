namespace GameMath
{
    partial class secand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(secand));
            this.xuiColorPane1 = new XanderUI.XUIColorPane();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiColorPane1
            // 
            this.xuiColorPane1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.xuiColorPane1.Color10 = System.Drawing.Color.LightGreen;
            this.xuiColorPane1.Color11 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.xuiColorPane1.Color12 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.xuiColorPane1.Color13 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(216)))), ((int)(((byte)(54)))));
            this.xuiColorPane1.Color14 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(120)))));
            this.xuiColorPane1.Color2 = System.Drawing.Color.Lime;
            this.xuiColorPane1.Color3 = System.Drawing.Color.Green;
            this.xuiColorPane1.Color4 = System.Drawing.Color.DarkGreen;
            this.xuiColorPane1.Color5 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.xuiColorPane1.Color6 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xuiColorPane1.Color7 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.xuiColorPane1.Color8 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuiColorPane1.Color9 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiColorPane1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuiColorPane1.GridColor = System.Drawing.Color.White;
            this.xuiColorPane1.Location = new System.Drawing.Point(16, 19);
            this.xuiColorPane1.Name = "xuiColorPane1";
            this.xuiColorPane1.SelectedColor = System.Drawing.Color.Empty;
            this.xuiColorPane1.ShowGrid = false;
            this.xuiColorPane1.Size = new System.Drawing.Size(313, 100);
            this.xuiColorPane1.TabIndex = 0;
            this.xuiColorPane1.Text = "xuiColorPane1";
            this.xuiColorPane1.ColorChanged += new System.EventHandler(this.xuiColorPane1_ColorChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.xuiColorPane1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 146);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cor";
            // 
            // secand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(359, 309);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "secand";
            this.Text = "GameMath";
            this.Load += new System.EventHandler(this.secand_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIColorPane xuiColorPane1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}