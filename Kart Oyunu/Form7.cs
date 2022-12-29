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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        bool sure = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(!sure) 
            {
                this.Opacity += 0.005;
            }
            if(this.Opacity==1)
            {
                sure= true;
            }
            if(sure)
            {
                this.Opacity -= 0.005;
                if(this.Opacity==0) 
                {
                    Form1 frm1=new Form1();
                    frm1.Show();
                    this.Hide();
                    timer1.Enabled = false;
                    
                }
            }
        }
    }
}