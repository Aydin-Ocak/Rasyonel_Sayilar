using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rasyonel_Sayılar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string sonuc;

        private void Sonuc()
        {
            int pay = Convert.ToInt32(textBox1.Text);
            int payda = Convert.ToInt32(textBox2.Text);
            

            if(pay < payda && textBox3.Text == "")
            {
                sonuc = "Basit Kesir";
            }
            else if(pay >= payda && textBox3.Text == "")
            {
                sonuc = "Bileşik Kesir";
            }
            else
            {
                if(pay < payda && textBox3.Text != "")
                {
                    sonuc = "Tam Sayılı Kesir";
                }
                else if(pay >= payda && textBox3.Text != "")
                {
                    sonuc = "Hatalı Kesir";
                }else
                {
                    MessageBox.Show("Ekran Boş");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sonuc();
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int pay = Convert.ToInt32(textBox1.Text);
                int payda = Convert.ToInt32(textBox2.Text);

                if (pay < payda && textBox3.Text == "")
                {
                    label3.Text = "Basit Kesir";
                }
                else if (pay >= payda && textBox3.Text == "")
                {
                    label3.Text = "Bileşik Kesir";
                }
                else
                {
                    if (pay < payda && textBox3.Text != "")
                    {
                        sonuc = "Tam Sayılı Kesir";
                    }
                    else if (pay >= payda && textBox3.Text != "")
                    {
                        sonuc = "Hatalı Kesir";
                    }
                    else
                    {
                        MessageBox.Show("Ekran Boş");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bir Tamsayı Değer Giriniz");
            }
            label3.Text = sonuc;
        }

        private void TestOlustur()
        {
            Random rndPay = new Random();
            Random rndPayda = new Random(Guid.NewGuid().GetHashCode());
            Random rndTam = new Random(Guid.NewGuid().GetHashCode());
            Random rndTur = new Random(Guid.NewGuid().GetHashCode());

            textBox1.Text = rndPay.Next(1, 100).ToString();
            textBox2.Text = rndPayda.Next(1, 100).ToString();

            if (rndTur.Next(0, 2) == 1)
            {
                textBox3.Text = rndTam.Next(1, 10).ToString();
            }
            else
            {
                textBox3.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestOlustur();
            Sonuc();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sonuc();

            if(sonuc == "Basit Kesir")
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;

                listBox1.Items.Add("D");
            }
            else
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;

                listBox1.Items.Add("Y");
            }
            TestOlustur();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sonuc();

            if (sonuc == "Bileşik Kesir")
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;

                listBox1.Items.Add("D");
            }
            else
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;

                listBox1.Items.Add("Y");
            }
            TestOlustur();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sonuc();

            if (sonuc == "Tam Sayılı Kesir")
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;

                listBox1.Items.Add("D");
            }
            else
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;

                listBox1.Items.Add("Y");
            }
            TestOlustur();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sonuc();

            if (sonuc == "Hatalı Kesir")
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;

                listBox1.Items.Add("D");
            }
            else
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;

                listBox1.Items.Add("Y");
            }
            TestOlustur();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(textBox6.Text != "" && textBox5.Text != "" && textBox4.Text != "")
            {
                int pay = Convert.ToInt32(textBox6.Text);
                int payda = Convert.ToInt32(textBox5.Text);
                int tam = Convert.ToInt32(textBox4.Text);

                textBox9.Text = ((tam * payda) + pay).ToString();
                textBox8.Text = payda.ToString();
            }
            else
            {
                MessageBox.Show("Değer Giriniz");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int pay = Convert.ToInt32(textBox13.Text);
            int payda = Convert.ToInt32(textBox12.Text);

            textBox11.Text = (pay / payda).ToString();
            textBox10.Text = (pay % payda).ToString();
            textBox7.Text = payda.ToString();
        }
    }
}
