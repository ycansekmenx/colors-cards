using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Kart_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Controls.Add(pictureBox4);
            pictureBox1.Controls.Add(pictureBox2);
            pictureBox1.Controls.Add(pictureBox3);
            pictureBox1.Controls.Add(pictureBox5);
            pictureBox1.Controls.Add(play);
            pictureBox1.Controls.Add(stop);

            pictureBox4.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            play.BackColor = Color.Transparent;
            stop.BackColor = Color.Transparent;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\gamemusic.wav";
            sp.PlayLooping();

        }





        private void pictureBox4_Click(object sender, EventArgs e)
        {

           


        }

        private void stop_Click(object sender, EventArgs e)
        {

            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void play_Click(object sender, EventArgs e)
        {

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void play_Click_1(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\gamemusic.wav";
            sp.Stop();



            stop.Visible = true;
            play.Visible = false;
        }

        private void stop_Click_1(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\gamemusic.wav";
            sp.PlayLooping();


            stop.Visible = false;
            play.Visible = true;
        }

        private void pictureBox4_Click_2(object sender, EventArgs e)
        {
            DialogResult secme = new DialogResult();
            secme = MessageBox.Show("Oyunu kapatmak istiyor musunuz ?", "Çıkış Sekmesi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secme == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.ShowDialog();
            this.Hide();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
            this.Close();
        }
    }
}
