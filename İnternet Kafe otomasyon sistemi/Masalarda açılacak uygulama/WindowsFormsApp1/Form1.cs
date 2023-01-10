using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;           //ana bilgisayara
using System.Net;          //erişmemi sağlayacak
using System.Net.Sockets;  //kodların kütüphaneleri
using System.Diagnostics;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string oku = "";
        public void masaokuma()
        {
            if (oku.Substring(1, 1) == "1")  //ana uygulamadan gelen değer 1 ise masa açılıyor
            {
                this.Hide();  //Masa açıldığında formu gizli kılıyor
            }
            else if (oku.Substring(1, 1) == "0")  //ana uygulamadan gelen değer 0 ise masa kapatılıyor
            {
                this.Show(); //Masa kapandığında formu tekrar açıyor ve masa kitleniyor
                int w = Screen.PrimaryScreen.Bounds.Width;
                int h = Screen.PrimaryScreen.Bounds.Height;
                this.Location = new Point(0, 0);
                this.Size = new Size(w, h);
                TopMost = true;  //Bu komutla form her zaman önde kalıyor ve diğer uygulamalara erişim sağlanmasını engelliyor
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        //formun tam ekranı kaplaması için gerekli kodlar
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            Socket istemciBaglantisi = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            istemciBaglantisi.Connect(IPAddress.Parse("192.168.1.105"), 10048); //ana uygulama ile ip adresi ve belirlenen port üzerinden bağlantı kuruyoruz
            NetworkStream agAkis = new NetworkStream(istemciBaglantisi);  
            BinaryReader binaryokuyucu = new BinaryReader(agAkis);  //ana uygulamadan gelen binary değeri alıyor
            oku = binaryokuyucu.ReadString();  //ana uygulamadan gelen binary değeri değişkene atıyoruz
            agAkis.Close();
            binaryokuyucu.Close();
            if (oku.Substring(0,1)==Form2.masa.Substring(0,1))
            {
                masaokuma();  //masa açmak için gerekli olan fonksiyonu çalıştırıyor. Eğer manuel olarak atadığımız masa numarası ana uygulamadaki masa numarası ile uyuşuyorsa bu fonksiyon sayesinde masa açılıp kapatılıyor.

            }
            istemciBaglantisi.Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; //Formun hiçbir şekilde kapanmamasını sağlayan komut
        }
    }
}
