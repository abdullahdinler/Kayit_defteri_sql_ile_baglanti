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

namespace Kayit_defteri_sql_ile_baglanti
{
    public partial class Istatistik : Form
    {
        private SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UdemyDers;Integrated Security=True");

        public Istatistik()
        {
            InitializeComponent();
        }

        private void Istatistik_Load(object sender, EventArgs e)
        {
            // Toplam Personel Sayisi
            baglanti.Open();
            SqlCommand toplam_p_sayisi = new SqlCommand("select count(*) from Personel_Bilgi", baglanti);
            SqlDataReader sdr1 = toplam_p_sayisi.ExecuteReader();
            while (sdr1.Read())
            {
                tpslbl.Text = sdr1[0].ToString();
            }
            baglanti.Close();


            //Evli Personel Sayisi
            baglanti.Open();
            SqlCommand evli_p_sayisi = new SqlCommand("select count(*) from Personel_Bilgi where Durum = 1", baglanti);
            SqlDataReader sdr2 = evli_p_sayisi.ExecuteReader();
            while (sdr2.Read())
            {
                epstlb.Text = sdr2[0].ToString();
            }
            baglanti.Close();


            // Bekar Personel Sayisi
            baglanti.Open();
            SqlCommand bekar_p_sayisi = new SqlCommand("select count(*) from Personel_Bilgi where Durum = 0", baglanti);
            SqlDataReader sdr3 = bekar_p_sayisi.ExecuteReader();
            while (sdr3.Read())
            {
                bpslbl.Text = sdr3[0].ToString();
            }
            baglanti.Close();


            //Sehir Sayisi
            baglanti.Open();
            SqlCommand sehir_p_sayisi = new SqlCommand("select count(DISTINCT Sehir) from Personel_Bilgi", baglanti);
            SqlDataReader sdr4 = sehir_p_sayisi.ExecuteReader();
            while (sdr4.Read())
            {
                sehirslbl.Text = sdr4[0].ToString();
            }
            baglanti.Close();


            // Toplam Maas
            baglanti.Open();
            SqlCommand toplam_p_maas = new SqlCommand("select sum(Maas) from Personel_Bilgi", baglanti);
            SqlDataReader sdr5 = toplam_p_maas.ExecuteReader();
            while (sdr5.Read())
            {
                tmlbl.Text = sdr5[0].ToString();
            }
            baglanti.Close();
        }
    }
}
