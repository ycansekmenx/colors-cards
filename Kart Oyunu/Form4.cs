using kart_karma;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            pictureBox3.Controls.Add(pictureBox1);
            pictureBox3.Controls.Add(pictureBox2);
            pictureBox3.Controls.Add(label1);
            pictureBox3.Controls.Add(label2);
            pictureBox3.Controls.Add(label3);
            
            

            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor= Color.Transparent;   
            
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
      
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value<100)
            {
                progressBar1.Value += 2;
                label3.Text = progressBar1.Value.ToString()+" % ";
            }
            else
            {
                timer1.Stop();
                Kart frm2 = new Kart();
                frm2.ShowDialog();
            }
            if(progressBar1.Value==100)
            {
                this.Close();
            }   
            
           
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult secme = new DialogResult();
            secme = MessageBox.Show("Yükleme daha bitmedi. Anasayfaya dönmek istiyor musunuz?", "Anasayfa Sekmesi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secme == DialogResult.Yes)
            {
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           

        }
    }
}
