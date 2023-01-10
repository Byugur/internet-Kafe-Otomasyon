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

namespace WindowsFormsApp4
{
    public partial class Kullaniciadisifredegistirme : Form
    {
        SqlConnection veritabani = new SqlConnection("Data Source=.;Initial Catalog=InternetKafe;Integrated Security=True");
        public Kullaniciadisifredegistirme()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi;
            string yenisifre;
            this.Hide();
            kullaniciadi=textBox1.Text;
            yenisifre = textBox2.Text;
            if (textBox2.Text == textBox3.Text)
            {
                veritabani.Open();
                SqlCommand komut = new SqlCommand("UPDATE Kullanici SET k_adi='" + kullaniciadi + "',sifre='" + yenisifre + "' WHERE id='1' ", veritabani);
                komut.ExecuteNonQuery();
                veritabani.Close();

            }
            else
                MessageBox.Show("Girilen şifreler uyuşmamaktadır.");
        }
    }
}
