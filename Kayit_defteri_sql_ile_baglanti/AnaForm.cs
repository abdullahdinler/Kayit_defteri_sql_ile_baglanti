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
    public partial class AnaForm : Form
    {
        private SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UdemyDers;Integrated Security=True");

        void Temizle()
        {
            idtxtbox.Text = "";
            adtxtbox.Text = "";
            soyadtxtbox.Text = "";
            sehirtxtbox.Text = "";
            maastxtbox.Text = "";
            evlirbtn.Checked = false;
            bekarrbtn.Checked = false;
            meslektxtbox.Text = "";
        }

        public AnaForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'udemyDersDataSet1.Personel_Bilgi' table. You can move, or remove it, as needed.
            this.personel_BilgiTableAdapter.Fill(this.udemyDersDataSet1.Personel_Bilgi);
            

        }

        private void listelebtn_Click(object sender, EventArgs e)
        {
            this.personel_BilgiTableAdapter.Fill(this.udemyDersDataSet1.Personel_Bilgi);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            idtxtbox.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            adtxtbox.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyadtxtbox.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            sehirtxtbox.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maastxtbox.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            meslektxtbox.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void evlirbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (evlirbtn.Checked == true)
            {
                label8.Text = "True";
            }
        }

        private void bekarrbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (bekarrbtn.Checked == false)
            {
                label8.Text = "False";
            }
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                evlirbtn.Checked = true;
            }

            if (label8.Text == "False")
            {
                bekarrbtn.Checked = true;
            }
        }

        private void temizlebtn_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open(); // sql baglantisini acar.
            SqlCommand komut_kaydet = new SqlCommand("insert into Personel_Bilgi (Ad,Soyad,Sehir,Maas,Durum,Meslek) values(@ad,@soyad,@sehir,@maas,@durum,@meslek)", baglanti);
            komut_kaydet.Parameters.AddWithValue("@ad", adtxtbox.Text); // Burada bir atama islemi yaptik ad parametresine adtextbox taki degeri atadik.
            komut_kaydet.Parameters.AddWithValue("@soyad", soyadtxtbox.Text);
            komut_kaydet.Parameters.AddWithValue("@sehir", sehirtxtbox.Text);
            komut_kaydet.Parameters.AddWithValue("@maas", maastxtbox.Text);
            komut_kaydet.Parameters.AddWithValue("@durum", label8.Text);
            komut_kaydet.Parameters.AddWithValue("@meslek", meslektxtbox.Text);
            komut_kaydet.ExecuteNonQuery(); // Sorguyu calistiriyor.
            baglanti.Close(); // sql baglantisini kapatir.
            MessageBox.Show("Veri eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void silbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut_sil = new SqlCommand("Delete From Personel_Bilgi Where Id = @id", baglanti);
            komut_sil.Parameters.AddWithValue("@id", idtxtbox.Text);
            komut_sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Veri Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut_guncelle = new SqlCommand("Update Personel_Bilgi set Ad = @ad,Soyad = @soyad, Sehir = @sehir, Maas = @maas, Durum = @durum, Meslek = @meslek where Id = @id", baglanti);
            komut_guncelle.Parameters.AddWithValue("@id", idtxtbox.Text);
            komut_guncelle.Parameters.AddWithValue("@ad", adtxtbox.Text);
            komut_guncelle.Parameters.AddWithValue("@soyad", soyadtxtbox.Text);
            komut_guncelle.Parameters.AddWithValue("@sehir", sehirtxtbox.Text);
            komut_guncelle.Parameters.AddWithValue("@maas", maastxtbox.Text);
            komut_guncelle.Parameters.AddWithValue("@durum", label8.Text);
            komut_guncelle.Parameters.AddWithValue("@meslek", meslektxtbox.Text);
            komut_guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Veri Guncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void istatistikbtn_Click(object sender, EventArgs e)
        {
            Istatistik fr2 = new Istatistik();
            fr2.Show(); // form 2 goster
            //this.Hide(); form1 gizler
        }

        private void grafikbtn_Click(object sender, EventArgs e)
        {
            Grafikler fr3 = new Grafikler();
            fr3.Show();
        }
    }
}
