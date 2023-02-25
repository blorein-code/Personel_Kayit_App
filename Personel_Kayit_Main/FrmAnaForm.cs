using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Kayit_Main
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2CTA39P;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        void temizle()
        {
            txtId.Text = "";
            txtAd.Text = "";
            txtMaas.Text = "";
            txtMeslek.Text = "";
            txtSoyad.Text = "";
            comboSehir.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtAd.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet.Tbl_Personel' table. You can move, or remove it, as needed.
            //this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            //p1 ve p2 isimli parametreler alındı. Tbl_Personel Tablosunun hangi kolonlarına ekleme yapılacak.
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel(PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);

            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", comboSehir.Text);
            komut.Parameters.AddWithValue("@p4", txtMaas.Text);
            komut.Parameters.AddWithValue("@p5", txtMeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            //Insert çalışması için ExecuteNonQuery!
            komut.ExecuteNonQuery();


            baglanti.Close();

            MessageBox.Show("Personel Eklendi");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           if(radioButton1.Checked == true)
            {
                label8.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "False";
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if(label8.Text== "True")
            {
                radioButton1.Checked = true;
            }
            if(label8.Text== "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutSil = new SqlCommand("Delete From Tbl_Personel Where Perid=@k1",baglanti);
            komutSil.Parameters.AddWithValue("@k1", txtId.Text);
            komutSil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutGuncelle = new SqlCommand("Update Tbl_Personel Set PerAd=@p1,PerSoyad=@p2,PerSehir=@p3,PerMaas=@p4,PerMeslek=@p5,PerDurum=@p6 where Perid=@p7", baglanti);

            komutGuncelle.Parameters.AddWithValue("@p1", txtAd.Text);
            komutGuncelle.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komutGuncelle.Parameters.AddWithValue("@p3", comboSehir.Text);
            komutGuncelle.Parameters.AddWithValue("@p4", txtMaas.Text);
            komutGuncelle.Parameters.AddWithValue("@p5", txtMeslek.Text);
            komutGuncelle.Parameters.AddWithValue("@p6", label8.Text);
            komutGuncelle.Parameters.AddWithValue("@p7", txtId.Text);
            komutGuncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Bilgisi Güncellendi");
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik fr = new FrmIstatistik();
            fr.Show();
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler frGrafik = new FrmGrafikler();
            frGrafik.Show();
        }
    }
}
