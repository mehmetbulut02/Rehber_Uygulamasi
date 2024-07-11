using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rehber_Uygulamasi
{
    public partial class ekle : Form
    {
        public ekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("provider = microsoft.jet.oledb.4.0; data source=veri_tabani.mdb");
            baglanti.Open();

            OleDbCommand sorgu = new OleDbCommand("select tel_no from icerik where tel_no=@tel_no", baglanti);
            sorgu.Parameters.AddWithValue("@tel_no", textBox4.Text);
           
            OleDbDataReader dr;
            dr = sorgu.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Bu Telefon Numarası Zaten Kayıtlı...");
            }
            else
            {
                OleDbCommand komut = new OleDbCommand("insert into icerik(tc_no,ad,soyad,tel_no,memleket,doğum_yili) values(@tc_no,@ad,@soyad,@tel_no,@memleket,@doğum_yili)", baglanti);
                komut.Parameters.AddWithValue("@tc_no", textBox1.Text);
                komut.Parameters.AddWithValue("@ad", textBox2.Text);
                komut.Parameters.AddWithValue("@soyad", textBox3.Text);
                komut.Parameters.AddWithValue("@tel_no", textBox4.Text);
                komut.Parameters.AddWithValue("@memleket", textBox5.Text);
                komut.Parameters.AddWithValue("@doğum_yili", textBox6.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt İşlemi Başarılı");
                icerik frm = new icerik();
                frm.Show();
                this.Close();
            }

           
        }
    }
}
