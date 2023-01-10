using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;            //diğer bilgisayarlara
using System.Net;           //erişmemi sağlayacak
using System.Net.Sockets;   //kodların kütüphaneleri

namespace WindowsFormsApp4
{
    public partial class Arayuz : Form
    {
        SqlConnection veritabani = new SqlConnection("Data Source=.;Initial Catalog=InternetKafe;Integrated Security=True");
        TcpListener dinleyiciSoket = new TcpListener(System.Net.IPAddress.Any, 10048);//10048 portunu dinlemeye alıyoruz
        public void dongu()
        {
            for (int i = 0; i < 9; i++)
            {
                if (masa_durum[i] == 1)//bu kod satırında masa açıldığında masanın uygulamasına binary 1 değeri gönderiyoruz
                {
                    Socket istemciSoketi = dinleyiciSoket.AcceptSocket();
                    NetworkStream nwokuma = new NetworkStream(istemciSoketi);
                    BinaryWriter bw = new BinaryWriter(nwokuma);
                    int masam = i + 1;
                    string oku = masam.ToString() + "1";
                    bw.Write(oku);
                    istemciSoketi.Close();
                }
                else//bu kod satırında masa kapandığında masanın uygulamasına binary 0 değeri gönderiyoruz
                {
                    Socket istemciSoketi = dinleyiciSoket.AcceptSocket();
                    NetworkStream nwokuma = new NetworkStream(istemciSoketi);
                    BinaryWriter bw = new BinaryWriter(nwokuma);
                    int masam = i + 1;
                    string oku = masam.ToString() + "0";
                    bw.Write(oku);
                    istemciSoketi.Close();
                }
            }
        }
        //DEĞİŞKENLER
        string suanki_zaman;
        int secili_pc = 0;
        int[] pc_kalan_sure = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] acik_kalan_sure = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        double[] masa_borcu = new double[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] masa_durum = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        //MASANIN DURUMUNA GÖRE ÇALIŞAN FONKSİYON
        public void masa_durumu()
        {
            for (int i=0;i<9;i++)
            {
                if (pc_kalan_sure[i] < 0 && masa_durum[i] == 1)
                {
                    masa_durum[i] = 0;
                    masa_kapa();
                    MessageBox.Show("Masa : " + (i + 1).ToString() + "\n" + "Masanın açık kaldığı süre : " + acik_kalan_sure[i].ToString() + " dakika" + "\n" + "Masanın Borcu : " + masa_borcu[i].ToString() + " TL");
                    label8.Text = "==> " + pc_kalan_sure[i].ToString() + " dakika";
                    label2.Text = "==> " + acik_kalan_sure[i].ToString() + " dakika";
                    label6.Text = "==> " + masa_borcu[i].ToString() + " TL";
                    int masa_no = i + 1;
                    veritabani.Open();
                    SqlCommand komut = new SqlCommand("Insert into Hesap([Masa No],[Açıldığı Zaman],[Açık Kaldığı Süre],[Masa Borcu])VALUES('" + masa_no + "','"+suanki_zaman+ "','"+acik_kalan_sure[i].ToString() + "','"+masa_borcu[i].ToString() + "')", veritabani);
                    komut.ExecuteNonQuery();
                    veritabani.Close();
                    pc_kalan_sure[i] = 0;
                    acik_kalan_sure[i] = 0;
                    masa_borcu[i] = 0;
                }
            }
        }
        //MASA KAPANDIĞINDA ÇALIŞAN FONKSİYON
        public void masa_kapa()
        {
            if (masa_durum[secili_pc]==0)
            {
            button1.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            label9.Visible = false;
            label2.Visible = false;
            label4.Visible = true;
            button11.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            }
        }
        //MASA AÇILDIĞINDA ÇALIŞAN FONKSİYON
        public void masa_ac()
        {
            button1.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = true;
            label9.Visible = true;
            label2.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label4.Visible = false;
        }
        public Arayuz()
        {
            InitializeComponent();
        }
        //DİĞER FORMLARI AÇAN BUTONLAR
        private void Button2_Click(object sender, EventArgs e)
        {
            Kullaniciadisifredegistirme frm4 = new Kullaniciadisifredegistirme();
            frm4.Show();
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            Hasilatbilgileri frm6 = new Hasilatbilgileri();
            frm6.Show();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            dinleyiciSoket.Start();  //dinleyiciyi çalıştırıyoruz
            System.Diagnostics.Process.Start("client.exe");  //backgroundworker a veriyi yazabilecek bir yer oluşturuyoruz
            tarih.Enabled = true;
            acik_kaldigi_sure.Start();
            kalan_sure.Start();
            dinleyiciSoket.Start();
        }
        //FORMA BASILDIĞINDA MASA BİLGİLERİNİ KALDIRAN CLICK OLAYI
        private void Form2_Click(object sender, EventArgs e)
        {
            pc_secili.Visible = false;
        }
        //TIMER OLAYLARI
        private void Timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
            suanki_zaman = label3.Text;
        }
        private void kontrol_Tick(object sender, EventArgs e)
        {
            if (pc_secili.Visible == true) //eğer herhangi bir picturebox(pc) seçilmişse panelin aktif olmasını sağlıyor
            {
                panel1.Visible = true;
            }
            if (pc_secili.Visible == false) //eğer herhangi bir picturebox(pc) seçilmemişse panelin devre dışı kalmasını sağlıyor
            {
                panel1.Visible = false;
            }
        }
        private void kalan_sure_Tick(object sender, EventArgs e) //kalan süreyi belirten fonksiyon
        {
            for (int i = 0; i < 9; i++)
            {
                if (masa_durum[i] == 1)
                {
                    pc_kalan_sure[i]--;
                    label8.Text = "==> " + pc_kalan_sure[i].ToString() + " dakika";
                    masa_durumu();
                }
            }
        }
        private void acik_kaldigi_sure_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                if (masa_durum[i] == 1)
                {
                    acik_kalan_sure[i]++;
                    if (acik_kalan_sure[i] % 1 == 0) //açık kaldığı her dakika borcun belli bir miktar artmasını sağlıyor
                    {
                        masa_borcu[i] += 0.050;
                    }
                }
                if (secili_pc == i)  //seçili olan masanın anlık masa borcunu ve açık kalan süresini yazdırıyor
                {
                    label2.Text = "==> " + acik_kalan_sure[i].ToString() + " dakika";
                    label6.Text = "==> " + masa_borcu[i].ToString() + " TL";
                }
            }
        }
        //SEÇİLMİŞ OLAN PICTUREBOX(MASA)'NIN SEÇİLDİĞİNİ ANLAMAK İÇİN ETRAFINI ÇEVRELEYEN PICTUREBOXUN KOMUTU
        private void pcsecili(object sender, EventArgs e)
        {
            pc_secili.Left = ((PictureBox)(sender)).Left - 6;
            pc_secili.Top = ((PictureBox)(sender)).Top - 8;
            pc_secili.Visible = true;
        }
        //PROGRAMI KAPAT BUTONU
        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //MASA AÇMA BUTONLARI
        private void button1_Click(object sender, EventArgs e)
        {
            masa_durum[secili_pc] = 1; //bu butonlara tıklandığında seçili masanın durumunu 1 yaparak masayı açmamız sağlanıyor
            pc_kalan_sure[secili_pc] = 15;  //seçili olan masanın kaç dakikalık açılacağı
            masa_ac(); //masa açma fonksiyonu çağrılıyor 

        }
        private void button8_Click(object sender, EventArgs e)
        {
            masa_durum[secili_pc] = 1;
            pc_kalan_sure[secili_pc] = 30;
            masa_ac();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            masa_durum[secili_pc] = 1;
            pc_kalan_sure[secili_pc] = 45;
            masa_ac();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            masa_durum[secili_pc] = 1;
            pc_kalan_sure[secili_pc] = 60;
            masa_ac();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            masa_durum[secili_pc] = 1;
            pc_kalan_sure[secili_pc] = 90;
            masa_ac();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            masa_durum[secili_pc] = 1;
            pc_kalan_sure[secili_pc] = 9999;
            masa_ac();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            masa_durum[secili_pc] = 1;
            pc_kalan_sure[secili_pc] = 75;
            masa_ac();
        }
        //MASA KAPAT BUTONU
        private void button11_Click(object sender, EventArgs e)
        {
            pc_kalan_sure[secili_pc] = -1;
            masa_durumu();
        }
        //PICTUREBOX(MASA)'LARA TIKLANDIĞINDA ÇALIŞACAK KODLAR
        private void pc_1_click(object sender, EventArgs e)
        {
            pcsecili(sender, e);
            secili_pc = 0;
            if(masa_durum[secili_pc]==0)
            {
                masa_kapa();
            }
            else
            {
                masa_ac();
            }
        }
        private void pc_2_click(object sender, EventArgs e)
        {
            pcsecili(sender, e);
            secili_pc = 1;
            if (masa_durum[secili_pc] == 0)
            {
                masa_kapa();
            }
            else
            {
                masa_ac();
            }
        }
        private void pc_3_click(object sender, EventArgs e)
        {
            pcsecili(sender, e);
            secili_pc = 2;
            if (masa_durum[secili_pc] == 0)
            {
                masa_kapa();
            }
            else
            {
                masa_ac();
            }
        }
        private void pc_4_click(object sender, EventArgs e)
        {
            pcsecili(sender, e);
            secili_pc = 3;
            if (masa_durum[secili_pc] == 0)
            {
                masa_kapa();
            }
            else
            {
                masa_ac();
            }
        }
        private void pc_5_click(object sender, EventArgs e)
        {
            pcsecili(sender, e);
            secili_pc = 4;
            if (masa_durum[secili_pc] == 0)
            {
                masa_kapa();
            }
            else
            {
                masa_ac();
            }
        }
        private void pc_6_click(object sender, EventArgs e)
        {
            pcsecili(sender, e);
            secili_pc = 5;
            if (masa_durum[secili_pc] == 0)
            {
                masa_kapa();
            }
            else
            {
                masa_ac();
            }
        }
        private void pc_7_click(object sender, EventArgs e)
        {
            pcsecili(sender, e);
            secili_pc = 6;
            if (masa_durum[secili_pc] == 0)
            {
                masa_kapa();
            }
            else
            {
                masa_ac();
            }
        }
        private void pc_8_click(object sender, EventArgs e)
        {
            pcsecili(sender, e);
            secili_pc = 7;
            if (masa_durum[secili_pc] == 0)
            {
                masa_kapa();
            }
            else
            {
                masa_ac();
            }

        }
        private void pc_9_click(object sender, EventArgs e)
        {
            pcsecili(sender, e);
            secili_pc = 8;
            if (masa_durum[secili_pc] == 0)
            {
                masa_kapa();
            }
            else
            {
                masa_ac();
            }
        }
        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync(); //backgroundworker'ın timer yardımıyla sürekli çalışması için
        }
        private void BackgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            dongu(); //backgroundworker'ın yapacağı iş
        }
    }
}
