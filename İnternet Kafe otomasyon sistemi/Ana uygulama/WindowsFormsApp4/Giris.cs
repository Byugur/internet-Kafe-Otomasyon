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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=UĞUR;Initial Catalog=InternetKafe;Integrated Security=True");
        private void Button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Kullanici where k_adi='" + textBox2.Text + "'and sifre='" + textBox3.Text + "'",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Arayuz frm2 = new Arayuz();
                frm2.Show();
                this.Hide();
            }
            else
            MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
            baglanti.Close();
        }
    }
}
