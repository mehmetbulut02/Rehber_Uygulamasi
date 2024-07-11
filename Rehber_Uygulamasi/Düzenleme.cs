using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Rehber_Uygulamasi
{
    public partial class Düzenleme : Form
    {
        public Düzenleme()
        {
            InitializeComponent();
        }

        private void Düzenleme_Load(object sender, EventArgs e)
        {
            textBox1.Text = Program.ID;
            textBox2.Text = Program.tc_no;
            textBox3.Text = Program.ad;
            textBox4.Text = Program.soyad;
            textBox5.Text = Program.tel_no;
            textBox6.Text = Program.memleket;
            textBox7.Text = Program.doğum_yili;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("provider = microsoft.jet.oledb.4.0; data source=veri_tabani.mdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update icerik set tc_no=@tc_no,ad=@ad,soyad=@soyad,tel_no=@tel_no,memleket=@memleket,doğum_yili=@doğum_yili where kimlik=@kimlik",baglanti);
            komut.Parameters.AddWithValue("@tc_no", textBox2.Text);
            komut.Parameters.AddWithValue("@ad", textBox3.Text);
            komut.Parameters.AddWithValue("@soyad", textBox4.Text);
            komut.Parameters.AddWithValue("@tel_no", textBox5.Text);
            komut.Parameters.AddWithValue("@memleket", textBox6.Text);
            komut.Parameters.AddWithValue("@doğum_yili", textBox7.Text);
            komut.Parameters.AddWithValue("@kimlik", textBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Düzenleme işlemi başarılı oldu.");
            icerik frm = new icerik();
            frm.Show();
            this.Close();
        }
    }
}
