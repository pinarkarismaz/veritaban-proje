using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kafe
{
    public partial class Form1 : Form

    {
        int masaNo=0;
      
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            masaNo = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            masaNo = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            masaNo = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
            masaNo = 4;
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=kafe; user Id=postgres; password=alifatma");
        private void btnlistele_Click(object sender, EventArgs e)
        {
            string sorgu = "select* from siparisler";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("Delete From siparisler where siparisid=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtid.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İslem basarili");
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into siparisler (personelNo,masaid,urunAdi,urunAdedi,siparisid,siparistarihii) values (@p1,@p2,@p3,@p4,@p5,@p6) ", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(txtpersonelid.Text));
            komut1.Parameters.AddWithValue("@p4", int.Parse(comboBox2.Text));
            komut1.Parameters.AddWithValue("@p5", int.Parse(txtsiparisid.Text));
            komut1.Parameters.AddWithValue("@p3", comboBox1.SelectedItem);
            komut1.Parameters.AddWithValue("@p2", masaNo);
            komut1.Parameters.AddWithValue("@p6", dateTimePicker1.Value);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İslem basarili");
            
        }

        private void btnlistele2_Click(object sender, EventArgs e)
        {
            string sorgu = "select* from urunler";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update urunler set stokMiktar=@p1 where urunid=@p2", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(txtstok.Text));
            komut3.Parameters.AddWithValue("@p2", int.Parse(txtstokid.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İslem basarili ");
        }
    }
}
