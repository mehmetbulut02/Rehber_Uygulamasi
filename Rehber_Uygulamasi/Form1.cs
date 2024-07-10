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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Çıkmak İstediğinize Emin Misiniz ?", "Çıkış İşlemi", MessageBoxButtons.YesNo );
            if (onay == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbConnection baglanti = new OleDbConnection("provider = microsoft.jet.oledb.4.0; data source=veri_tabani.mdb");
                baglanti.Open();
                OleDbCommand sorgu = new OleDbCommand("select kad,sifre from kullaniciislemleri where kad=@kad and sifre=@sifre", baglanti);
                sorgu.Parameters.AddWithValue("@kad", textBox1.Text);
                sorgu.Parameters.AddWithValue("@sifre", textBox2.Text);
                OleDbDataReader dr;
                dr = sorgu.ExecuteReader();
                if (dr.Read())
                {
                    if (gkod == Convert.ToInt16(textBox3.Text))
                    {
                        icerik frm = new icerik();
                        frm.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Güvenlik Kodunu Yanlış Girdiniz !", "Uyarı!");
                    }
                }
                else
                {
                    baglanti.Close();
                    MessageBox.Show("Yanlış kullanıcı adı veya parolası. Lütfen tekrar deneyeiniz", "Hata!");
                }
            }
            catch
            {
                MessageBox.Show("Lütfen kullanıcı ad ve parolanız ile giris yapınız.");
            }
            finally 
            {
                textBox1.Text = "";
                textBox2.Clear();  // iki yöntemde aynı ise yarıyor
                textBox3.Clear();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Clear();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Çıkmak İstediğinize Emin Misiniz ?", "Çıkış İşlemi", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        int gkod;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            gkod = r.Next(1000, 9999);
            label4.Text = gkod.ToString();
        }
    }
}
