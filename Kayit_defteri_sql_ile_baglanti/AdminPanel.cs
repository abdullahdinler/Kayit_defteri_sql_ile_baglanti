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
    public partial class AdminPanel : Form
    {
        private SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UdemyDers;Integrated Security=True");

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Admin girisi
            baglanti.Open();
            SqlCommand admin = new SqlCommand("Select * from Personel_Admin where kullaniciadi = @kad and sifre = @sifre", baglanti); // personel admin tablosundaki veri ile girilen veri uyusuyormu diye kontrol ediyoruz.
            admin.Parameters.AddWithValue("@kad", kadtext.Text);
            admin.Parameters.AddWithValue("@sifre", sifretxt.Text);
            SqlDataReader dradmin = admin.ExecuteReader();

            if (dradmin.Read())
            {
                AnaForm frm = new AnaForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatali kullanici adi ve sifre.", "Bilgi", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }

            baglanti.Close();
        }
    }
}
