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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Personel_Kayit_Main
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2CTA39P;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select * From Tbl_Yonetici Where KullaniciAd=@p1 and Sifre=@p2",baglanti);
            komut.Parameters.AddWithValue("@p1", kullaniciAdLabel.Text);
            komut.Parameters.AddWithValue("@p2", sifreLabel.Text);
            SqlDataReader reader = komut.ExecuteReader();
            
            if(reader.Read())
            {
                FrmAnaForm form = new FrmAnaForm();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Bilgileri Hatalı!");
            }

            baglanti.Close();
        }

        private void sifreLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void sifreLabel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!sifreLabel.AcceptsReturn)
                {
                    girisBtn.PerformClick();
                }
            }
        }
    }
}
