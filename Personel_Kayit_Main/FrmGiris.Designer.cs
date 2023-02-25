namespace Personel_Kayit_Main
{
    partial class FrmGiris
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
            this.kullaniciAdLabel = new System.Windows.Forms.TextBox();
            this.sifreLabel = new System.Windows.Forms.TextBox();
            this.girisBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // kullaniciAdLabel
            // 
            this.kullaniciAdLabel.Location = new System.Drawing.Point(138, 85);
            this.kullaniciAdLabel.Name = "kullaniciAdLabel";
            this.kullaniciAdLabel.Size = new System.Drawing.Size(146, 20);
            this.kullaniciAdLabel.TabIndex = 2;
            // 
            // sifreLabel
            // 
            this.sifreLabel.Location = new System.Drawing.Point(138, 123);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(146, 20);
            this.sifreLabel.TabIndex = 3;
            this.sifreLabel.TextChanged += new System.EventHandler(this.sifreLabel_TextChanged);
            this.sifreLabel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sifreLabel_KeyPress);
            // 
            // girisBtn
            // 
            this.girisBtn.Location = new System.Drawing.Point(138, 161);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(146, 23);
            this.girisBtn.TabIndex = 4;
            this.girisBtn.Text = "Giriş Yap";
            this.girisBtn.UseVisualStyleBackColor = true;
            this.girisBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Personel Takip Sistemi Giriş Paneli";
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(393, 219);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.sifreLabel);
            this.Controls.Add(this.kullaniciAdLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmGiris";
            this.Text = "FrmGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kullaniciAdLabel;
        private System.Windows.Forms.TextBox sifreLabel;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.Label label3;
    }
}