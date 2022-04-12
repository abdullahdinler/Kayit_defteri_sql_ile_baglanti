
namespace Kayit_defteri_sql_ile_baglanti
{
    partial class AnaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bekarrbtn = new System.Windows.Forms.RadioButton();
            this.evlirbtn = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.meslektxtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maastxtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sehirtxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.soyadtxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adtxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idtxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grafikbtn = new System.Windows.Forms.Button();
            this.istatistikbtn = new System.Windows.Forms.Button();
            this.temizlebtn = new System.Windows.Forms.Button();
            this.guncellebtn = new System.Windows.Forms.Button();
            this.silbtn = new System.Windows.Forms.Button();
            this.kaydetbtn = new System.Windows.Forms.Button();
            this.listelebtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.meslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelBilgiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.udemyDersDataSet1 = new Kayit_defteri_sql_ile_baglanti.UdemyDersDataSet1();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.personelBilgiTableAdapter = new Kayit_defteri_sql_ile_baglanti.UdemyDersDataSetTableAdapters.PersonelBilgiTableAdapter();
            this.personel_BilgiTableAdapter = new Kayit_defteri_sql_ile_baglanti.UdemyDersDataSet1TableAdapters.Personel_BilgiTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBilgiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udemyDersDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bekarrbtn);
            this.groupBox1.Controls.Add(this.evlirbtn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.meslektxtbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.maastxtbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.sehirtxtbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.soyadtxtbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.adtxtbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.idtxtbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 312);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // bekarrbtn
            // 
            this.bekarrbtn.AutoSize = true;
            this.bekarrbtn.Location = new System.Drawing.Point(173, 215);
            this.bekarrbtn.Name = "bekarrbtn";
            this.bekarrbtn.Size = new System.Drawing.Size(76, 25);
            this.bekarrbtn.TabIndex = 14;
            this.bekarrbtn.TabStop = true;
            this.bekarrbtn.Text = "Bekar";
            this.bekarrbtn.UseVisualStyleBackColor = true;
            this.bekarrbtn.CheckedChanged += new System.EventHandler(this.bekarrbtn_CheckedChanged);
            // 
            // evlirbtn
            // 
            this.evlirbtn.AutoSize = true;
            this.evlirbtn.Location = new System.Drawing.Point(85, 215);
            this.evlirbtn.Name = "evlirbtn";
            this.evlirbtn.Size = new System.Drawing.Size(61, 25);
            this.evlirbtn.TabIndex = 13;
            this.evlirbtn.TabStop = true;
            this.evlirbtn.Text = "Evli";
            this.evlirbtn.UseVisualStyleBackColor = true;
            this.evlirbtn.CheckedChanged += new System.EventHandler(this.evlirbtn_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Durum:";
            // 
            // meslektxtbox
            // 
            this.meslektxtbox.Location = new System.Drawing.Point(85, 252);
            this.meslektxtbox.Name = "meslektxtbox";
            this.meslektxtbox.Size = new System.Drawing.Size(164, 28);
            this.meslektxtbox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Meslek:";
            // 
            // maastxtbox
            // 
            this.maastxtbox.Location = new System.Drawing.Point(85, 180);
            this.maastxtbox.Name = "maastxtbox";
            this.maastxtbox.Size = new System.Drawing.Size(164, 28);
            this.maastxtbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Maas:";
            // 
            // sehirtxtbox
            // 
            this.sehirtxtbox.Location = new System.Drawing.Point(85, 146);
            this.sehirtxtbox.Name = "sehirtxtbox";
            this.sehirtxtbox.Size = new System.Drawing.Size(164, 28);
            this.sehirtxtbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sehir:";
            // 
            // soyadtxtbox
            // 
            this.soyadtxtbox.Location = new System.Drawing.Point(85, 112);
            this.soyadtxtbox.Name = "soyadtxtbox";
            this.soyadtxtbox.Size = new System.Drawing.Size(164, 28);
            this.soyadtxtbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad:";
            // 
            // adtxtbox
            // 
            this.adtxtbox.Location = new System.Drawing.Point(85, 77);
            this.adtxtbox.Name = "adtxtbox";
            this.adtxtbox.Size = new System.Drawing.Size(164, 28);
            this.adtxtbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad:";
            // 
            // idtxtbox
            // 
            this.idtxtbox.Enabled = false;
            this.idtxtbox.Location = new System.Drawing.Point(85, 43);
            this.idtxtbox.Name = "idtxtbox";
            this.idtxtbox.Size = new System.Drawing.Size(164, 28);
            this.idtxtbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grafikbtn);
            this.groupBox2.Controls.Add(this.istatistikbtn);
            this.groupBox2.Controls.Add(this.temizlebtn);
            this.groupBox2.Controls.Add(this.guncellebtn);
            this.groupBox2.Controls.Add(this.silbtn);
            this.groupBox2.Controls.Add(this.kaydetbtn);
            this.groupBox2.Controls.Add(this.listelebtn);
            this.groupBox2.Location = new System.Drawing.Point(519, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 312);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Işlemler";
            // 
            // grafikbtn
            // 
            this.grafikbtn.Location = new System.Drawing.Point(6, 273);
            this.grafikbtn.Name = "grafikbtn";
            this.grafikbtn.Size = new System.Drawing.Size(245, 35);
            this.grafikbtn.TabIndex = 6;
            this.grafikbtn.Text = "Grafikler";
            this.grafikbtn.UseVisualStyleBackColor = true;
            this.grafikbtn.Click += new System.EventHandler(this.grafikbtn_Click);
            // 
            // istatistikbtn
            // 
            this.istatistikbtn.Location = new System.Drawing.Point(6, 232);
            this.istatistikbtn.Name = "istatistikbtn";
            this.istatistikbtn.Size = new System.Drawing.Size(245, 35);
            this.istatistikbtn.TabIndex = 5;
            this.istatistikbtn.Text = "Istatistik";
            this.istatistikbtn.UseVisualStyleBackColor = true;
            this.istatistikbtn.Click += new System.EventHandler(this.istatistikbtn_Click);
            // 
            // temizlebtn
            // 
            this.temizlebtn.Location = new System.Drawing.Point(6, 191);
            this.temizlebtn.Name = "temizlebtn";
            this.temizlebtn.Size = new System.Drawing.Size(245, 35);
            this.temizlebtn.TabIndex = 4;
            this.temizlebtn.Text = "Temizle";
            this.temizlebtn.UseVisualStyleBackColor = true;
            this.temizlebtn.Click += new System.EventHandler(this.temizlebtn_Click);
            // 
            // guncellebtn
            // 
            this.guncellebtn.Location = new System.Drawing.Point(6, 150);
            this.guncellebtn.Name = "guncellebtn";
            this.guncellebtn.Size = new System.Drawing.Size(245, 35);
            this.guncellebtn.TabIndex = 3;
            this.guncellebtn.Text = "Guncelle";
            this.guncellebtn.UseVisualStyleBackColor = true;
            this.guncellebtn.Click += new System.EventHandler(this.guncellebtn_Click);
            // 
            // silbtn
            // 
            this.silbtn.Location = new System.Drawing.Point(6, 109);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(245, 35);
            this.silbtn.TabIndex = 2;
            this.silbtn.Text = "Sil";
            this.silbtn.UseVisualStyleBackColor = true;
            this.silbtn.Click += new System.EventHandler(this.silbtn_Click);
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.Location = new System.Drawing.Point(6, 68);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(245, 35);
            this.kaydetbtn.TabIndex = 1;
            this.kaydetbtn.Text = "Kaydet";
            this.kaydetbtn.UseVisualStyleBackColor = true;
            this.kaydetbtn.Click += new System.EventHandler(this.kaydetbtn_Click);
            // 
            // listelebtn
            // 
            this.listelebtn.Location = new System.Drawing.Point(6, 27);
            this.listelebtn.Name = "listelebtn";
            this.listelebtn.Size = new System.Drawing.Size(245, 35);
            this.listelebtn.TabIndex = 0;
            this.listelebtn.Text = "Listele";
            this.listelebtn.UseVisualStyleBackColor = true;
            this.listelebtn.Click += new System.EventHandler(this.listelebtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(25, 330);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(751, 193);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayitlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.sehirDataGridViewTextBoxColumn,
            this.maasDataGridViewTextBoxColumn,
            this.durumDataGridViewCheckBoxColumn,
            this.meslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBilgiBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 166);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // sehirDataGridViewTextBoxColumn
            // 
            this.sehirDataGridViewTextBoxColumn.DataPropertyName = "Sehir";
            this.sehirDataGridViewTextBoxColumn.HeaderText = "Sehir";
            this.sehirDataGridViewTextBoxColumn.Name = "sehirDataGridViewTextBoxColumn";
            // 
            // maasDataGridViewTextBoxColumn
            // 
            this.maasDataGridViewTextBoxColumn.DataPropertyName = "Maas";
            this.maasDataGridViewTextBoxColumn.HeaderText = "Maas";
            this.maasDataGridViewTextBoxColumn.Name = "maasDataGridViewTextBoxColumn";
            // 
            // durumDataGridViewCheckBoxColumn
            // 
            this.durumDataGridViewCheckBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewCheckBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewCheckBoxColumn.Name = "durumDataGridViewCheckBoxColumn";
            // 
            // meslekDataGridViewTextBoxColumn
            // 
            this.meslekDataGridViewTextBoxColumn.DataPropertyName = "Meslek";
            this.meslekDataGridViewTextBoxColumn.HeaderText = "Meslek";
            this.meslekDataGridViewTextBoxColumn.Name = "meslekDataGridViewTextBoxColumn";
            // 
            // personelBilgiBindingSource1
            // 
            this.personelBilgiBindingSource1.DataMember = "Personel_Bilgi";
            this.personelBilgiBindingSource1.DataSource = this.udemyDersDataSet1;
            // 
            // udemyDersDataSet1
            // 
            this.udemyDersDataSet1.DataSetName = "UdemyDersDataSet1";
            this.udemyDersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(309, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // personelBilgiTableAdapter
            // 
            this.personelBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // personel_BilgiTableAdapter
            // 
            this.personel_BilgiTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(356, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 21);
            this.label8.TabIndex = 4;
            this.label8.Visible = false;
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(797, 529);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "AnaForm";
            this.Text = "Kayıt Defteri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBilgiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udemyDersDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton bekarrbtn;
        private System.Windows.Forms.RadioButton evlirbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox meslektxtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox maastxtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sehirtxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox soyadtxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adtxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idtxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button grafikbtn;
        private System.Windows.Forms.Button istatistikbtn;
        private System.Windows.Forms.Button temizlebtn;
        private System.Windows.Forms.Button guncellebtn;
        private System.Windows.Forms.Button silbtn;
        private System.Windows.Forms.Button kaydetbtn;
        private System.Windows.Forms.Button listelebtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private UdemyDersDataSetTableAdapters.PersonelBilgiTableAdapter personelBilgiTableAdapter;
        private UdemyDersDataSet1 udemyDersDataSet1;
        private System.Windows.Forms.BindingSource personelBilgiBindingSource1;
        private UdemyDersDataSet1TableAdapters.Personel_BilgiTableAdapter personel_BilgiTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn durumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meslekDataGridViewTextBoxColumn;
    }
}

