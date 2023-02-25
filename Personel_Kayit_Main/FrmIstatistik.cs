using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_Kayit_Main
{
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2CTA39P;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            //Toplam Personel Sayısı
            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("Select Count(*) From Tbl_Personel", baglanti);
            SqlDataReader reader = komut1.ExecuteReader();

            while (reader.Read())
            {
                toplamLabel.Text = reader[0].ToString();
            }

            baglanti.Close();

            //Evli Personel Sayısı

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Count(*) From Tbl_Personel Where PerDurum = 1",baglanti);
            SqlDataReader readerTwo = komut2.ExecuteReader();
            while (readerTwo.Read())
            {
                evliLabel.Text = readerTwo[0].ToString();
            }
            baglanti.Close();

            //Bekar Personel Sayısı

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) From Tbl_Personel Where PerDurum = 0", baglanti);
            SqlDataReader readerThree = komut3.ExecuteReader();
            while (readerThree.Read())
            {
                bekarLabel.Text = readerThree[0].ToString();
            }
            baglanti.Close();   

            //Şehir Sayısı

            baglanti.Open();

            SqlCommand komut4 = new SqlCommand("Select count(distinct (PerSehir))  From Tbl_Personel",baglanti);
            SqlDataReader readerFour = komut4.ExecuteReader();
            while (readerFour.Read())
            {
                sehirLabel.Text = readerFour[0].ToString();
            }
            baglanti.Close();

            //Toplam Maaş
            baglanti.Open();

            SqlCommand komut5 = new SqlCommand("Select Sum(PerMaas) From Tbl_Personel",baglanti);
            SqlDataReader readerFive = komut5.ExecuteReader();
            while (readerFive.Read())
            {
                toplamMaasLabel.Text = readerFive[0].ToString();
            }
            baglanti.Close();

            //Ortalama Maaş

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select Avg((PerMaas)) From Tbl_Personel",baglanti);
            SqlDataReader readerSix = komut6.ExecuteReader();
            while (readerSix.Read())
            {
                ortalamaMaasLabel.Text = readerSix[0].ToString();
            }
            baglanti.Close();
        }
    }
}
