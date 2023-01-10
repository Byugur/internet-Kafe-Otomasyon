namespace WindowsFormsApp4
{
    partial class Arayuz
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tarih = new System.Windows.Forms.Timer(this.components);
            this.pc3 = new System.Windows.Forms.PictureBox();
            this.pc6 = new System.Windows.Forms.PictureBox();
            this.pc5 = new System.Windows.Forms.PictureBox();
            this.pc4 = new System.Windows.Forms.PictureBox();
            this.pc9 = new System.Windows.Forms.PictureBox();
            this.pc8 = new System.Windows.Forms.PictureBox();
            this.pc7 = new System.Windows.Forms.PictureBox();
            this.pc_secili = new System.Windows.Forms.PictureBox();
            this.pc1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.kontrol = new System.Windows.Forms.Timer(this.components);
            this.button12 = new System.Windows.Forms.Button();
            this.kalan_sure = new System.Windows.Forms.Timer(this.components);
            this.acik_kaldigi_sure = new System.Windows.Forms.Timer(this.components);
            this.pc2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pc3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_secili)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tarih";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "KARAKURT INTERNET CAFE";
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(14, 164);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 40);
            this.button2.TabIndex = 27;
            this.button2.Text = "KULLANICI ADI VE ŞİFRE DEĞİŞTİR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(14, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(253, 40);
            this.button4.TabIndex = 38;
            this.button4.Text = "HASILAT BİLGİLERİ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // tarih
            // 
            this.tarih.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pc3
            // 
            this.pc3.BackColor = System.Drawing.Color.Transparent;
            this.pc3.Image = global::WindowsFormsApp4.Properties.Resources.pcicon3;
            this.pc3.Location = new System.Drawing.Point(554, 12);
            this.pc3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pc3.Name = "pc3";
            this.pc3.Size = new System.Drawing.Size(125, 125);
            this.pc3.TabIndex = 41;
            this.pc3.TabStop = false;
            this.pc3.Click += new System.EventHandler(this.pc_3_click);
            // 
            // pc6
            // 
            this.pc6.BackColor = System.Drawing.Color.Transparent;
            this.pc6.Image = global::WindowsFormsApp4.Properties.Resources.pcicon3;
            this.pc6.Location = new System.Drawing.Point(554, 145);
            this.pc6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pc6.Name = "pc6";
            this.pc6.Size = new System.Drawing.Size(125, 125);
            this.pc6.TabIndex = 47;
            this.pc6.TabStop = false;
            this.pc6.Click += new System.EventHandler(this.pc_6_click);
            // 
            // pc5
            // 
            this.pc5.BackColor = System.Drawing.Color.Transparent;
            this.pc5.Image = global::WindowsFormsApp4.Properties.Resources.pcicon3;
            this.pc5.Location = new System.Drawing.Point(423, 145);
            this.pc5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pc5.Name = "pc5";
            this.pc5.Size = new System.Drawing.Size(125, 125);
            this.pc5.TabIndex = 45;
            this.pc5.TabStop = false;
            this.pc5.Click += new System.EventHandler(this.pc_5_click);
            // 
            // pc4
            // 
            this.pc4.BackColor = System.Drawing.Color.Transparent;
            this.pc4.Image = global::WindowsFormsApp4.Properties.Resources.pcicon3;
            this.pc4.Location = new System.Drawing.Point(292, 145);
            this.pc4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pc4.Name = "pc4";
            this.pc4.Size = new System.Drawing.Size(125, 125);
            this.pc4.TabIndex = 43;
            this.pc4.TabStop = false;
            this.pc4.Click += new System.EventHandler(this.pc_4_click);
            // 
            // pc9
            // 
            this.pc9.BackColor = System.Drawing.Color.Transparent;
            this.pc9.Image = global::WindowsFormsApp4.Properties.Resources.pcicon3;
            this.pc9.Location = new System.Drawing.Point(554, 278);
            this.pc9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pc9.Name = "pc9";
            this.pc9.Size = new System.Drawing.Size(125, 125);
            this.pc9.TabIndex = 53;
            this.pc9.TabStop = false;
            this.pc9.Click += new System.EventHandler(this.pc_9_click);
            // 
            // pc8
            // 
            this.pc8.BackColor = System.Drawing.Color.Transparent;
            this.pc8.Image = global::WindowsFormsApp4.Properties.Resources.pcicon3;
            this.pc8.Location = new System.Drawing.Point(423, 278);
            this.pc8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pc8.Name = "pc8";
            this.pc8.Size = new System.Drawing.Size(125, 125);
            this.pc8.TabIndex = 51;
            this.pc8.TabStop = false;
            this.pc8.Click += new System.EventHandler(this.pc_8_click);
            // 
            // pc7
            // 
            this.pc7.BackColor = System.Drawing.Color.Transparent;
            this.pc7.Image = global::WindowsFormsApp4.Properties.Resources.pcicon3;
            this.pc7.Location = new System.Drawing.Point(292, 278);
            this.pc7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pc7.Name = "pc7";
            this.pc7.Size = new System.Drawing.Size(125, 125);
            this.pc7.TabIndex = 49;
            this.pc7.TabStop = false;
            this.pc7.Click += new System.EventHandler(this.pc_7_click);
            // 
            // pc_secili
            // 
            this.pc_secili.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pc_secili.Location = new System.Drawing.Point(286, 4);
            this.pc_secili.Name = "pc_secili";
            this.pc_secili.Size = new System.Drawing.Size(137, 141);
            this.pc_secili.TabIndex = 55;
            this.pc_secili.TabStop = false;
            this.pc_secili.Visible = false;
            // 
            // pc1
            // 
            this.pc1.BackColor = System.Drawing.Color.Transparent;
            this.pc1.Image = global::WindowsFormsApp4.Properties.Resources.pcicon3;
            this.pc1.Location = new System.Drawing.Point(292, 12);
            this.pc1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pc1.Name = "pc1";
            this.pc1.Size = new System.Drawing.Size(125, 125);
            this.pc1.TabIndex = 13;
            this.pc1.TabStop = false;
            this.pc1.Click += new System.EventHandler(this.pc_1_click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 391);
            this.panel1.TabIndex = 56;
            this.panel1.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 60;
            this.label9.Text = "Açık kaldığı süre";
            this.label9.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 59;
            this.label2.Text = "==> 0";
            this.label2.Visible = false;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(21, 338);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(182, 44);
            this.button11.TabIndex = 16;
            this.button11.Text = "Masayı Kapat";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Visible = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "==> 0 dakika";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Masanın kalan süresi";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "==> 0 TL";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Masanın toplam borcu";
            this.label5.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 250);
            this.panel2.TabIndex = 17;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(27, 194);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(182, 44);
            this.button10.TabIndex = 23;
            this.button10.Text = "Süresiz Aç";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(121, 148);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 40);
            this.button5.TabIndex = 22;
            this.button5.Text = "90";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(121, 102);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 40);
            this.button6.TabIndex = 21;
            this.button6.Text = "60";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(121, 56);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(88, 40);
            this.button8.TabIndex = 20;
            this.button8.Text = "30";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(27, 148);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(88, 40);
            this.button9.TabIndex = 19;
            this.button9.Text = "75";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(27, 102);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 40);
            this.button7.TabIndex = 18;
            this.button7.Text = "45";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.label4.Location = new System.Drawing.Point(23, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Kaç dakikalık açılacağını seçin";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "15";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kontrol
            // 
            this.kontrol.Enabled = true;
            this.kontrol.Interval = 1;
            this.kontrol.Tick += new System.EventHandler(this.kontrol_Tick);
            // 
            // button12
            // 
            this.button12.AutoSize = true;
            this.button12.Location = new System.Drawing.Point(14, 323);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(253, 40);
            this.button12.TabIndex = 58;
            this.button12.Text = "PROGRAMI KAPAT";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // kalan_sure
            // 
            this.kalan_sure.Tick += new System.EventHandler(this.kalan_sure_Tick);
            // 
            // acik_kaldigi_sure
            // 
            this.acik_kaldigi_sure.Tick += new System.EventHandler(this.acik_kaldigi_sure_Tick);
            // 
            // pc2
            // 
            this.pc2.BackColor = System.Drawing.Color.Transparent;
            this.pc2.Image = global::WindowsFormsApp4.Properties.Resources.pcicon3;
            this.pc2.Location = new System.Drawing.Point(423, 12);
            this.pc2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pc2.Name = "pc2";
            this.pc2.Size = new System.Drawing.Size(125, 125);
            this.pc2.TabIndex = 59;
            this.pc2.TabStop = false;
            this.pc2.Click += new System.EventHandler(this.pc_2_click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(693, 417);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pc2);
            this.Controls.Add(this.pc9);
            this.Controls.Add(this.pc8);
            this.Controls.Add(this.pc7);
            this.Controls.Add(this.pc6);
            this.Controls.Add(this.pc5);
            this.Controls.Add(this.pc4);
            this.Controls.Add(this.pc3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pc1);
            this.Controls.Add(this.pc_secili);
            this.Controls.Add(this.button12);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "ARAYÜZ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Click += new System.EventHandler(this.Form2_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pc3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_secili)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer tarih;
        private System.Windows.Forms.PictureBox pc3;
        private System.Windows.Forms.PictureBox pc6;
        private System.Windows.Forms.PictureBox pc5;
        private System.Windows.Forms.PictureBox pc4;
        private System.Windows.Forms.PictureBox pc9;
        private System.Windows.Forms.PictureBox pc8;
        private System.Windows.Forms.PictureBox pc7;
        private System.Windows.Forms.PictureBox pc_secili;
        private System.Windows.Forms.PictureBox pc1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Timer kontrol;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer kalan_sure;
        private System.Windows.Forms.Timer acik_kaldigi_sure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pc2;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}