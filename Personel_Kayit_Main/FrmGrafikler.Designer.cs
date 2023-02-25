namespace Personel_Kayit_Main
{
    partial class FrmGrafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Sehirler = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Maaslar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Sehirler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maaslar)).BeginInit();
            this.SuspendLayout();
            // 
            // Sehirler
            // 
            chartArea3.Name = "ChartArea1";
            this.Sehirler.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Sehirler.Legends.Add(legend3);
            this.Sehirler.Location = new System.Drawing.Point(42, 32);
            this.Sehirler.Name = "Sehirler";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Sehirler";
            series3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.Sehirler.Series.Add(series3);
            this.Sehirler.Size = new System.Drawing.Size(321, 300);
            this.Sehirler.TabIndex = 0;
            this.Sehirler.Tag = "";
            this.Sehirler.Text = "chart1";
            this.Sehirler.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Maaslar
            // 
            chartArea4.Name = "ChartArea1";
            this.Maaslar.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.Maaslar.Legends.Add(legend4);
            this.Maaslar.Location = new System.Drawing.Point(423, 32);
            this.Maaslar.Name = "Maaslar";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Meslek-Maas";
            series4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.Maaslar.Series.Add(series4);
            this.Maaslar.Size = new System.Drawing.Size(343, 300);
            this.Maaslar.TabIndex = 1;
            this.Maaslar.Text = "chart2";
            // 
            // FrmGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 380);
            this.Controls.Add(this.Maaslar);
            this.Controls.Add(this.Sehirler);
            this.Name = "FrmGrafikler";
            this.Text = "FrmGrafikler";
            this.Load += new System.EventHandler(this.FrmGrafikler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sehirler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maaslar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Sehirler;
        private System.Windows.Forms.DataVisualization.Charting.Chart Maaslar;
    }
}