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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2CTA39P;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void chart1_Click(object sender, EventArgs e)
        {

           
        }

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            //Sehirler Grafigi
            baglanti.Open();
            SqlCommand komutGOne = new SqlCommand("Select PerSehir,Count(*) From Tbl_Personel group by PerSehir", baglanti);
            SqlDataReader reader = komutGOne.ExecuteReader();
            while (reader.Read())
            {
                Sehirler.Series["Sehirler"].Points.AddXY(reader[0], reader[1]);
            }
            baglanti.Close();


            // Meslek-Maaş Grafigi

            baglanti.Open();
            SqlCommand komutGTwo = new SqlCommand("Select PerMeslek,Avg(PerMaas) From Tbl_Personel group by PerMeslek", baglanti);
            SqlDataReader readerTwo = komutGTwo.ExecuteReader();
            while (readerTwo.Read())
            {
                Maaslar.Series["Meslek-Maas"].Points.AddXY(readerTwo[0], readerTwo[1]);
            }
            baglanti.Close();
        }
    }
}
