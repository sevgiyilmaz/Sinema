namespace Sinema
{
    partial class Form3
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblToplamIzleyici = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstIzleyiciler = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblErkekIzleyici = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblBayanIzleyici = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblToplamIzleyici);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(285, 19);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox2.Size = new System.Drawing.Size(350, 120);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toplam İzleyici Sayısı";
            // 
            // lblToplamIzleyici
            // 
            this.lblToplamIzleyici.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamIzleyici.Location = new System.Drawing.Point(12, 34);
            this.lblToplamIzleyici.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblToplamIzleyici.Name = "lblToplamIzleyici";
            this.lblToplamIzleyici.Size = new System.Drawing.Size(326, 54);
            this.lblToplamIzleyici.TabIndex = 0;
            this.lblToplamIzleyici.Text = "-";
            this.lblToplamIzleyici.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstIzleyiciler);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(6, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox1.Size = new System.Drawing.Size(267, 425);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film İzleyenler";
            // 
            // lstIzleyiciler
            // 
            this.lstIzleyiciler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstIzleyiciler.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstIzleyiciler.FormattingEnabled = true;
            this.lstIzleyiciler.ItemHeight = 31;
            this.lstIzleyiciler.Location = new System.Drawing.Point(0, 45);
            this.lstIzleyiciler.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.lstIzleyiciler.Name = "lstIzleyiciler";
            this.lstIzleyiciler.Size = new System.Drawing.Size(267, 376);
            this.lstIzleyiciler.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblErkekIzleyici);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(285, 155);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox3.Size = new System.Drawing.Size(350, 120);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Erkek İzleyici Sayisi";
            // 
            // lblErkekIzleyici
            // 
            this.lblErkekIzleyici.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblErkekIzleyici.Location = new System.Drawing.Point(12, 48);
            this.lblErkekIzleyici.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblErkekIzleyici.Name = "lblErkekIzleyici";
            this.lblErkekIzleyici.Size = new System.Drawing.Size(326, 54);
            this.lblErkekIzleyici.TabIndex = 0;
            this.lblErkekIzleyici.Text = "-";
            this.lblErkekIzleyici.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblBayanIzleyici);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(285, 314);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox4.Size = new System.Drawing.Size(350, 120);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bayan İzleyici Sayisi";
            // 
            // lblBayanIzleyici
            // 
            this.lblBayanIzleyici.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBayanIzleyici.Location = new System.Drawing.Point(12, 49);
            this.lblBayanIzleyici.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBayanIzleyici.Name = "lblBayanIzleyici";
            this.lblBayanIzleyici.Size = new System.Drawing.Size(326, 54);
            this.lblBayanIzleyici.TabIndex = 0;
            this.lblBayanIzleyici.Text = "-";
            this.lblBayanIzleyici.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 439);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblToplamIzleyici;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstIzleyiciler;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblErkekIzleyici;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblBayanIzleyici;
    }
}