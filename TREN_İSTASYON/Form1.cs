using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TREN_İSTASYON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi, bilet, sefer = 1;
        int x, y, z, w, a, s;
        Random x1 = new Random();
        Random y1 = new Random();
        Random z1 = new Random();
        Random w1 = new Random();
        Random a1 = new Random();
        Random s1 = new Random();
        Random tren = new Random();
        Random tren2 = new Random();

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            timerYolcu.Start();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            sayi += x;
            lblsayi.Text ="TOPLAM YOLCU SAYISI: " + sayi;
            bilet += x * 20;
            lblHasılat.Text ="HASILAT: " +  bilet + "TL";
        }

       
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            sayi += z;
            lblsayi.Text = "TOPLAM YOLCU SAYISI: " + sayi;
            bilet += z * 15;
            lblHasılat.Text = "HASILAT: " + bilet + "TL";
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            sayi += y;
            lblsayi.Text = "TOPLAM YOLCU SAYISI: " + sayi;
            bilet += y * 18;
            lblHasılat.Text = "HASILAT: " + bilet + "TL";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            sayi += w;
            lblsayi.Text = "TOPLAM YOLCU SAYISI: " + sayi;
            bilet += w * 14;
            lblHasılat.Text = "HASILAT: " + bilet + "TL";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            sayi += a;
            lblsayi.Text = "TOPLAM YOLCU SAYISI: " + sayi;
            bilet += a * 10;
            lblHasılat.Text = "HASILAT: " + bilet + "TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TİRE = 20TL" + "\n" + "ÇATAL = 18TL"
                + "\n" + "BAYINDIR = 15TL" + "\n" + "ARIKBAŞI = 14TL" + "\n" + "TORBALI = 10TL" + "\n" + "GAZİEMİR = 6TL");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(5, 154);
            pictureTren2.Location = new Point(979, 310);
            lbldurak1.Enabled = true;
            lbldurak2.Enabled = true;
            lbldurak3.Enabled = true;
            lblDurak4.Enabled = true;
            lbldurak5.Enabled = true;
            lbldurak6.Enabled = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;
            checkBox6.Enabled = true;
            timer1.Start();
            x = x1.Next(5, 16);
            lbldurak1.Text = "YOLCU SAYISI: " + x.ToString();
            y = y1.Next(0, 10);
            lbldurak2.Text = "YOLCU SAYISI: " + y.ToString();
            z = z1.Next(3, 18);
            lbldurak3.Text = "YOLCU SAYISI: " + z.ToString();
            w = w1.Next(15, 21);
            lblDurak4.Text = "YOLCU SAYISI: " + w.ToString();
            a = a1.Next(2, 13);
            lbldurak5.Text = "YOLCU SAYISI: " + a.ToString();
            s = s1.Next(4, 8);
            lbldurak6.Text = "YOLCU SAYISI: " + s.ToString();
            sefer++;
            lblsefer.Text = "SEFER SAYISI: " + sefer;
            button3.Enabled = false;
            
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            sayi += s;
            lblsayi.Text = "TOPLAM YOLCU SAYISI: " + sayi;
            bilet += s * 6;
            lblHasılat.Text = "HASILAT: " + bilet + "TL";
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            pictureTren2.Left -= tren2.Next(8, 9);

            if(pictureTren2.Left <= pictureBox5.Right && w > 0)
            {
                button1.Enabled = true;
                timer2.Stop();
            }

            if(pictureTren2.Left <= pictureBox6.Right && a > 0)
            {
                button1.Enabled = true;
                timer2.Stop();
            }

            if(pictureTren2.Left <= pictureBox7.Right && s > 0)
            {
                button1.Enabled = true;
                timer2.Stop();
            }

            if(pictureTren2.Left <= pictureBox8.Left)
            {
                timer2.Stop();
                MessageBox.Show("SON DURAĞA GELDİK! HASILATI VE TAŞINAN YOLCU SAYISINI SOL ÜST KÖŞEDEN KONTROL EDEBİLİRSİN!");
                button3.Enabled = true;
            }
        }

        private void timerYolcu_Tick(object sender, EventArgs e)
        {
            
            if (pictureBox1.Left >= pictureBox2.Left)
            {
                checkBox1.Checked = true;
                x--;              
               int yolcusayacx = x;
                lbldurak1.Text = "YOLCU SAYISI: " + x;
               
                if (yolcusayacx == 0)
                {
                    timerYolcu.Stop();
                    MessageBox.Show("YOLCULAR ALINDI! TREN KALKIYOR.");                    
                    button1.Enabled = false;
                    timer1.Start();                    
                    lbldurak1.Enabled = false;
                    checkBox1.Enabled = false;
                    
                }
            }

          if(pictureBox1.Left >= pictureBox3.Left)
            {
                checkBox2.Checked = true;      
                x = 0;
                lbldurak1.Text ="YOLCU SAYISI: " + x.ToString();
                y--;
                int yolcusayacy = y;
                lbldurak2.Text = "YOLCU SAYISI: " + y.ToString();
                if(yolcusayacy == 0)
                {
                    timerYolcu.Stop();
                    MessageBox.Show("YOLCULAR ALINDI! TREN KALKIYOR.");
                    button1.Enabled = false;
                    timer1.Start();
                    lbldurak2.Enabled = false;
                    checkBox2.Enabled = false;
                }
            }

          if(pictureBox1.Left >= pictureBox4.Left)
            {
                checkBox3.Checked = true;
                x = 0;
                lbldurak1.Text = "YOLCU SAYISI: " + x.ToString();
                y = 0;
                lbldurak2.Text = "YOLCU SAYISI: " + y.ToString();

                z--;
                int yolcusayacz = z;              
                lbldurak3.Text = "YOLCU SAYISI: " + z.ToString();
                
                if(yolcusayacz == 0)
                {
                    timerYolcu.Stop();
                    MessageBox.Show("YOLCULAR ALINDI! TREN KALKIYOR");
                    button1.Enabled = false;
                    timer1.Start();
                    lbldurak3.Enabled = false;
                    checkBox3.Enabled = false;
                }
            }

          if(pictureTren2.Left <= pictureBox5.Right)
            {
                checkBox4.Checked = true;
                x = 0;
                lbldurak1.Text = "YOLCU SAYISI: " + x;
                y = 0;
                lbldurak2.Text = "YOLCU SAYISI: " + y;
                z = 0;
                lbldurak3.Text = "YOLCU SAYISI: " + z;

                w--;
                int yolcusayacw = w;
                lblDurak4.Text = "YOLCU SAYISI: " + w;
                {
                    if (yolcusayacw == 0)
                    {
                        timerYolcu.Stop();
                        MessageBox.Show("YOLCULAR ALINDI! TREN KALKIYOR.");
                        button1.Enabled = false;
                        timer2.Start();
                        lblDurak4.Enabled = false;
                        checkBox4.Enabled = false;
                    }
                }

            }

          if(pictureTren2.Left <= pictureBox6.Right)
            {
                checkBox5.Checked = true;
                x = 0;
                lbldurak1.Text = "YOLCU SAYISI: " + x;
                y = 0;
                lbldurak2.Text = "YOLCU SAYISI: " + y;
                z = 0;
                lbldurak3.Text = "YOLCU SAYISI: " + z;
                w = 0;
                lblDurak4.Text = "YOLCU SAYISI: " + w;

                a--;
                int yolcusayaca = a;
                lbldurak5.Text = "YOLCU SAYISI: " + a;
                if (yolcusayaca == 0)
                {
                    timerYolcu.Stop();
                    MessageBox.Show("YOLCULAR ALINDI! TREN KALKIYOR");
                    button1.Enabled = false;
                    timer2.Start();
                    lbldurak5.Enabled = false;
                    checkBox5.Enabled = false;
                }
            }

          if(pictureTren2.Left <= pictureBox7.Right)
            {
                checkBox6.Checked = true;
                x = 0;
                lbldurak1.Text = "YOLCU SAYISI: " + x;
                y = 0;
                lbldurak2.Text = "YOLCU SAYISI: " + y;
                z = 0;
                lbldurak3.Text = "YOLCU SAYISI: " + z;
                w = 0;
                lblDurak4.Text = "YOLCU SAYISI: " + w;
                a = 0;
                lbldurak5.Text = "YOLCU SAYISI: " + a;

                s--;
                int sayacs = s;
                lbldurak6.Text = "YOLCU SAYISI: " + s;
                
                if(sayacs == 0)
                {
                    timerYolcu.Stop();
                    button1.Enabled = false;
                    MessageBox.Show("YOLCULAR ALINDI! TREN KALKIYOR.");
                    timer2.Start();
                    lbldurak6.Enabled = false;
                    checkBox6.Enabled = false;
                }
            }

        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            timerYolcu.Stop();
        }

       
      

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            x = x1.Next(5, 16);
            lbldurak1.Text = "YOLCU SAYISI: " +x.ToString();
            y = y1.Next(0,10);
            lbldurak2.Text = "YOLCU SAYISI: " + y.ToString();
            z = z1.Next(3, 18);
            lbldurak3.Text = "YOLCU SAYISI: " + z.ToString();
            w = w1.Next(15, 21);
            lblDurak4.Text = "YOLCU SAYISI: " + w.ToString();
            a = a1.Next(5, 13);
            lbldurak5.Text = "YOLCU SAYISI: " + a.ToString();
            s = s1.Next(4, 8);
            lbldurak6.Text = "YOLCU SAYISI: " + s.ToString();           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            pictureBox1.Left += tren.Next(8, 9);

            if(pictureBox1.Left >= pictureBox2.Left && x > 0)
            {
                timer1.Stop();
                button1.Enabled = true;
            }

            if(pictureBox1.Left >= pictureBox3.Left && y > 0)
            {
                timer1.Stop();
                button1.Enabled = true;
            }
            else if(pictureBox1.Left >= pictureBox3.Left && y == 0)
            {
                lbldurak2.Enabled = false;
                checkBox2.Checked = true;
                checkBox2.Enabled = false;
            }

           if (pictureBox1.Left >= pictureBox4.Left && z > 0)
            {
                timer1.Stop();
                button1.Enabled = true;
            }

           if (pictureBox1.Left >= label2.Left)
            {
                timer1.Stop();
                timer2.Start();
            }
        }
    }
}
