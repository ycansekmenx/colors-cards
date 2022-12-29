using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kart_Oyunu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            pictureBox15.Controls.Add(pictureBox1);
            pictureBox15.Controls.Add(pictureBox2);
            pictureBox15.Controls.Add(pictureBox3);
            pictureBox15.Controls.Add(pictureBox4);
            pictureBox15.Controls.Add(pictureBox5);
            pictureBox15.Controls.Add(pictureBox6);
            pictureBox15.Controls.Add(pictureBox7);
            pictureBox15.Controls.Add(pictureBox8);
            pictureBox15.Controls.Add(pictureBox9);
            pictureBox15.Controls.Add(pictureBox10);
            pictureBox15.Controls.Add(pictureBox11);
            pictureBox15.Controls.Add(pictureBox12);
            pictureBox15.Controls.Add(pictureBox13);
            pictureBox15.Controls.Add(pictureBox14);
            pictureBox15.Controls.Add(label1);
            pictureBox15.Controls.Add(label2);
            pictureBox15.Controls.Add(label3);
            pictureBox15.Controls.Add(label4);
            pictureBox15.Controls.Add(label5);
            pictureBox15.Controls.Add(label6);
            pictureBox15.Controls.Add(label7);
            pictureBox15.Controls.Add(label8);
            pictureBox15.Controls.Add(label9);
            pictureBox15.Controls.Add(label10);
            pictureBox15.Controls.Add(label11);

            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor= Color.Transparent;
            pictureBox3.BackColor= Color.Transparent;
            pictureBox4.BackColor= Color.Transparent;
            pictureBox5.BackColor= Color.Transparent;
            pictureBox6.BackColor= Color.Transparent;
            pictureBox7.BackColor= Color.Transparent;
            pictureBox8.BackColor= Color.Transparent;
            pictureBox9.BackColor= Color.Transparent;
            pictureBox10.BackColor= Color.Transparent;
            pictureBox11.BackColor= Color.Transparent;
            pictureBox12.BackColor= Color.Transparent;
            pictureBox13.BackColor= Color.Transparent;
            pictureBox14.BackColor= Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;


            label1.Visible= true;
            label2.Visible= false;
            label3.Visible= false;
            label4.Visible= false;
            label5.Visible= false;
            label6.Visible= false;
            label7.Visible= false;
            label8.Visible= true;
            label9.Visible= false;
            label10.Visible= false;
            label11.Visible= false;
          
            pictureBox1.Visible= true;
            pictureBox3.Visible= true;
            pictureBox4.Visible= false;
            pictureBox5.Visible= false;
            pictureBox6.Visible= false;
            pictureBox7.Visible= false;
            pictureBox8.Visible= false;
            pictureBox9.Visible= false;
            pictureBox10.Visible= false;
            pictureBox11.Visible= false;
            pictureBox12.Visible= false;
            pictureBox13.Visible= false;
            pictureBox14.Visible= false;

            label1.Text= "Merhaba yeni oyuncu seni gördüğümüze çooook sevindik!!!";
            label8.Text = " Oyunun kurallarına birlikte bakalım mı ?";
            label2.Text = "Atılan kartın bir eksik veya bir fazlası olan karta tıklanarak";
            label9.Text = " oyun tahtasını temizlemesi hedeflenir. (+1 veya -1)";
            label3.Text = "Yukarıda uygun kart yoksa , havuzdan yeni kart seçilip atılır.";
            label4.Text = "Atılan kartlarda tekrar dönüş yoktur.";
            label5.Text = "Puanlama sistemi kart tıklamaya dayalıdır. ";
            label10.Text = "(Ne kadar karta tıklanırsa puanlama ona göre yapılır)";
            label6.Text = "Kartlar biterse oyuncu kazanmış sayılacaktır.";
            label7.Text = "İyi eğlencelerrr Umarım hem eğlenir hem de ";
            label11.Text = "yüksek bir puan alırsın BOL ŞANS!!!";
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            Form1 frm1 =new Form1();
            frm1.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label1.Visible= false;
            label8.Visible= false;
            pictureBox1.Visible = false;
            pictureBox3.Visible= false;

            pictureBox10.Visible = true;
            label2.Visible= true;
            label9.Visible= true;
            pictureBox4.Visible= true;
            
        }
      

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Visible = false;
            label2.Visible = false;
            label9.Visible = false;
            pictureBox4.Visible = false;

            pictureBox11.Visible= true;
            label3.Visible = true;
            pictureBox5.Visible = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Visible = false;
            label3.Visible = false;
            pictureBox5.Visible = false;

            pictureBox12.Visible = true;
            label4.Visible = true;
            pictureBox6.Visible = true;
            pictureBox12.Visible = true;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Visible = false;
            label4.Visible = false;
            pictureBox6.Visible = false;

            pictureBox13.Visible = true;
            label5.Visible = true;
            label10.Visible = true;
            pictureBox7.Visible = true;
            
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.Visible= false;
            label5.Visible = false;
            label10.Visible = false;
            pictureBox7.Visible = false;

            pictureBox14.Visible = true;
            label6.Visible = true;
            pictureBox8.Visible = true;
            
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
           
            label6.Visible = false;
            pictureBox8.Visible = false;

            label7.Visible = true;
            label11.Visible = true;
            pictureBox9.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }
    }
}
