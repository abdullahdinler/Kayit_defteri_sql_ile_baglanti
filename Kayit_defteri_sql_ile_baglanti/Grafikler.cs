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
    public partial class Grafikler : Form
    {
        private SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UdemyDers;Integrated Security=True");

        public Grafikler()
        {
            InitializeComponent();
        }

        private void Grafikler_Load(object sender, EventArgs e)
        {
            // Grafik bir --> Her sehirde kac kisi var
            baglanti.Open();
            SqlCommand grfk1 = new SqlCommand("Select Sehir,count(*) from Personel_Bilgi group by Sehir", baglanti);
            SqlDataReader drf1 = grfk1.ExecuteReader();
            while (drf1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(drf1[0], drf1[1]);
            }
            baglanti.Close();


            // Grafik iki --> Meslek maas grafiyi
            baglanti.Open();
            SqlCommand grfk2 = new SqlCommand("select Meslek,avg(Maas) from Personel_Bilgi group by meslek", baglanti);
            SqlDataReader drf2 = grfk2.ExecuteReader();
            while (drf2.Read())
            {
                chart2.Series["Meslek_Maas"].Points.AddXY(drf2[0], drf2[1]);

            }
            baglanti.Close();
        }
    }
}
