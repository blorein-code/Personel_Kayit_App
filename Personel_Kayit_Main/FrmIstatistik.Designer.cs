namespace Personel_Kayit_Main
{
    partial class FrmIstatistik
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toplamLabel = new System.Windows.Forms.Label();
            this.evliLabel = new System.Windows.Forms.Label();
            this.bekarLabel = new System.Windows.Forms.Label();
            this.sehirLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toplamMaasLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ortalamaMaasLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Personel Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Evli Personel Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bekar Personel Sayısı:";
            // 
            // toplamLabel
            // 
            this.toplamLabel.AutoSize = true;
            this.toplamLabel.Location = new System.Drawing.Point(203, 57);
            this.toplamLabel.Name = "toplamLabel";
            this.toplamLabel.Size = new System.Drawing.Size(13, 13);
            this.toplamLabel.TabIndex = 3;
            this.toplamLabel.Text = "0";
            // 
            // evliLabel
            // 
            this.evliLabel.AutoSize = true;
            this.evliLabel.Location = new System.Drawing.Point(203, 95);
            this.evliLabel.Name = "evliLabel";
            this.evliLabel.Size = new System.Drawing.Size(13, 13);
            this.evliLabel.TabIndex = 4;
            this.evliLabel.Text = "0";
            // 
            // bekarLabel
            // 
            this.bekarLabel.AutoSize = true;
            this.bekarLabel.Location = new System.Drawing.Point(203, 137);
            this.bekarLabel.Name = "bekarLabel";
            this.bekarLabel.Size = new System.Drawing.Size(13, 13);
            this.bekarLabel.TabIndex = 5;
            this.bekarLabel.Text = "0";
            // 
            // sehirLabel
            // 
            this.sehirLabel.AutoSize = true;
            this.sehirLabel.Location = new System.Drawing.Point(203, 182);
            this.sehirLabel.Name = "sehirLabel";
            this.sehirLabel.Size = new System.Drawing.Size(13, 13);
            this.sehirLabel.TabIndex = 7;
            this.sehirLabel.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Şehir Sayısı:";
            // 
            // toplamMaasLabel
            // 
            this.toplamMaasLabel.AutoSize = true;
            this.toplamMaasLabel.Location = new System.Drawing.Point(203, 216);
            this.toplamMaasLabel.Name = "toplamMaasLabel";
            this.toplamMaasLabel.Size = new System.Drawing.Size(13, 13);
            this.toplamMaasLabel.TabIndex = 9;
            this.toplamMaasLabel.Text = "0";
            this.toplamMaasLabel.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(113, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Toplam Maaş:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // ortalamaMaasLabel
            // 
            this.ortalamaMaasLabel.AutoSize = true;
            this.ortalamaMaasLabel.Location = new System.Drawing.Point(203, 248);
            this.ortalamaMaasLabel.Name = "ortalamaMaasLabel";
            this.ortalamaMaasLabel.Size = new System.Drawing.Size(13, 13);
            this.ortalamaMaasLabel.TabIndex = 11;
            this.ortalamaMaasLabel.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(106, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Ortalama Maaş:";
            // 
            // FrmIstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 298);
            this.Controls.Add(this.ortalamaMaasLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.toplamMaasLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sehirLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bekarLabel);
            this.Controls.Add(this.evliLabel);
            this.Controls.Add(this.toplamLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmIstatistik";
            this.Text = "FrmIstatistik";
            this.Load += new System.EventHandler(this.FrmIstatistik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label toplamLabel;
        private System.Windows.Forms.Label evliLabel;
        private System.Windows.Forms.Label bekarLabel;
        private System.Windows.Forms.Label sehirLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label toplamMaasLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ortalamaMaasLabel;
        private System.Windows.Forms.Label label12;
    }
}