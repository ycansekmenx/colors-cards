using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kart_Oyunu;
using System.Media;

namespace kart_karma
{
    public partial class Kart : Form
    {

        List<PictureBox> pictureBoxes = new List<PictureBox>()
        {

        };

        public Kart()
        {
            InitializeComponent();
            pictureBox58.Controls.Add(play);
            pictureBox58.Controls.Add(stop);
            pictureBox58.Controls.Add(pictureBox59);
           

            stop.BackColor = Color.Transparent;
            play.BackColor = Color.Transparent;
            pictureBox59.BackColor= Color.Transparent;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            karistir();
            sure.Start();
            sure.Interval = 1000;

        }

        int score = 0;
        int click_sayar = 0;
        int d = 0;
        int kalan = 19;

        #region desteden kart aldığımızda neler oluyor?
        private void pictureBox_deck_Click(object sender, EventArgs e)
        {
            kalan--;
            label42.Text = "Destede kalan:" + kalan;
            String secili_box = ((PictureBox)sender).Name;
            PictureBox AB = (PictureBox)this.Controls[secili_box];
            pictureBox40.Image=AB.Image;
            #region Deste click
            if (AB==pictureBox21)
            {
                label40.Text = label22.Text;
            }
            if (AB == pictureBox22)
            {
                label40.Text = label23.Text;
            }
            if (AB == pictureBox23)
            {
                label40.Text = label24.Text;
            }
            if (AB == pictureBox24)
            {
                label40.Text = label25.Text;
            }
            if (AB == pictureBox25)
            {
                label40.Text = label26.Text;
            }
            if (AB == pictureBox26)
            {
                label40.Text = label27.Text;
            }
            if (AB == pictureBox27)
            {
                label40.Text = label28.Text;
            }
            if (AB == pictureBox28)
            {
                label40.Text = label29.Text;
            }
            if (AB == pictureBox29)
            {
                label40.Text = label30.Text;
            }
            if (AB == pictureBox30)
            {
                label40.Text = label31.Text;
            }
            if (AB == pictureBox31)
            {
                label40.Text = label32.Text;
            }
            if (AB == pictureBox32)
            {
                label40.Text = label33.Text;
            }
            if (AB == pictureBox33)
            {
                label40.Text = label34.Text;
            }
            if (AB == pictureBox34)
            {
                label40.Text = label35.Text;
            }
            if (AB == pictureBox35)
            {
                label40.Text = label36.Text;
            }
            if (AB == pictureBox36)
            {
                label40.Text = label37.Text;
            }
            if (AB == pictureBox37)
            {
                label40.Text = label38.Text;
            }
            if (AB == pictureBox38)
            {
                label40.Text = label39.Text;
            }
            if (AB == pictureBox39)
            {
                label40.Text = label41.Text;
            }
            #endregion
            AB.Visible = false;
            if(click_sayar>d)
            {
                int temp = d;
                d = click_sayar;
                click_sayar = temp;
            }
        
           
            
            #region masada kalanları puandan çıkartıyoruz
            if (pictureBox21.Visible==false)
            {    pictureBox57.Visible = false;
              
                Bitirin.Visible = true;
               
                
            }
            a = 0;
            label1.Text = "SCORE: " + score;
            #endregion
        }
        #endregion
        int a = 0;
        void arttir()
        {
            a += 10;
            score = score + a;
            label1.Text = "SCORE: " + score;
        }
                 string kart_renk;
                 string kart_adi;

                public Kart( string b, string c)
                 {
                     this.kart_adi = b;
                     this.kart_renk = c;
                 }
        
                 #region karıştırma kodu
                
       public void karistir()
                 {
          //  string x = @Directory.GetCurrentDirectory() + "\\kartlar\\sari1.png";
                     Kart kart11 = new Kart( "mor1", @Directory.GetCurrentDirectory() + "\\kartlar\\1-mor.png");
                     Kart kart12 = new Kart( "sari1", @Directory.GetCurrentDirectory() + "\\kartlar\\1-turuncu.png");
                     Kart kart13 = new Kart( "yesil1", @Directory.GetCurrentDirectory() + "\\kartlar\\1-yesil.png");
                     Kart kart14 = new Kart( "mavi1", @Directory.GetCurrentDirectory() + "\\kartlar\\1-mavi.png");
                     Kart kart21 = new Kart( "mor2", @Directory.GetCurrentDirectory() + "\\kartlar\\2-mor.png");
                     Kart kart22 = new Kart("sari2", @Directory.GetCurrentDirectory() + "\\kartlar\\2-turuncu.png");
                     Kart kart23 = new Kart("yesil2", @Directory.GetCurrentDirectory() + "\\kartlar\\2-yesil.png");
                     Kart kart24 = new Kart( "mavi2", @Directory.GetCurrentDirectory() + "\\kartlar\\2-mavi.png");
                     Kart kart31 = new Kart( "mor3", @Directory.GetCurrentDirectory() + "\\kartlar\\3-mor.png");
                     Kart kart32 = new Kart( "sari3", @Directory.GetCurrentDirectory() + "\\kartlar\\3-turuncu.png");
                     Kart kart33 = new Kart( "yesil3", @Directory.GetCurrentDirectory() + "\\kartlar\\3-yesil.png");
                     Kart kart34 = new Kart( "mavi3", @Directory.GetCurrentDirectory() + "\\kartlar\\3-mavi.png");
                     Kart kart41 = new Kart( "mor4", @Directory.GetCurrentDirectory() + "\\kartlar\\4-mor.png");
                     Kart kart42 = new Kart( "sari4", @Directory.GetCurrentDirectory() + "\\kartlar\\4-turuncu.png");
                     Kart kart43 = new Kart( "yesil4", @Directory.GetCurrentDirectory() + "\\kartlar\\4-yesil.png");
                     Kart kart44 = new Kart( "mavi4", @Directory.GetCurrentDirectory() + "\\kartlar\\4-mavi.png");
                     Kart kart51 = new Kart( "mor5", @Directory.GetCurrentDirectory() + "\\kartlar\\5-mor.png");
                     Kart kart52 = new Kart( "sari5", @Directory.GetCurrentDirectory() + "\\kartlar\\5-turuncu.png");
                     Kart kart53 = new Kart( "yesil5", @Directory.GetCurrentDirectory() + "\\kartlar\\5-yesil.png");
                     Kart kart54 = new Kart( "mavi5", @Directory.GetCurrentDirectory() + "\\kartlar\\5-mavi.png");
                     Kart kart61 = new Kart( "mor6", @Directory.GetCurrentDirectory() + "\\kartlar\\6-mor.png");
                     Kart kart62 = new Kart( "sari6", @Directory.GetCurrentDirectory() + "\\kartlar\\6-turuncu.png");
                     Kart kart63 = new Kart( "yesil6", @Directory.GetCurrentDirectory() + "\\kartlar\\6-yesil.png");
                     Kart kart64 = new Kart( "mavi6", @Directory.GetCurrentDirectory() + "\\kartlar\\6-mavi.png");
                     Kart kart71 = new Kart( "mor7", @Directory.GetCurrentDirectory() + "\\kartlar\\7-mor.png");
                     Kart kart72 = new Kart( "sari7", @Directory.GetCurrentDirectory() + "\\kartlar\\7-turuncu.png");
                     Kart kart73 = new Kart( "yesil7", @Directory.GetCurrentDirectory() + "\\kartlar\\7-yesil.png");
                     Kart kart74 = new Kart( "mavi7", @Directory.GetCurrentDirectory() + "\\kartlar\\7-mavi.png");
                     Kart kart81 = new Kart( "mor8", @Directory.GetCurrentDirectory() + "\\kartlar\\8-mor.png");
                     Kart kart82 = new Kart( "sari8", @Directory.GetCurrentDirectory() + "\\kartlar\\8-turuncu.png");
                     Kart kart83 = new Kart( "yesil8", @Directory.GetCurrentDirectory() + "\\kartlar\\8-yesil.png");
                     Kart kart84 = new Kart( "mavi8", @Directory.GetCurrentDirectory() + "\\kartlar\\8-mavi.png");
                     Kart kart91 = new Kart( "mor9", @Directory.GetCurrentDirectory() + "\\kartlar\\9-mor.png");
                     Kart kart92 = new Kart( "sari9", @Directory.GetCurrentDirectory() + "\\kartlar\\9-turuncu.png");
                     Kart kart93 = new Kart( "yesil9", @Directory.GetCurrentDirectory() + "\\kartlar\\9-yesil.png");
                     Kart kart94 = new Kart( "mavi9", @Directory.GetCurrentDirectory() + "\\kartlar\\9-mavi.png");
                     Kart kart01 = new Kart( "mor10", @Directory.GetCurrentDirectory() + "\\kartlar\\10-mor.png");
                     Kart kart02 = new Kart( "sari10", @Directory.GetCurrentDirectory() + "\\kartlar\\10-turuncu.png");
                     Kart kart03 = new Kart( "yesi10", @Directory.GetCurrentDirectory() + "\\kartlar\\10-yesil.png");
                     Kart kart04 = new Kart( "mavi10", @Directory.GetCurrentDirectory() + "\\kartlar\\10-mavi.png");

       Kart[] karistirin = new Kart[] { kart11, kart12, kart13, kart14, kart21, kart22, kart23, kart24, kart31, kart32, kart33, kart34, kart41, kart42, kart43, kart44, kart51, kart52, kart53, kart54, kart61, kart62, kart63, kart64, kart71, kart72, kart73, kart74, kart81, kart82, kart83, kart84, kart91, kart92, kart93, kart94, kart01, kart02, kart03, kart04 };
           yer_degis(karistirin);

            #region label2
            if (karistirin[0] == kart11 || karistirin[0] == kart12 || karistirin[0] == kart13 || karistirin[0] == kart14)
            {
                label2.Text = "1";
            }
            if (karistirin[0] == kart21 || karistirin[0] == kart22 || karistirin[0] == kart23 || karistirin[0] == kart24)
            {
                label2.Text = "2";
            }
            if (karistirin[0] == kart31 || karistirin[0] == kart32 || karistirin[0] == kart33 || karistirin[0] == kart34)
            {
                label2.Text = "3";
            }
            if (karistirin[0] == kart41 || karistirin[0] == kart42 || karistirin[0] == kart43 || karistirin[0] == kart44)
            {
                label2.Text = "4";
            }
            if (karistirin[0] == kart51 || karistirin[0] == kart52 || karistirin[0] == kart53 || karistirin[0] == kart54)
            {
                label2.Text = "5";
            }
            if (karistirin[0] == kart61 || karistirin[0] == kart62 || karistirin[0] == kart63 || karistirin[0] == kart64)
            {
                label2.Text = "6";
            }
            if (karistirin[0] == kart71 || karistirin[0] == kart72 || karistirin[0] == kart73 || karistirin[0] == kart74)
            {
                label2.Text = "7";
            }
            if (karistirin[0] == kart81 || karistirin[0] == kart82 || karistirin[0] == kart83 || karistirin[0] == kart84)
            {
                label2.Text = "8";
            }
            if (karistirin[0] == kart91 || karistirin[0] == kart92 || karistirin[0] == kart93 || karistirin[0] == kart94)
            {
                label2.Text = "9";
            }
            if (karistirin[0] == kart01 || karistirin[0] == kart02 || karistirin[0] == kart03 || karistirin[0] == kart04)
            {
                label2.Text = "10";
            }
            #endregion
            #region label3
            if (karistirin[1] == kart11 || karistirin[1] == kart12 || karistirin[1] == kart13 || karistirin[1] == kart14)
            {
                label3.Text = "1";
            }
            if (karistirin[1] == kart21 || karistirin[1] == kart22 || karistirin[1] == kart23 || karistirin[1] == kart24)
            {
                label3.Text = "2";
            }
            if (karistirin[1] == kart31 || karistirin[1] == kart32 || karistirin[1] == kart33 || karistirin[1] == kart34)
            {
                label3.Text = "3";
            }
            if (karistirin[1] == kart41 || karistirin[1] == kart42 || karistirin[1] == kart43 || karistirin[1] == kart44)
            {
                label3.Text = "4";
            }
            if (karistirin[1] == kart51 || karistirin[1] == kart52 || karistirin[1] == kart53 || karistirin[1] == kart54)
            {
                label3.Text = "5";
            }
            if (karistirin[1] == kart61 || karistirin[1] == kart62 || karistirin[1] == kart63 || karistirin[1] == kart64)
            {
                label3.Text = "6";
            }
            if (karistirin[1] == kart71 || karistirin[1] == kart72 || karistirin[1] == kart73 || karistirin[1] == kart74)
            {
                label3.Text = "7";
            }
            if (karistirin[1] == kart81 || karistirin[1] == kart82 || karistirin[1] == kart83 || karistirin[1] == kart84)
            {
                label3.Text = "8";
            }
            if (karistirin[1] == kart91 || karistirin[1] == kart92 || karistirin[1] == kart93 || karistirin[1] == kart94)
            {
                label3.Text = "9";
            }
            if (karistirin[1] == kart01 || karistirin[1] == kart02 || karistirin[1] == kart03 || karistirin[1] == kart04)
            {
                label3.Text = "10";
            }
            #endregion
            #region label4
            if (karistirin[2] == kart11 || karistirin[2] == kart12 || karistirin[2] == kart13 || karistirin[2] == kart14)
            {
                label4.Text = "1";
            }
            if (karistirin[2] == kart21 || karistirin[2] == kart22 || karistirin[2] == kart23 || karistirin[2] == kart24)
            {
                label4.Text = "2";
            }
            if (karistirin[2] == kart31 || karistirin[2] == kart32 || karistirin[2] == kart33 || karistirin[2] == kart34)
            {
                label4.Text = "3";
            }
            if (karistirin[2] == (kart41) || karistirin[2] == kart42 || karistirin[2] == kart43 || karistirin[2] == kart44)
            {
                label4.Text = "4";
            }
            if (karistirin[2] == kart51 || karistirin[2] == kart52 || karistirin[2] == kart53 || karistirin[2] == kart54)
            {
                label4.Text = "5";
            }
            if (karistirin[2] == kart61 || karistirin[2] == kart62 || karistirin[2] == kart63 || karistirin[2] == kart64)
            {
                label4.Text = "6";
            }
            if (karistirin[2] == kart71 || karistirin[2] == kart72 || karistirin[2] == kart73 || karistirin[2] == kart74)
            {
                label4.Text = "7";
            }
            if (karistirin[2] == kart81 || karistirin[2] == kart82 || karistirin[2] == kart83 || karistirin[2] == kart84)
            {
                label4.Text = "8";
            }
            if (karistirin[2] == kart91 || karistirin[2] == kart92 || karistirin[2] == kart93 || karistirin[2] == kart94)
            {
                label4.Text = "9";
            }
            if (karistirin[2] == kart01 || karistirin[2] == kart02 || karistirin[2] == kart03 || karistirin[2] == kart04)
            {
                label4.Text = "10";
            }
            #endregion
            #region label5
            if (karistirin[3] == kart11 || karistirin[3] == kart12 || karistirin[3] == kart13 || karistirin[3] == kart14)
            {
                label5.Text = "1";
            }
            if (karistirin[3] == kart21 || karistirin[3] == kart22 || karistirin[3] == kart23 || karistirin[3] == kart24)
            {
                label5.Text = "2";
            }
            if (karistirin[3] == kart31 || karistirin[3] == kart32 || karistirin[3] == kart33 || karistirin[3] == kart34)
            {
                label5.Text = "3";
            }
            if (karistirin[3] == (kart41) || karistirin[3] == kart42 || karistirin[3] == kart43 || karistirin[3] == kart44)
            {
                label5.Text = "4";
            }
            if (karistirin[3] == kart51 || karistirin[3] == kart52 || karistirin[3] == kart53 || karistirin[3] == kart54)
            {
                label5.Text = "5";
            }
            if (karistirin[2] == kart61 || karistirin[3] == kart62 || karistirin[3] == kart63 || karistirin[3] == kart64)
            {
                label5.Text = "6";
            }
            if (karistirin[2] == kart71 || karistirin[3] == kart72 || karistirin[3] == kart73 || karistirin[3] == kart74)
            {
                label5.Text = "7";
            }
            if (karistirin[2] == kart81 || karistirin[3] == kart82 || karistirin[3] == kart83 || karistirin[3] == kart84)
            {
                label5.Text = "8";
            }
            if (karistirin[2] == kart91 || karistirin[3] == kart92 || karistirin[3] == kart93 || karistirin[3] == kart94)
            {
                label5.Text = "9";
            }
            if (karistirin[2] == kart01 || karistirin[3] == kart02 || karistirin[3] == kart03 || karistirin[3] == kart04)
            {
                label5.Text = "10";
            }
            #endregion
            #region label6
            if (karistirin[4] == kart11 || karistirin[4] == kart12 || karistirin[4] == kart13 || karistirin[4] == kart14)
            {
                label6.Text = "1";
            }
            if (karistirin[4] == kart21 || karistirin[4] == kart22 || karistirin[4] == kart23 || karistirin[4] == kart24)
            {
                label6.Text = "2";
            }
            if (karistirin[4] == kart31 || karistirin[4] == kart32 || karistirin[4] == kart33 || karistirin[4] == kart34)
            {
                label6.Text = "3";
            }
            if (karistirin[4] == kart41 || karistirin[4] == kart42 || karistirin[4] == kart43 || karistirin[4] == kart44)
            {
                label6.Text = "4";
            }
            if (karistirin[4] == kart51 || karistirin[4] == kart52 || karistirin[4] == kart53 || karistirin[4] == kart54)
            {
                label6.Text = "5";
            }
            if (karistirin[4] == kart61 || karistirin[4] == kart62 || karistirin[4] == kart63 || karistirin[4] == kart64)
            {
                label6.Text = "6";
            }
            if (karistirin[4] == kart71 || karistirin[4] == kart72 || karistirin[4] == kart73 || karistirin[4] == kart74)
            {
                label6.Text = "7";
            }
            if (karistirin[4] == kart81 || karistirin[4] == kart82 || karistirin[4] == kart83 || karistirin[4] == kart84)
            {
                label6.Text = "8";
            }
            if (karistirin[4] == kart91 || karistirin[4] == kart92 || karistirin[4] == kart93 || karistirin[4] == kart94)
            {
                label6.Text = "9";
            }
            if (karistirin[4] == kart01 || karistirin[4] == kart02 || karistirin[4] == kart03 || karistirin[4] == kart04)
            {
                label6.Text = "10";
            }
            #endregion
            #region label7
            if (karistirin[5] == kart11 || karistirin[5] == kart12 || karistirin[5] == kart13 || karistirin[5] == kart14)
            {
                label7.Text = "1";
            }
            if (karistirin[5] == kart21 || karistirin[5] == kart22 || karistirin[5] == kart23 || karistirin[5] == kart24)
            {
                label7.Text = "2";
            }
            if (karistirin[5] == kart31 || karistirin[5] == kart32 || karistirin[5] == kart33 || karistirin[5] == kart34)
            {
                label7.Text = "3";
            }
            if (karistirin[5] == kart41 || karistirin[5] == kart42 || karistirin[5] == kart43 || karistirin[5] == kart44)
            {
                label7.Text = "4";
            }
            if (karistirin[5] == kart51 || karistirin[5] == kart52 || karistirin[5] == kart53 || karistirin[5] == kart54)
            {
                label7.Text = "5";
            }
            if (karistirin[5] == kart61 || karistirin[5] == kart62 || karistirin[5] == kart63 || karistirin[5] == kart64)
            {
                label7.Text = "6";
            }
            if (karistirin[5] == kart71 || karistirin[5] == kart72 || karistirin[5] == kart73 || karistirin[5] == kart74)
            {
                label7.Text = "7";
            }
            if (karistirin[5] == kart81 || karistirin[5] == kart82 || karistirin[5] == kart83 || karistirin[5] == kart84)
            {
                label7.Text = "8";
            }
            if (karistirin[5] == kart91 || karistirin[5] == kart92 || karistirin[5] == kart93 || karistirin[5] == kart94)
            {
                label7.Text = "9";
            }
            if (karistirin[5] == kart01 || karistirin[5] == kart02 || karistirin[5] == kart03 || karistirin[5] == kart04)
            {
                label7.Text = "10";
            }
            #endregion
            #region label8
            if (karistirin[6] == kart11 || karistirin[6] == kart12 || karistirin[6] == kart13 || karistirin[6] == kart14)
            {
                label8.Text = "1";
            }
            if (karistirin[6] == kart21 || karistirin[6] == kart22 || karistirin[6] == kart23 || karistirin[6] == kart24)
            {
                label8.Text = "2";
            }
            if (karistirin[6] == kart31 || karistirin[6] == kart32 || karistirin[6] == kart33 || karistirin[6] == kart34)
            {
                label8.Text = "3";
            }
            if (karistirin[6] == kart41 || karistirin[6] == kart42 || karistirin[6] == kart43 || karistirin[6] == kart44)
            {
                label8.Text = "4";
            }
            if (karistirin[6] == kart51 || karistirin[6] == kart52 || karistirin[6] == kart53 || karistirin[6] == kart54)
            {
                label8.Text = "5";
            }
            if (karistirin[6] == kart61 || karistirin[6] == kart62 || karistirin[6] == kart63 || karistirin[6] == kart64)
            {
                label8.Text = "6";
            }
            if (karistirin[6] == kart71 || karistirin[6] == kart72 || karistirin[6] == kart73 || karistirin[6] == kart74)
            {
                label8.Text = "7";
            }
            if (karistirin[6] == kart81 || karistirin[6] == kart82 || karistirin[6] == kart83 || karistirin[6] == kart84)
            {
                label8.Text = "8";
            }
            if (karistirin[6] == kart91 || karistirin[6] == kart92 || karistirin[6] == kart93 || karistirin[6] == kart94)
            {
                label8.Text = "9";
            }
            if (karistirin[6] == kart01 || karistirin[6] == kart02 || karistirin[6] == kart03 || karistirin[6] == kart04)
            {
                label8.Text = "10";
            }
            #endregion
            #region label9
            if (karistirin[7] == kart11 || karistirin[7] == kart12 || karistirin[7] == kart13 || karistirin[7] == kart14)
            {
                label9.Text = "1";
            }
            if (karistirin[7] == kart21 || karistirin[7] == kart22 || karistirin[7] == kart23 || karistirin[7] == kart24)
            {
                label9.Text = "2";
            }
            if (karistirin[7] == kart31 || karistirin[7] == kart32 || karistirin[7] == kart33 || karistirin[7] == kart34)
            {
                label9.Text = "3";
            }
            if (karistirin[7] == kart41 || karistirin[7] == kart42 || karistirin[7] == kart43 || karistirin[7] == kart44)
            {
                label9.Text = "4";
            }
            if (karistirin[7] == kart51 || karistirin[7] == kart52 || karistirin[7] == kart53 || karistirin[7] == kart54)
            {
                label9.Text = "5";
            }
            if (karistirin[7] == kart61 || karistirin[7] == kart62 || karistirin[7] == kart63 || karistirin[7] == kart64)
            {
                label9.Text = "6";
            }
            if (karistirin[7] == kart71 || karistirin[7] == kart72 || karistirin[7] == kart73 || karistirin[7] == kart74)
            {
                label9.Text = "7";
            }
            if (karistirin[7] == kart81 || karistirin[7] == kart82 || karistirin[7] == kart83 || karistirin[7] == kart84)
            {
                label9.Text = "8";
            }
            if (karistirin[7] == kart91 || karistirin[7] == kart92 || karistirin[7] == kart93 || karistirin[7] == kart94)
            {
                label9.Text = "9";
            }
            if (karistirin[7] == kart01 || karistirin[7] == kart02 || karistirin[7] == kart03 || karistirin[7] == kart04)
            {
                label9.Text = "10";
            }
            #endregion
            #region label10
            if (karistirin[8] == kart11 || karistirin[8] == kart12 || karistirin[8] == kart13 || karistirin[8] == kart14)
            {
                label10.Text = "1";
            }
            if (karistirin[8] == kart21 || karistirin[8] == kart22 || karistirin[8] == kart23 || karistirin[8] == kart24)
            {
                label10.Text = "2";
            }
            if (karistirin[8] == kart31 || karistirin[8] == kart32 || karistirin[8] == kart33 || karistirin[8] == kart34)
            {
                label10.Text = "3";
            }
            if (karistirin[8] == kart41 || karistirin[8] == kart42 || karistirin[8] == kart43 || karistirin[8] == kart44)
            {
                label10.Text = "4";
            }
            if (karistirin[8] == kart51 || karistirin[8] == kart52 || karistirin[8] == kart53 || karistirin[8] == kart54)
            {
                label10.Text = "5";
            }
            if (karistirin[8] == kart61 || karistirin[8] == kart62 || karistirin[8] == kart63 || karistirin[8] == kart64)
            {
                label10.Text = "6";
            }
            if (karistirin[8] == kart71 || karistirin[8] == kart72 || karistirin[8] == kart73 || karistirin[8] == kart74)
            {
                label10.Text = "7";
            }
            if (karistirin[8] == kart81 || karistirin[8] == kart82 || karistirin[8] == kart83 || karistirin[8] == kart84)
            {
                label10.Text = "8";
            }
            if (karistirin[8] == kart91 || karistirin[8] == kart92 || karistirin[8] == kart93 || karistirin[8] == kart94)
            {
                label10.Text = "9";
            }
            if (karistirin[8] == kart01 || karistirin[8] == kart02 || karistirin[8] == kart03 || karistirin[8] == kart04)
            {
                label10.Text = "10";
            }
            #endregion
            #region label11
            if (karistirin[9] == kart11 || karistirin[9] == kart12 || karistirin[9] == kart13 || karistirin[9] == kart14)
            {
                label11.Text = "1";
            }
            if (karistirin[9] == kart21 || karistirin[9] == kart22 || karistirin[9] == kart23 || karistirin[9] == kart24)
            {
                label11.Text = "2";
            }
            if (karistirin[9] == kart31 || karistirin[9] == kart32 || karistirin[9] == kart33 || karistirin[9] == kart34)
            {
                label11.Text = "3";
            }
            if (karistirin[9] == kart41 || karistirin[9] == kart42 || karistirin[9] == kart43 || karistirin[9] == kart44)
            {
                label11.Text = "4";
            }
            if (karistirin[9] == kart51 || karistirin[9] == kart52 || karistirin[9] == kart53 || karistirin[9] == kart54)
            {
                label11.Text = "5";
            }
            if (karistirin[9] == kart61 || karistirin[9] == kart62 || karistirin[9] == kart63 || karistirin[9] == kart64)
            {
                label11.Text = "6";
            }
            if (karistirin[9] == kart71 || karistirin[9] == kart72 || karistirin[9] == kart73 || karistirin[9] == kart74)
            {
                label11.Text = "7";
            }
            if (karistirin[9] == kart81 || karistirin[9] == kart82 || karistirin[9] == kart83 || karistirin[9] == kart84)
            {
                label11.Text = "8";
            }
            if (karistirin[9] == kart91 || karistirin[9] == kart92 || karistirin[9] == kart93 || karistirin[9] == kart94)
            {
                label11.Text = "9";
            }
            if (karistirin[9] == kart01 || karistirin[9] == kart02 || karistirin[9] == kart03 || karistirin[9] == kart04)
            {
                label11.Text = "10";
            }
            #endregion
            #region label12
            if (karistirin[10] == kart11 || karistirin[10] == kart12 || karistirin[10] == kart13 || karistirin[10] == kart14)
            {
                label12.Text = "1";
            }
            if (karistirin[10] == kart21 || karistirin[10] == kart22 || karistirin[10] == kart23 || karistirin[10] == kart24)
            {
                label12.Text = "2";
            }
            if (karistirin[10] == kart31 || karistirin[10] == kart32 || karistirin[10] == kart33 || karistirin[10] == kart34)
            {
                label12.Text = "3";
            }
            if (karistirin[10] == kart41 || karistirin[10] == kart42 || karistirin[10] == kart43 || karistirin[10] == kart44)
            {
                label12.Text = "4";
            }
            if (karistirin[10] == kart51 || karistirin[10] == kart52 || karistirin[10] == kart53 || karistirin[10] == kart54)
            {
                label12.Text = "5";
            }
            if (karistirin[10] == kart61 || karistirin[10] == kart62 || karistirin[10] == kart63 || karistirin[10] == kart64)
            {
                label12.Text = "6";
            }
            if (karistirin[10] == kart71 || karistirin[10] == kart72 || karistirin[10] == kart73 || karistirin[10] == kart74)
            {
                label12.Text = "7";
            }
            if (karistirin[10] == kart81 || karistirin[10] == kart82 || karistirin[10] == kart83 || karistirin[10] == kart84)
            {
                label12.Text = "8";
            }
            if (karistirin[10] == kart91 || karistirin[10] == kart92 || karistirin[10] == kart93 || karistirin[10] == kart94)
            {
                label12.Text = "9";
            }
            if (karistirin[10] == kart01 || karistirin[10] == kart02 || karistirin[10] == kart03 || karistirin[10] == kart04)
            {
                label12.Text = "10";
            }
            #endregion
            #region label13
            if (karistirin[11] == kart11 || karistirin[11] == kart12 || karistirin[11] == kart13 || karistirin[11] == kart14)
            {
                label13.Text = "1";
            }
            if (karistirin[11] == kart21 || karistirin[11] == kart22 || karistirin[11] == kart23 || karistirin[11] == kart24)
            {
                label13.Text = "2";
            }
            if (karistirin[11] == kart31 || karistirin[11] == kart32 || karistirin[11] == kart33 || karistirin[11] == kart34)
            {
                label13.Text = "3";
            }
            if (karistirin[11] == kart41 || karistirin[11] == kart42 || karistirin[11] == kart43 || karistirin[11] == kart44)
            {
                label13.Text = "4";
            }
            if (karistirin[11] == kart51 || karistirin[11] == kart52 || karistirin[11] == kart53 || karistirin[11] == kart54)
            {
                label13.Text = "5";
            }
            if (karistirin[11] == kart61 || karistirin[11] == kart62 || karistirin[11] == kart63 || karistirin[11] == kart64)
            {
                label13.Text = "6";
            }
            if (karistirin[11] == kart71 || karistirin[11] == kart72 || karistirin[11] == kart73 || karistirin[11] == kart74)
            {
                label13.Text = "7";
            }
            if (karistirin[11] == kart81 || karistirin[11] == kart82 || karistirin[11] == kart83 || karistirin[11] == kart84)
            {
                label13.Text = "8";
            }
            if (karistirin[11] == kart91 || karistirin[11] == kart92 || karistirin[11] == kart93 || karistirin[11] == kart94)
            {
                label13.Text = "9";
            }
            if (karistirin[11] == kart01 || karistirin[11] == kart02 || karistirin[11] == kart03 || karistirin[11] == kart04)
            {
                label13.Text = "10";
            }
            #endregion
            #region label14
            if (karistirin[12] == kart11 || karistirin[12] == kart12 || karistirin[12] == kart13 || karistirin[12] == kart14)
            {
                label14.Text = "1";
            }
            if (karistirin[12] == kart21 || karistirin[12] == kart22 || karistirin[12] == kart23 || karistirin[12] == kart24)
            {
                label14.Text = "2";
            }
            if (karistirin[12] == kart31 || karistirin[12] == kart32 || karistirin[12] == kart33 || karistirin[12] == kart34)
            {
                label14.Text = "3";
            }
            if (karistirin[12] == kart41 || karistirin[12] == kart42 || karistirin[12] == kart43 || karistirin[12] == kart44)
            {
                label14.Text = "4";
            }
            if (karistirin[12] == kart51 || karistirin[12] == kart52 || karistirin[12] == kart53 || karistirin[12] == kart54)
            {
                label14.Text = "5";
            }
            if (karistirin[12] == kart61 || karistirin[12] == kart62 || karistirin[12] == kart63 || karistirin[12] == kart64)
            {
                label14.Text = "6";
            }
            if (karistirin[12] == kart71 || karistirin[12] == kart72 || karistirin[12] == kart73 || karistirin[12] == kart74)
            {
                label14.Text = "7";
            }
            if (karistirin[12] == kart81 || karistirin[12] == kart82 || karistirin[12] == kart83 || karistirin[12] == kart84)
            {
                label14.Text = "8";
            }
            if (karistirin[12] == kart91 || karistirin[12] == kart92 || karistirin[12] == kart93 || karistirin[12] == kart94)
            {
                label14.Text = "9";
            }
            if (karistirin[12] == kart01 || karistirin[12] == kart02 || karistirin[12] == kart03 || karistirin[12] == kart04)
            {
                label14.Text = "10";
            }
            #endregion
            #region label15
            if (karistirin[13] == kart11 || karistirin[13] == kart12 || karistirin[13] == kart13 || karistirin[13] == kart14)
            {
                label15.Text = "1";
            }
            if (karistirin[13] == kart21 || karistirin[13] == kart22 || karistirin[13] == kart23 || karistirin[13] == kart24)
            {
                label15.Text = "2";
            }
            if (karistirin[13] == kart31 || karistirin[13] == kart32 || karistirin[13] == kart33 || karistirin[13] == kart34)
            {
                label15.Text = "3";
            }
            if (karistirin[13] == kart41 || karistirin[13] == kart42 || karistirin[13] == kart43 || karistirin[13] == kart44)
            {
                label15.Text = "4";
            }
            if (karistirin[13] == kart51 || karistirin[13] == kart52 || karistirin[13] == kart53 || karistirin[13] == kart54)
            {
                label15.Text = "5";
            }
            if (karistirin[13] == kart61 || karistirin[13] == kart62 || karistirin[13] == kart63 || karistirin[13] == kart64)
            {
                label15.Text = "6";
            }
            if (karistirin[13] == kart71 || karistirin[13] == kart72 || karistirin[13] == kart73 || karistirin[13] == kart74)
            {
                label15.Text = "7";
            }
            if (karistirin[13] == kart81 || karistirin[13] == kart82 || karistirin[13] == kart83 || karistirin[13] == kart84)
            {
                label15.Text = "8";
            }
            if (karistirin[13] == kart91 || karistirin[13] == kart92 || karistirin[13] == kart93 || karistirin[13] == kart94)
            {
                label15.Text = "9";
            }
            if (karistirin[13] == kart01 || karistirin[13] == kart02 || karistirin[13] == kart03 || karistirin[13] == kart04)
            {
                label15.Text = "10";
            }
            #endregion
            #region label16
            if (karistirin[14] == kart11 || karistirin[14] == kart12 || karistirin[14] == kart13 || karistirin[14] == kart14)
            {
                label16.Text = "1";
            }
            if (karistirin[14] == kart21 || karistirin[14] == kart22 || karistirin[14] == kart23 || karistirin[14] == kart24)
            {
                label16.Text = "2";
            }
            if (karistirin[14] == kart31 || karistirin[14] == kart32 || karistirin[14] == kart33 || karistirin[14] == kart34)
            {
                label16.Text = "3";
            }
            if (karistirin[14] == kart41 || karistirin[14] == kart42 || karistirin[14] == kart43 || karistirin[14] == kart44)
            {
                label16.Text = "4";
            }
            if (karistirin[14] == kart51 || karistirin[14] == kart52 || karistirin[14] == kart53 || karistirin[14] == kart54)
            {
                label16.Text = "5";
            }
            if (karistirin[14] == kart61 || karistirin[14] == kart62 || karistirin[14] == kart63 || karistirin[14] == kart64)
            {
                label16.Text = "6";
            }
            if (karistirin[14] == kart71 || karistirin[14] == kart72 || karistirin[14] == kart73 || karistirin[14] == kart74)
            {
                label16.Text = "7";
            }
            if (karistirin[14] == kart81 || karistirin[14] == kart82 || karistirin[14] == kart83 || karistirin[14] == kart84)
            {
                label16.Text = "8";
            }
            if (karistirin[14] == kart91 || karistirin[14] == kart92 || karistirin[14] == kart93 || karistirin[14] == kart94)
            {
                label16.Text = "9";
            }
            if (karistirin[14] == kart01 || karistirin[14] == kart02 || karistirin[14] == kart03 || karistirin[14] == kart04)
            {
                label16.Text = "10";
            }
            #endregion
            #region label17
            if (karistirin[15] == kart11 || karistirin[15] == kart12 || karistirin[15] == kart13 || karistirin[15] == kart14)
            {
                label17.Text = "1";
            }
            if (karistirin[15] == kart21 || karistirin[15] == kart22 || karistirin[15] == kart23 || karistirin[15] == kart24)
            {
                label17.Text = "2";
            }
            if (karistirin[15] == kart31 || karistirin[15] == kart32 || karistirin[15] == kart33 || karistirin[15] == kart34)
            {
                label17.Text = "3";
            }
            if (karistirin[15] == kart41 || karistirin[15] == kart42 || karistirin[15] == kart43 || karistirin[15] == kart44)
            {
                label17.Text = "4";
            }
            if (karistirin[15] == kart51 || karistirin[15] == kart52 || karistirin[15] == kart53 || karistirin[15] == kart54)
            {
                label17.Text = "5";
            }
            if (karistirin[15] == kart61 || karistirin[15] == kart62 || karistirin[15] == kart63 || karistirin[15] == kart64)
            {
                label17.Text = "6";
            }
            if (karistirin[15] == kart71 || karistirin[15] == kart72 || karistirin[15] == kart73 || karistirin[15] == kart74)
            {
                label17.Text = "7";
            }
            if (karistirin[15] == kart81 || karistirin[15] == kart82 || karistirin[15] == kart83 || karistirin[15] == kart84)
            {
                label17.Text = "8";
            }
            if (karistirin[15] == kart91 || karistirin[15] == kart92 || karistirin[15] == kart93 || karistirin[15] == kart94)
            {
                label17.Text = "9";
            }
            if (karistirin[15] == kart01 || karistirin[15] == kart02 || karistirin[15] == kart03 || karistirin[15] == kart04)
            {
                label17.Text = "10";
            }
            #endregion
            #region label18
            if (karistirin[16] == kart11 || karistirin[16] == kart12 || karistirin[16] == kart13 || karistirin[16] == kart14)
            {
                label18.Text = "1";
            }
            if (karistirin[16] == kart21 || karistirin[16] == kart22 || karistirin[16] == kart23 || karistirin[16] == kart24)
            {
                label18.Text = "2";
            }
            if (karistirin[16] == kart31 || karistirin[16] == kart32 || karistirin[16] == kart33 || karistirin[16] == kart34)
            {
                label18.Text = "3";
            }
            if (karistirin[16] == kart41 || karistirin[16] == kart42 || karistirin[16] == kart43 || karistirin[16] == kart44)
            {
                label18.Text = "4";
            }
            if (karistirin[16] == kart51 || karistirin[16] == kart52 || karistirin[16] == kart53 || karistirin[16] == kart54)
            {
                label18.Text = "5";
            }
            if (karistirin[16] == kart61 || karistirin[16] == kart62 || karistirin[16] == kart63 || karistirin[16] == kart64)
            {
                label18.Text = "6";
            }
            if (karistirin[16] == kart71 || karistirin[16] == kart72 || karistirin[16] == kart73 || karistirin[16] == kart74)
            {
                label18.Text = "7";
            }
            if (karistirin[16] == kart81 || karistirin[16] == kart82 || karistirin[16] == kart83 || karistirin[16] == kart84)
            {
                label18.Text = "8";
            }
            if (karistirin[16] == kart91 || karistirin[16] == kart92 || karistirin[16] == kart93 || karistirin[16] == kart94)
            {
                label18.Text = "9";
            }
            if (karistirin[16] == kart01 || karistirin[16] == kart02 || karistirin[16] == kart03 || karistirin[16] == kart04)
            {
                label18.Text = "10";
            }
            #endregion
            #region label19
            if (karistirin[17] == kart11 || karistirin[17] == kart12 || karistirin[17] == kart13 || karistirin[17] == kart14)
            {
                label19.Text = "1";
            }
            if (karistirin[17] == kart21 || karistirin[17] == kart22 || karistirin[17] == kart23 || karistirin[17] == kart24)
            {
                label19.Text = "2";
            }
            if (karistirin[17] == kart31 || karistirin[17] == kart32 || karistirin[17] == kart33 || karistirin[17] == kart34)
            {
                label19.Text = "3";
            }
            if (karistirin[17] == kart41 || karistirin[17] == kart42 || karistirin[17] == kart43 || karistirin[17] == kart44)
            {
                label19.Text = "4";
            }
            if (karistirin[17] == kart51 || karistirin[17] == kart52 || karistirin[17] == kart53 || karistirin[17] == kart54)
            {
                label19.Text = "5";
            }
            if (karistirin[17] == kart61 || karistirin[17] == kart62 || karistirin[17] == kart63 || karistirin[17] == kart64)
            {
                label19.Text = "6";
            }
            if (karistirin[17] == kart71 || karistirin[17] == kart72 || karistirin[17] == kart73 || karistirin[17] == kart74)
            {
                label19.Text = "7";
            }
            if (karistirin[17] == kart81 || karistirin[17] == kart82 || karistirin[17] == kart83 || karistirin[17] == kart84)
            {
                label19.Text = "8";
            }
            if (karistirin[17] == kart91 || karistirin[17] == kart92 || karistirin[17] == kart93 || karistirin[17] == kart94)
            {
                label19.Text = "9";
            }
            if (karistirin[17] == kart01 || karistirin[17] == kart02 || karistirin[17] == kart03 || karistirin[17] == kart04)
            {
                label19.Text = "10";
            }
            #endregion
            #region label20
            if (karistirin[18] == kart11 || karistirin[18] == kart12 || karistirin[18] == kart13 || karistirin[18] == kart14)
            {
                label20.Text = "1";
            }
            if (karistirin[18] == kart21 || karistirin[18] == kart22 || karistirin[18] == kart23 || karistirin[18] == kart24)
            {
                label20.Text = "2";
            }
            if (karistirin[18] == kart31 || karistirin[18] == kart32 || karistirin[18] == kart33 || karistirin[18] == kart34)
            {
                label20.Text = "3";
            }
            if (karistirin[18] == kart41 || karistirin[18] == kart42 || karistirin[18] == kart43 || karistirin[18] == kart44)
            {
                label20.Text = "4";
            }
            if (karistirin[18] == kart51 || karistirin[18] == kart52 || karistirin[18] == kart53 || karistirin[18] == kart54)
            {
                label20.Text = "5";
            }
            if (karistirin[18] == kart61 || karistirin[18] == kart62 || karistirin[18] == kart63 || karistirin[18] == kart64)
            {
                label20.Text = "6";
            }
            if (karistirin[18] == kart71 || karistirin[18] == kart72 || karistirin[18] == kart73 || karistirin[18] == kart74)
            {
                label20.Text = "7";
            }
            if (karistirin[18] == kart81 || karistirin[18] == kart82 || karistirin[18] == kart83 || karistirin[18] == kart84)
            {
                label20.Text = "8";
            }
            if (karistirin[18] == kart91 || karistirin[18] == kart92 || karistirin[18] == kart93 || karistirin[18] == kart94)
            {
                label20.Text = "9";
            }
            if (karistirin[18] == kart01 || karistirin[18] == kart02 || karistirin[18] == kart03 || karistirin[18] == kart04)
            {
                label20.Text = "10";
            }
            #endregion
            #region label21
            if (karistirin[19] == kart11 || karistirin[19] == kart12 || karistirin[19] == kart13 || karistirin[19] == kart14)
            {
                label21.Text = "1";
            }
            if (karistirin[19] == kart21 || karistirin[19] == kart22 || karistirin[19] == kart23 || karistirin[19] == kart24)
            {
                label21.Text = "2";
            }
            if (karistirin[19] == kart31 || karistirin[19] == kart32 || karistirin[19] == kart33 || karistirin[19] == kart34)
            {
                label21.Text = "3";
            }
            if (karistirin[19] == kart41 || karistirin[19] == kart42 || karistirin[19] == kart43 || karistirin[19] == kart44)
            {
                label21.Text = "4";
            }
            if (karistirin[19] == kart51 || karistirin[19] == kart52 || karistirin[19] == kart53 || karistirin[19] == kart54)
            {
                label21.Text = "5";
            }
            if (karistirin[19] == kart61 || karistirin[19] == kart62 || karistirin[19] == kart63 || karistirin[19] == kart64)
            {
                label21.Text = "6";
            }
            if (karistirin[19] == kart71 || karistirin[19] == kart72 || karistirin[19] == kart73 || karistirin[19] == kart74)
            {
                label21.Text = "7";
            }
            if (karistirin[19] == kart81 || karistirin[19] == kart82 || karistirin[19] == kart83 || karistirin[19] == kart84)
            {
                label21.Text = "8";
            }
            if (karistirin[19] == kart91 || karistirin[19] == kart92 || karistirin[19] == kart93 || karistirin[19] == kart94)
            {
                label21.Text = "9";
            }
            if (karistirin[19] == kart01 || karistirin[19] == kart02 || karistirin[19] == kart03 || karistirin[19] == kart04)
            {
                label21.Text = "10";
            }
            #endregion
            #region label22
            if (karistirin[20] == kart11 || karistirin[20] == kart12 || karistirin[20] == kart13 || karistirin[20] == kart14)
            {
                label22.Text = "1";
            }
            if (karistirin[20] == kart21 || karistirin[20] == kart22 || karistirin[20] == kart23 || karistirin[20] == kart24)
            {
                label22.Text = "2";
            }
            if (karistirin[20] == kart31 || karistirin[20] == kart32 || karistirin[20] == kart33 || karistirin[20] == kart34)
            {
                label22.Text = "3";
            }
            if (karistirin[20] == kart41 || karistirin[20] == kart42 || karistirin[20] == kart43 || karistirin[20] == kart44)
            {
                label22.Text = "4";
            }
            if (karistirin[20] == kart51 || karistirin[20] == kart52 || karistirin[20] == kart53 || karistirin[20] == kart54)
            {
                label22.Text = "5";
            }
            if (karistirin[20] == kart61 || karistirin[20] == kart62 || karistirin[20] == kart63 || karistirin[20] == kart64)
            {
                label22.Text = "6";
            }
            if (karistirin[20] == kart71 || karistirin[20] == kart72 || karistirin[20] == kart73 || karistirin[20] == kart74)
            {
                label22.Text = "7";
            }
            if (karistirin[20] == kart81 || karistirin[20] == kart82 || karistirin[20] == kart83 || karistirin[20] == kart84)
            {
                label22.Text = "8";
            }
            if (karistirin[20] == kart91 || karistirin[20] == kart92 || karistirin[20] == kart93 || karistirin[20] == kart94)
            {
                label22.Text = "9";
            }
            if (karistirin[20] == kart01 || karistirin[20] == kart02 || karistirin[20] == kart03 || karistirin[20] == kart04)
            {
                label22.Text = "10";
            }
            #endregion
            #region label23
            if (karistirin[21] == kart11 || karistirin[21] == kart12 || karistirin[21] == kart13 || karistirin[21] == kart14)
            {
                label23.Text = "1";
            }
            if (karistirin[21] == kart21 || karistirin[21] == kart22 || karistirin[21] == kart23 || karistirin[21] == kart24)
            {
                label23.Text = "2";
            }
            if (karistirin[21] == kart31 || karistirin[21] == kart32 || karistirin[21] == kart33 || karistirin[21] == kart34)
            {
                label23.Text = "3";
            }
            if (karistirin[21] == kart41 || karistirin[21] == kart42 || karistirin[21] == kart43 || karistirin[21] == kart44)
            {
                label23.Text = "4";
            }
            if (karistirin[21] == kart51 || karistirin[21] == kart52 || karistirin[21] == kart53 || karistirin[21] == kart54)
            {
                label23.Text = "5";
            }
            if (karistirin[21] == kart61 || karistirin[21] == kart62 || karistirin[21] == kart63 || karistirin[21] == kart64)
            {
                label23.Text = "6";
            }
            if (karistirin[21] == kart71 || karistirin[21] == kart72 || karistirin[21] == kart73 || karistirin[21] == kart74)
            {
                label23.Text = "7";
            }
            if (karistirin[21] == kart81 || karistirin[21] == kart82 || karistirin[21] == kart83 || karistirin[21] == kart84)
            {
                label23.Text = "8";
            }
            if (karistirin[21] == kart91 || karistirin[21] == kart92 || karistirin[21] == kart93 || karistirin[21] == kart94)
            {
                label23.Text = "9";
            }
            if (karistirin[21] == kart01 || karistirin[21] == kart02 || karistirin[21] == kart03 || karistirin[21] == kart04)
            {
                label23.Text = "10";
            }
            #endregion
            #region label24
            if (karistirin[22] == kart11 || karistirin[21] == kart12 || karistirin[21] == kart13 || karistirin[22] == kart14)
            {
                label24.Text = "1";
            }
            if (karistirin[22] == kart21 || karistirin[21] == kart22 || karistirin[21] == kart23 || karistirin[22] == kart24)
            {
                label24.Text = "2";
            }
            if (karistirin[22] == kart31 || karistirin[22] == kart32 || karistirin[22] == kart33 || karistirin[22] == kart34)
            {
                label24.Text = "3";
            }
            if (karistirin[22] == kart41 || karistirin[22] == kart42 || karistirin[22] == kart43 || karistirin[22] == kart44)
            {
                label24.Text = "4";
            }
            if (karistirin[22] == kart51 || karistirin[22] == kart52 || karistirin[22] == kart53 || karistirin[22] == kart54)
            {
                label24.Text = "5";
            }
            if (karistirin[22] == kart61 || karistirin[22] == kart62 || karistirin[22] == kart63 || karistirin[22] == kart64)
            {
                label24.Text = "6";
            }
            if (karistirin[22] == kart71 || karistirin[22] == kart72 || karistirin[22] == kart73 || karistirin[22] == kart74)
            {
                label24.Text = "7";
            }
            if (karistirin[22] == kart81 || karistirin[22] == kart82 || karistirin[22] == kart83 || karistirin[22] == kart84)
            {
                label24.Text = "8";
            }
            if (karistirin[22] == kart91 || karistirin[22] == kart92 || karistirin[22] == kart93 || karistirin[22] == kart94)
            {
                label24.Text = "9";
            }
            if (karistirin[22] == kart01 || karistirin[22] == kart02 || karistirin[22] == kart03 || karistirin[22] == kart04)
            {
                label24.Text = "10";
            }
            #endregion
            #region label25
            if (karistirin[23] == kart11 || karistirin[23] == kart12 || karistirin[23] == kart13 || karistirin[23] == kart14)
            {
                label25.Text = "1";
            }
            if (karistirin[23] == kart21 || karistirin[23] == kart22 || karistirin[23] == kart23 || karistirin[23] == kart24)
            {
                label25.Text = "2";
            }
            if (karistirin[23] == kart31 || karistirin[23] == kart32 || karistirin[23] == kart33 || karistirin[23] == kart34)
            {
                label25.Text = "3";
            }
            if (karistirin[23] == kart41 || karistirin[23] == kart42 || karistirin[23] == kart43 || karistirin[23] == kart44)
            {
                label25.Text = "4";
            }
            if (karistirin[23] == kart51 || karistirin[23] == kart52 || karistirin[23] == kart53 || karistirin[23] == kart54)
            {
                label25.Text = "5";
            }
            if (karistirin[23] == kart61 || karistirin[23] == kart62 || karistirin[23] == kart63 || karistirin[23] == kart64)
            {
                label25.Text = "6";
            }
            if (karistirin[23] == kart71 || karistirin[23] == kart72 || karistirin[23] == kart73 || karistirin[23] == kart74)
            {
                label25.Text = "7";
            }
            if (karistirin[23] == kart81 || karistirin[23] == kart82 || karistirin[23] == kart83 || karistirin[23] == kart84)
            {
                label25.Text = "8";
            }
            if (karistirin[23] == kart91 || karistirin[23] == kart92 || karistirin[23] == kart93 || karistirin[23] == kart94)
            {
                label25.Text = "9";
            }
            if (karistirin[23] == kart01 || karistirin[23] == kart02 || karistirin[23] == kart03 || karistirin[23] == kart04)
            {
                label25.Text = "10";
            }
            #endregion
            #region label26
            if (karistirin[24] == kart11 || karistirin[24] == kart12 || karistirin[24] == kart13 || karistirin[24] == kart14)
            {
                label26.Text = "1";
            }
            if (karistirin[24] == kart21 || karistirin[24] == kart22 || karistirin[24] == kart23 || karistirin[24] == kart24)
            {
                label26.Text = "2";
            }
            if (karistirin[24] == kart31 || karistirin[24] == kart32 || karistirin[24] == kart33 || karistirin[24] == kart34)
            {
                label26.Text = "3";
            }
            if (karistirin[24] == kart41 || karistirin[24] == kart42 || karistirin[24] == kart43 || karistirin[24] == kart44)
            {
                label26.Text = "4";
            }
            if (karistirin[24] == kart51 || karistirin[24] == kart52 || karistirin[24] == kart53 || karistirin[24] == kart54)
            {
                label26.Text = "5";
            }
            if (karistirin[24] == kart61 || karistirin[24] == kart62 || karistirin[24] == kart63 || karistirin[24] == kart64)
            {
                label26.Text = "6";
            }
            if (karistirin[24] == kart71 || karistirin[24] == kart72 || karistirin[24] == kart73 || karistirin[24] == kart74)
            {
                label26.Text = "7";
            }
            if (karistirin[24] == kart81 || karistirin[24] == kart82 || karistirin[24] == kart83 || karistirin[24] == kart84)
            {
                label26.Text = "8";
            }
            if (karistirin[24] == kart91 || karistirin[24] == kart92 || karistirin[24] == kart93 || karistirin[24] == kart94)
            {
                label26.Text = "9";
            }
            if (karistirin[24] == kart01 || karistirin[24] == kart02 || karistirin[24] == kart03 || karistirin[24] == kart04)
            {
                label26.Text = "10";
            }
            #endregion
            #region label27
            if (karistirin[25] == kart11 || karistirin[25] == kart12 || karistirin[25] == kart13 || karistirin[25] == kart14)
            {
                label27.Text = "1";
            }
            if (karistirin[25] == kart21 || karistirin[25] == kart22 || karistirin[25] == kart23 || karistirin[25] == kart24)
            {
                label27.Text = "2";
            }
            if (karistirin[25] == kart31 || karistirin[25] == kart32 || karistirin[25] == kart33 || karistirin[25] == kart34)
            {
                label27.Text = "3";
            }
            if (karistirin[25] == kart41 || karistirin[25] == kart42 || karistirin[25] == kart43 || karistirin[25] == kart44)
            { 
                label27.Text = "4";
            }
            if (karistirin[25] == kart51 || karistirin[25] == kart52 || karistirin[25] == kart53 || karistirin[25] == kart54)
            {
                label27.Text = "5";
            }
            if (karistirin[25] == kart61 || karistirin[25] == kart62 || karistirin[25] == kart63 || karistirin[25] == kart64)
            {
                label27.Text = "6";
            }
            if (karistirin[25] == kart71 || karistirin[25] == kart72 || karistirin[25] == kart73 || karistirin[25] == kart74)
            {
                label27.Text = "7";
            }
            if (karistirin[25] == kart81 || karistirin[25] == kart82 || karistirin[25] == kart83 || karistirin[25] == kart84)
            {
                label27.Text = "8";
            }
            if (karistirin[25] == kart91 || karistirin[25] == kart92 || karistirin[25] == kart93 || karistirin[25] == kart94)
            {
                label27.Text = "9";
            }
            if (karistirin[25] == kart01 || karistirin[25] == kart02 || karistirin[25] == kart03 || karistirin[25] == kart04)
            {
                label27.Text = "10";
            }
            #endregion
            #region label28
            if (karistirin[26] == kart11 || karistirin[26] == kart12 || karistirin[26] == kart13 || karistirin[26] == kart14)
            {
                label28.Text = "1";
            }
            if (karistirin[26] == kart21 || karistirin[26] == kart22 || karistirin[26] == kart23 || karistirin[26] == kart24)
            {
                label28.Text = "2";
            }
            if (karistirin[26] == kart31 || karistirin[26] == kart32 || karistirin[26] == kart33 || karistirin[26] == kart34)
            {
                label28.Text = "3";
            }
            if (karistirin[26] == kart41 || karistirin[26] == kart42 || karistirin[26] == kart43 || karistirin[26] == kart44)
            {
                label28.Text = "4";
            }
            if (karistirin[26] == kart51 || karistirin[26] == kart52 || karistirin[26] == kart53 || karistirin[26] == kart54)
            {
                label28.Text = "5";
            }
            if (karistirin[26] == kart61 || karistirin[26] == kart62 || karistirin[26] == kart63 || karistirin[26] == kart64)
            {
                label28.Text = "6";
            }
            if (karistirin[26] == kart71 || karistirin[26] == kart72 || karistirin[26] == kart73 || karistirin[26] == kart74)
            {
                label28.Text = "7";
            }
            if (karistirin[26] == kart81 || karistirin[26] == kart82 || karistirin[26] == kart83 || karistirin[26] == kart84)
            {
                label28.Text = "8";
            }
            if (karistirin[26] == kart91 || karistirin[26] == kart92 || karistirin[26] == kart93 || karistirin[26] == kart94)
            {
                label28.Text = "9";
            }
            if (karistirin[26] == kart01 || karistirin[26] == kart02 || karistirin[26] == kart03 || karistirin[26] == kart04)
            {
                label28.Text = "10";
            }
            #endregion
            #region label29
            if (karistirin[27] == kart11 || karistirin[27] == kart12 || karistirin[27] == kart13 || karistirin[27] == kart14)
            {
                label29.Text = "1";
            }
            if (karistirin[27] == kart21 || karistirin[27] == kart22 || karistirin[27] == kart23 || karistirin[27] == kart24)
            {
                label29.Text = "2";
            }
            if (karistirin[27] == kart31 || karistirin[27] == kart32 || karistirin[27] == kart33 || karistirin[27] == kart34)
            {
                label29.Text = "3";
            }
            if (karistirin[27] == kart41 || karistirin[27] == kart42 || karistirin[27] == kart43 || karistirin[27] == kart44)
            {
                label29.Text = "4";
            }
            if (karistirin[27] == kart51 || karistirin[27] == kart52 || karistirin[27] == kart53 || karistirin[27] == kart54)
            {
                label29.Text = "5";
            }
            if (karistirin[27] == kart61 || karistirin[27] == kart62 || karistirin[27] == kart63 || karistirin[27] == kart64)
            {
                label29.Text = "6";
            }
            if (karistirin[27] == kart71 || karistirin[27] == kart72 || karistirin[27] == kart73 || karistirin[27] == kart74)
            {
                label29.Text = "7";
            }
            if (karistirin[27] == kart81 || karistirin[27] == kart82 || karistirin[27] == kart83 || karistirin[27] == kart84)
            {
                label29.Text = "8";
            }
            if (karistirin[27] == kart91 || karistirin[27] == kart92 || karistirin[27] == kart93 || karistirin[27] == kart94)
            {
                label29.Text = "9";
            }
            if (karistirin[27] == kart01 || karistirin[27] == kart02 || karistirin[27] == kart03 || karistirin[27] == kart04)
            {
                label29.Text = "10";
            }
            #endregion
            #region label30
            if (karistirin[28] == kart11 || karistirin[28] == kart12 || karistirin[28] == kart13 || karistirin[28] == kart14)
            { 
                label30.Text = "1";
            }
            if (karistirin[28] == kart21 || karistirin[28] == kart22 || karistirin[28] == kart23 || karistirin[28] == kart24)
            {
                label30.Text = "2";
            }
            if (karistirin[28] == kart31 || karistirin[28] == kart32 || karistirin[28] == kart33 || karistirin[28] == kart34)
            {
                label30.Text = "3";
            }
            if (karistirin[28] == kart41 || karistirin[28] == kart42 || karistirin[28] == kart43 || karistirin[28] == kart44)
            {
                label30.Text = "4";
            }
            if (karistirin[28] == kart51 || karistirin[28] == kart52 || karistirin[28] == kart53 || karistirin[28] == kart54)
            {
                label30.Text = "5";
            }
            if (karistirin[28] == kart61 || karistirin[28] == kart62 || karistirin[28] == kart63 || karistirin[28] == kart64)
            {
                label30.Text = "6";
            }
            if (karistirin[28] == kart71 || karistirin[28] == kart72 || karistirin[28] == kart73 || karistirin[28] == kart74)
            {
                label30.Text = "7";
            }
            if (karistirin[28] == kart81 || karistirin[28] == kart82 || karistirin[28] == kart83 || karistirin[28] == kart84)
            {
                label30.Text = "8";
            }
            if (karistirin[28] == kart91 || karistirin[28] == kart92 || karistirin[28] == kart93 || karistirin[28] == kart94)
            {
                label30.Text = "9";
            }
            if (karistirin[28] == kart01 || karistirin[28] == kart02 || karistirin[28] == kart03 || karistirin[28] == kart04)
            {
                label30.Text = "10";
            }
            #endregion
            #region label31
            if (karistirin[29] == kart11 || karistirin[29] == kart12 || karistirin[29] == kart13 || karistirin[29] == kart14)
            {
                label31.Text = "1";
            }
            if (karistirin[29] == kart21 || karistirin[29] == kart22 || karistirin[29] == kart23 || karistirin[29] == kart24)
            {
                label31.Text = "2";
            }
            if (karistirin[29] == kart31 || karistirin[29] == kart32 || karistirin[29] == kart33 || karistirin[29] == kart34)
            {
                label31.Text = "3";
            }
            if (karistirin[29] == kart41 || karistirin[29] == kart42 || karistirin[29] == kart43 || karistirin[29] == kart44)
            {
                label31.Text = "4";
            }
            if (karistirin[29] == kart51 || karistirin[29] == kart52 || karistirin[29] == kart53 || karistirin[29] == kart54)
            {
                label31.Text = "5";
            }
            if (karistirin[29] == kart61 || karistirin[29] == kart62 || karistirin[29] == kart63 || karistirin[29] == kart64)
            {
                label31.Text = "6";
            }
            if (karistirin[29] == kart71 || karistirin[29] == kart72 || karistirin[29] == kart73 || karistirin[29] == kart74)
            {
                label31.Text = "7";
            }
            if (karistirin[29] == kart81 || karistirin[29] == kart82 || karistirin[29] == kart83 || karistirin[29] == kart84)
            {
                label31.Text = "8";
            }
            if (karistirin[29] == kart91 || karistirin[29] == kart92 || karistirin[29] == kart93 || karistirin[29] == kart94)
            {
                label31.Text = "9";
            }
            if (karistirin[29] == kart01 || karistirin[29] == kart02 || karistirin[29] == kart03 || karistirin[29] == kart04)
            {
                label31.Text = "10";
            }
            #endregion
            #region label32
            if (karistirin[30] == kart11 || karistirin[30] == kart12 || karistirin[30] == kart13 || karistirin[30] == kart14)
            { 
                label32.Text = "1";
            }
            if (karistirin[30] == kart21 || karistirin[30] == kart22 || karistirin[30] == kart23 || karistirin[30] == kart24)
            {
                label32.Text = "2";
            }
            if (karistirin[30] == kart31 || karistirin[30] == kart32 || karistirin[30] == kart33 || karistirin[30] == kart34)
            {
                label32.Text = "3";
            }
            if (karistirin[30] == kart41 || karistirin[30] == kart42 || karistirin[30] == kart43 || karistirin[30] == kart44)
            {
                label32.Text = "4";
            }
            if (karistirin[30] == kart51 || karistirin[30] == kart52 || karistirin[30] == kart53 || karistirin[30] == kart54)
            {
                label32.Text = "5";
            }
            if (karistirin[30] == kart61 || karistirin[30] == kart62 || karistirin[30] == kart63 || karistirin[30] == kart64)
            {
                label32.Text = "6";
            }
            if (karistirin[30] == kart71 || karistirin[30] == kart72 || karistirin[30] == kart73 || karistirin[30] == kart74)
            {
                label32.Text = "7";
            }
            if (karistirin[30] == kart81 || karistirin[30] == kart82 || karistirin[30] == kart83 || karistirin[30] == kart84)
            {
                label32.Text = "8";
            }
            if (karistirin[30] == kart91 || karistirin[30] == kart92 || karistirin[30] == kart93 || karistirin[30] == kart94)
            {
                label32.Text = "9";
            }
            if (karistirin[30] == kart01 || karistirin[30] == kart02 || karistirin[30] == kart03 || karistirin[30] == kart04)
            {
                label32.Text = "10";
            }
            #endregion
            #region label33
            if (karistirin[31] == kart11 || karistirin[31] == kart12 || karistirin[31] == kart13 || karistirin[31] == kart14)
            {
                label33.Text = "1";
            }
            if (karistirin[31] == kart21 || karistirin[31] == kart22 || karistirin[31] == kart23 || karistirin[31] == kart24)
            {
                label33.Text = "2";
            }
            if (karistirin[31] == kart31 || karistirin[31] == kart32 || karistirin[31] == kart33 || karistirin[31] == kart34)
            {
                label33.Text = "3";
            }
            if (karistirin[31] == kart41 || karistirin[31] == kart42 || karistirin[31] == kart43 || karistirin[31] == kart44)
            {
                label33.Text = "4";
            }
            if (karistirin[31] == kart51 || karistirin[31] == kart52 || karistirin[31] == kart53 || karistirin[31] == kart54)
            {
                label33.Text = "5";
            }
            if (karistirin[31] == kart61 || karistirin[31] == kart62 || karistirin[31] == kart63 || karistirin[31] == kart64)
            {
                label33.Text = "6";
            }
            if (karistirin[31] == kart71 || karistirin[31] == kart72 || karistirin[31] == kart73 || karistirin[31] == kart74)
            {
                label33.Text = "7";
            }
            if (karistirin[31] == kart81 || karistirin[31] == kart82 || karistirin[31] == kart83 || karistirin[31] == kart84)
            {
                label33.Text = "8";
            }
            if (karistirin[31] == kart91 || karistirin[31] == kart92 || karistirin[31] == kart93 || karistirin[31] == kart94)
            {
                label33.Text = "9";
            }
            if (karistirin[31] == kart01 || karistirin[31] == kart02 || karistirin[31] == kart03 || karistirin[31] == kart04)
            {
                label33.Text = "10";
            }
            #endregion
            #region label34
            if (karistirin[32] == kart11 || karistirin[32] == kart12 || karistirin[32] == kart13 || karistirin[32] == kart14)
            {
                label34.Text = "1";
            }
            if (karistirin[32] == kart21 || karistirin[32] == kart22 || karistirin[32] == kart23 || karistirin[32] == kart24)
            {
                label34.Text = "2";
            }
            if (karistirin[32] == kart31 || karistirin[32] == kart32 || karistirin[32] == kart33 || karistirin[32] == kart34)
            {
                label34.Text = "3";
            }
            if (karistirin[32] == kart41 || karistirin[32] == kart42 || karistirin[32] == kart43 || karistirin[32] == kart44)
            {
                label34.Text = "4";
            }
            if (karistirin[32] == kart51 || karistirin[32] == kart52 || karistirin[32] == kart53 || karistirin[32] == kart54)
            {
                label34.Text = "5";
            }
            if (karistirin[32] == kart61 || karistirin[32] == kart62 || karistirin[32] == kart63 || karistirin[32] == kart64)
            {
                label34.Text = "6";
            }
            if (karistirin[32] == kart71 || karistirin[32] == kart72 || karistirin[32] == kart73 || karistirin[32] == kart74)
            {
                label34.Text = "7";
            }
            if (karistirin[32] == kart81 || karistirin[32] == kart82 || karistirin[32] == kart83 || karistirin[32] == kart84)
            {
                label34.Text = "8";
            }
            if (karistirin[32] == kart91 || karistirin[32] == kart92 || karistirin[32] == kart93 || karistirin[32] == kart94)
            {
                label34.Text = "9";
            }
            if (karistirin[32] == kart01 || karistirin[32] == kart02 || karistirin[32] == kart03 || karistirin[32] == kart04)
            {
                label34.Text = "10";
            }
            #endregion
            #region label35
            if (karistirin[33] == kart11 || karistirin[33] == kart12 || karistirin[33] == kart13 || karistirin[33] == kart14)
            {
                label35.Text = "1";
            }
            if (karistirin[33] == kart21 || karistirin[33] == kart22 || karistirin[33] == kart23 || karistirin[33] == kart24)
            {
                label35.Text = "2";
            }
            if (karistirin[33] == kart31 || karistirin[33] == kart32 || karistirin[33] == kart33 || karistirin[33] == kart34)
            {
                label35.Text = "3";
            }
            if (karistirin[33] == kart41 || karistirin[33] == kart42 || karistirin[33] == kart43 || karistirin[33] == kart44)
            {
                label35.Text = "4";
            }
            if (karistirin[33] == kart51 || karistirin[33] == kart52 || karistirin[33] == kart53 || karistirin[33] == kart54)
            {
                label35.Text = "5";
            }
            if (karistirin[33] == kart61 || karistirin[33] == kart62 || karistirin[33] == kart63 || karistirin[33] == kart64)
            {
                label35.Text = "6";
            }
            if (karistirin[33] == kart71 || karistirin[33] == kart72 || karistirin[33] == kart73 || karistirin[33] == kart74)
            {
                label35.Text = "7";
            }
            if (karistirin[33] == kart81 || karistirin[33] == kart82 || karistirin[33] == kart83 || karistirin[33] == kart84)
            {
                label35.Text = "8";
            }
            if (karistirin[33] == kart91 || karistirin[33] == kart92 || karistirin[33] == kart93 || karistirin[33] == kart94)
            {
                label35.Text = "9";
            }
            if (karistirin[33] == kart01 || karistirin[33] == kart02 || karistirin[33] == kart03 || karistirin[33] == kart04)
            {
                label35.Text = "10";
            }
            #endregion
            #region label36
            if (karistirin[34] == kart11 || karistirin[34] == kart12 || karistirin[34] == kart13 || karistirin[34] == kart14)
            {
                label36.Text = "1";
            }
            if (karistirin[34] == kart21 || karistirin[34] == kart22 || karistirin[34] == kart23 || karistirin[34] == kart24)
            {
                label36.Text = "2";
            }
            if (karistirin[34] == kart31 || karistirin[34] == kart32 || karistirin[34] == kart33 || karistirin[34] == kart34)
            {
                label36.Text = "3";
            }
            if (karistirin[34] == kart41 || karistirin[34] == kart42 || karistirin[34] == kart43 || karistirin[34] == kart44)
            {
                label36.Text = "4";
            }
            if (karistirin[34] == kart51 || karistirin[34] == kart52 || karistirin[34] == kart53 || karistirin[34] == kart54)
            {
                label36.Text = "5";
            }
            if (karistirin[34] == kart61 || karistirin[34] == kart62 || karistirin[34] == kart63 || karistirin[34] == kart64)
            {
                label36.Text = "6";
            }
            if (karistirin[34] == kart71 || karistirin[34] == kart72 || karistirin[34] == kart73 || karistirin[34] == kart74)
            {
                label36.Text = "7";
            }
            if (karistirin[34] == kart81 || karistirin[34] == kart82 || karistirin[34] == kart83 || karistirin[34] == kart84)
            {
                label36.Text = "8";
            }
            if (karistirin[34] == kart91 || karistirin[34] == kart92 || karistirin[34] == kart93 || karistirin[34] == kart94)
            {
                label36.Text = "9";
            }
            if (karistirin[34] == kart01 || karistirin[34] == kart02 || karistirin[34] == kart03 || karistirin[34] == kart04)
            {
                label36.Text = "10";
            }
            #endregion
            #region label37
            if (karistirin[35] == kart11 || karistirin[35] == kart12 || karistirin[35] == kart13 || karistirin[35] == kart14)
            {
                label37.Text = "1";
            }
            if (karistirin[35] == kart21 || karistirin[35] == kart22 || karistirin[35] == kart23 || karistirin[35] == kart24)
            {
                label37.Text = "2";
            }
            if (karistirin[35] == kart31 || karistirin[35] == kart32 || karistirin[35] == kart33 || karistirin[35] == kart34)
            {
                label37.Text = "3";
            }
            if (karistirin[35] == kart41 || karistirin[35] == kart42 || karistirin[35] == kart43 || karistirin[35] == kart44)
            {
                label37.Text = "4";
            }
            if (karistirin[35] == kart51 || karistirin[35] == kart52 || karistirin[35] == kart53 || karistirin[35] == kart54)
            {
                label37.Text = "5";
            }
            if (karistirin[35] == kart61 || karistirin[35] == kart62 || karistirin[35] == kart63 || karistirin[35] == kart64)
            {
                label37.Text = "6";
            }
            if (karistirin[35] == kart71 || karistirin[35] == kart72 || karistirin[35] == kart73 || karistirin[35] == kart74)
            {
                label37.Text = "7";
            }
            if (karistirin[35] == kart81 || karistirin[35] == kart82 || karistirin[35] == kart83 || karistirin[35] == kart84)
            {
                label37.Text = "8";
            }
            if (karistirin[35] == kart91 || karistirin[35] == kart92 || karistirin[35] == kart93 || karistirin[35] == kart94)
            {
                label37.Text = "9";
            }
            if (karistirin[35] == kart01 || karistirin[35] == kart02 || karistirin[35] == kart03 || karistirin[35] == kart04)
            {
                label37.Text = "10";
            }
            #endregion
            #region label38
            if (karistirin[36] == kart11 || karistirin[36] == kart12 || karistirin[36] == kart13 || karistirin[36] == kart14)
            {
                label38.Text = "1";
            }
            if (karistirin[36] == kart21 || karistirin[36] == kart22 || karistirin[36] == kart23 || karistirin[36] == kart24)
            {
                label38.Text = "2";
            }
            if (karistirin[36] == kart31 || karistirin[36] == kart32 || karistirin[36] == kart33 || karistirin[36] == kart34)
            {
                label38.Text = "3";
            }
            if (karistirin[36] == kart41 || karistirin[36] == kart42 || karistirin[36] == kart43 || karistirin[36] == kart44)
            {
                label38.Text = "4";
            }
            if (karistirin[36] == kart51 || karistirin[36] == kart52 || karistirin[36] == kart53 || karistirin[36] == kart54)
            {
                label38.Text = "5";
            }
            if (karistirin[36] == kart61 || karistirin[36] == kart62 || karistirin[36] == kart63 || karistirin[36] == kart64)
            {
                label38.Text = "6";
            }
            if (karistirin[36] == kart71 || karistirin[36] == kart72 || karistirin[36] == kart73 || karistirin[36] == kart74)
            {
                label38.Text = "7";
            }
            if (karistirin[36] == kart81 || karistirin[36] == kart82 || karistirin[36] == kart83 || karistirin[36] == kart84)
            {
                label38.Text = "8";
            }
            if (karistirin[36] == kart91 || karistirin[36] == kart92 || karistirin[36] == kart93 || karistirin[36] == kart94)
            {
                label38.Text = "9";
            }
            if (karistirin[36] == kart01 || karistirin[36] == kart02 || karistirin[36] == kart03 || karistirin[36] == kart04)
            {
                label38.Text = "10";
            }
            #endregion
            #region label39
            if (karistirin[37] == kart11 || karistirin[37] == kart12 || karistirin[37] == kart13 || karistirin[37] == kart14)
            {
                label39.Text = "1";
            }
            if (karistirin[37] == kart21 || karistirin[37] == kart22 || karistirin[37] == kart23 || karistirin[37] == kart24)
            {
                label39.Text = "2";
            }
            if (karistirin[37] == kart31 || karistirin[37] == kart32 || karistirin[37] == kart33 || karistirin[37] == kart34)
            {
                label39.Text = "3";
            }
            if (karistirin[37] == kart41 || karistirin[37] == kart42 || karistirin[37] == kart43 || karistirin[37] == kart44)
            {
                label39.Text = "4";
            }
            if (karistirin[37] == kart51 || karistirin[37] == kart52 || karistirin[37] == kart53 || karistirin[37] == kart54)
            {
                label39.Text = "5";
            }
            if (karistirin[37] == kart61 || karistirin[37] == kart62 || karistirin[37] == kart63 || karistirin[37] == kart64)
            {
                label39.Text = "6";
            }
            if (karistirin[37] == kart71 || karistirin[37] == kart72 || karistirin[37] == kart73 || karistirin[37] == kart74)
            {
                label39.Text = "7";
            }
            if (karistirin[37] == kart81 || karistirin[37] == kart82 || karistirin[37] == kart83 || karistirin[37] == kart84)
            {
                label39.Text = "8";
            }
            if (karistirin[37] == kart91 || karistirin[37] == kart92 || karistirin[37] == kart93 || karistirin[37] == kart94)
            {
                label39.Text = "9";
            }
            if (karistirin[37] == kart01 || karistirin[37] == kart02 || karistirin[37] == kart03 || karistirin[37] == kart04)
            {
                label39.Text = "10";
            }
            #endregion
            #region label41
            if (karistirin[38] == kart11 || karistirin[38] == kart12 || karistirin[38] == kart13 || karistirin[38] == kart14)
            {
                label41.Text = "1";
            }
            if (karistirin[38] == kart21 || karistirin[38] == kart22 || karistirin[38] == kart23 || karistirin[38] == kart24)
            {
                label41.Text = "2";
            }
            if (karistirin[38] == kart31 || karistirin[38] == kart32 || karistirin[38] == kart33 || karistirin[38] == kart34)
            {
                label41.Text = "3";
            }
            if (karistirin[38] == kart41 || karistirin[38] == kart42 || karistirin[38] == kart43 || karistirin[38] == kart44)
            {
                label41.Text = "4";
            }
            if (karistirin[38] == kart51 || karistirin[38] == kart52 || karistirin[38] == kart53 || karistirin[38] == kart54)
            {
                label41.Text = "5";
            }
            if (karistirin[38] == kart61 || karistirin[38] == kart62 || karistirin[38] == kart63 || karistirin[38] == kart64)
            {
                label41.Text = "6";
            }
            if (karistirin[38] == kart71 || karistirin[38] == kart72 || karistirin[38] == kart73 || karistirin[38] == kart74)
            {
                label41.Text = "7";
            }
            if (karistirin[38] == kart81 || karistirin[38] == kart82 || karistirin[38] == kart83 || karistirin[38] == kart84)
            {
                label41.Text = "8";
            }
            if (karistirin[38] == kart91 || karistirin[38] == kart92 || karistirin[38] == kart93 || karistirin[38] == kart94)
            {
                label41.Text = "9";
            }
            if (karistirin[38] == kart01 || karistirin[38] == kart02 || karistirin[38] == kart03 || karistirin[38] == kart04)
            {
                label41.Text = "10";
            }
            #endregion
            #region label40
            if (karistirin[39] == kart11 || karistirin[39] == kart12 || karistirin[39] == kart13 || karistirin[39] == kart14)
            {
                label40.Text = "1";
            }
            if (karistirin[39] == kart21 || karistirin[39] == kart22 || karistirin[39] == kart23 || karistirin[39] == kart24)
            {
                label40.Text = "2";
            }
            if (karistirin[39] == kart31 || karistirin[39] == kart32 || karistirin[39] == kart33 || karistirin[39] == kart34)
            {
                label40.Text = "3";
            }
            if (karistirin[39] == kart41 || karistirin[39] == kart42 || karistirin[39] == kart43 || karistirin[39] == kart44)
            {
                label40.Text = "4";
            }
            if (karistirin[39] == kart51 || karistirin[39] == kart52 || karistirin[39] == kart53 || karistirin[39] == kart54)
            {
                label40.Text = "5";
            }
            if (karistirin[39] == kart61 || karistirin[39] == kart62 || karistirin[39] == kart63 || karistirin[39] == kart64)
            {
                label40.Text = "6";
            }
            if (karistirin[39] == kart71 || karistirin[39] == kart72 || karistirin[39] == kart73 || karistirin[39] == kart74)
            {
                label40.Text = "7";
            }
            if (karistirin[39] == kart81 || karistirin[39] == kart82 || karistirin[39] == kart83 || karistirin[39] == kart84)
            {
                label40.Text = "8";
            }
            if (karistirin[39] == kart91 || karistirin[39] == kart92 || karistirin[39] == kart93 || karistirin[39] == kart94)
            {
                label40.Text = "9";
            }
            if (karistirin[39] == kart01 || karistirin[39] == kart02 || karistirin[39] == kart03 || karistirin[39] == kart04)
            {
                label40.Text = "10";
               
            }
            #endregion

                       pictureBox1.Image = Image.FromFile(karistirin[0].kart_renk);
                       pictureBox2.Image = Image.FromFile(karistirin[1].kart_renk);
                       pictureBox3.Image = Image.FromFile(karistirin[2].kart_renk);
                       pictureBox4.Image = Image.FromFile(karistirin[3].kart_renk);
                       pictureBox5.Image = Image.FromFile(karistirin[4].kart_renk);
                       pictureBox6.Image = Image.FromFile(karistirin[5].kart_renk);
                       pictureBox7.Image = Image.FromFile(karistirin[6].kart_renk);
                       pictureBox8.Image = Image.FromFile(karistirin[7].kart_renk);
                       pictureBox9.Image = Image.FromFile(karistirin[8].kart_renk);
                       pictureBox10.Image = Image.FromFile(karistirin[9].kart_renk);
                       pictureBox11.Image = Image.FromFile(karistirin[10].kart_renk);
                       pictureBox12.Image = Image.FromFile(karistirin[11].kart_renk);
                       pictureBox13.Image = Image.FromFile(karistirin[12].kart_renk);
                       pictureBox14.Image = Image.FromFile(karistirin[13].kart_renk);
                       pictureBox15.Image = Image.FromFile(karistirin[14].kart_renk);
                       pictureBox16.Image = Image.FromFile(karistirin[15].kart_renk);
                       pictureBox17.Image = Image.FromFile(karistirin[16].kart_renk);
                       pictureBox18.Image = Image.FromFile(karistirin[17].kart_renk);
                       pictureBox19.Image = Image.FromFile(karistirin[18].kart_renk);
                       pictureBox20.Image = Image.FromFile(karistirin[19].kart_renk);
                       pictureBox21.Image = Image.FromFile(karistirin[20].kart_renk);
                       pictureBox22.Image = Image.FromFile(karistirin[21].kart_renk);
                       pictureBox23.Image = Image.FromFile(karistirin[22].kart_renk);
                       pictureBox24.Image = Image.FromFile(karistirin[23].kart_renk);
                       pictureBox25.Image = Image.FromFile(karistirin[24].kart_renk);
                       pictureBox26.Image = Image.FromFile(karistirin[25].kart_renk);
                       pictureBox27.Image = Image.FromFile(karistirin[26].kart_renk);
                       pictureBox28.Image = Image.FromFile(karistirin[27].kart_renk);
                       pictureBox29.Image = Image.FromFile(karistirin[28].kart_renk);
                       pictureBox30.Image = Image.FromFile(karistirin[29].kart_renk);
                       pictureBox31.Image = Image.FromFile(karistirin[30].kart_renk);
                       pictureBox32.Image = Image.FromFile(karistirin[31].kart_renk);
                       pictureBox33.Image = Image.FromFile(karistirin[32].kart_renk);
                       pictureBox34.Image = Image.FromFile(karistirin[33].kart_renk);
                       pictureBox35.Image = Image.FromFile(karistirin[34].kart_renk);
                       pictureBox36.Image = Image.FromFile(karistirin[35].kart_renk);
                       pictureBox37.Image = Image.FromFile(karistirin[36].kart_renk);
                       pictureBox38.Image = Image.FromFile(karistirin[37].kart_renk);
                       pictureBox39.Image = Image.FromFile(karistirin[38].kart_renk);
                       pictureBox40.Image = Image.FromFile(karistirin[39].kart_renk);
            




        
        }
                 #endregion
                 
         private void degis(int pic1, int pic2, Kart[] karistirin)
          {

              Kart temp = karistirin[pic1];
              karistirin[pic1] = karistirin[pic2];
              karistirin[pic2] = temp;

          }

      private void yer_degis(Kart[] karistirin)
      {
          Random rastgele = new Random();
          for (int i = ((karistirin.Length)-1); i >= 0; i--)
          {

              degis(rastgele.Next(i + 1), i, karistirin);

          }
        }
       



private void pictureBox_DoubleClick(object sender, EventArgs e)
        {

           String secili_box = ((PictureBox)sender).Name;
            PictureBox SB = (PictureBox)this.Controls[secili_box];

            
            void kaybol()
            {
                SB.Visible = false;
                arttir();
                pictureBox40.Image = SB.Image;
                click_sayar++;

            }

            #region kurallar         

            if (SB==pictureBox1)
               {  
                  if(Convert.ToInt32(label2.Text)==(Convert.ToInt32(label40.Text)+1) || Convert.ToInt32(label2.Text) == (Convert.ToInt32(label40.Text) - 1)|| Convert.ToInt32(label2.Text) == (Convert.ToInt32(label40.Text) + 9) || Convert.ToInt32(label2.Text) == (Convert.ToInt32(label40.Text) - 9))
                   {
                       kaybol();
                       label40.Text = label2.Text;
                   }

               }
               if (SB == pictureBox2)
               {
                   if (Convert.ToInt32(label3.Text) == (Convert.ToInt32(label40.Text) + 1) || Convert.ToInt32(label3.Text) == (Convert.ToInt32(label40.Text) - 1)|| Convert.ToInt32(label3.Text) == (Convert.ToInt32(label40.Text) + 9) || Convert.ToInt32(label3.Text) == (Convert.ToInt32(label40.Text) - 9))
                   {
                       kaybol();
                       label40.Text = label3.Text;
                   }
               }
               if (SB == pictureBox3)
               {
                   if (Convert.ToInt32(label4.Text) == (Convert.ToInt32(label40.Text) + 1) || Convert.ToInt32(label4.Text) == (Convert.ToInt32(label40.Text) - 1)|| Convert.ToInt32(label4.Text) == (Convert.ToInt32(label40.Text) + 9) || Convert.ToInt32(label4.Text) == (Convert.ToInt32(label40.Text) - 9))
                   {
                       kaybol();
                       label40.Text = label4.Text;
                   }

               }
               if (SB == pictureBox4)
               {
                   if (Convert.ToInt32(label5.Text) == (Convert.ToInt32(label40.Text) + 1) || Convert.ToInt32(label5.Text) == (Convert.ToInt32(label40.Text) - 1)|| Convert.ToInt32(label5.Text) == (Convert.ToInt32(label40.Text) + 9) || Convert.ToInt32(label5.Text) == (Convert.ToInt32(label40.Text) - 9))
                   {
                       kaybol();
                       label40.Text = label5.Text;
                   }

               }
               if (SB == pictureBox5)
               {
                if (Convert.ToInt32(label6.Text) == (Convert.ToInt32(label40.Text) + 1) || Convert.ToInt32(label6.Text) == (Convert.ToInt32(label40.Text) - 1)|| Convert.ToInt32(label6.Text) == (Convert.ToInt32(label40.Text) + 9) || Convert.ToInt32(label6.Text) == (Convert.ToInt32(label40.Text) - 9))
                {
                    kaybol();
                    label40.Text = label6.Text;
                }

            }
               if (SB == pictureBox6)
               {
                if (Convert.ToInt32(label7.Text) == (Convert.ToInt32(label40.Text) + 1) || Convert.ToInt32(label7.Text) == (Convert.ToInt32(label40.Text) - 1)|| Convert.ToInt32(label7.Text) == (Convert.ToInt32(label40.Text) + 9) || Convert.ToInt32(label7.Text) == (Convert.ToInt32(label40.Text) - 9))
                {
                    kaybol();
                    label40.Text = label7.Text;
                }
            }
               if (SB == pictureBox7)
               {
                   if (Convert.ToInt32(label8.Text) == (Convert.ToInt32(label40.Text) + 1) || Convert.ToInt32(label8.Text) == (Convert.ToInt32(label40.Text) - 1)|| Convert.ToInt32(label8.Text) == (Convert.ToInt32(label40.Text) + 9) || Convert.ToInt32(label8.Text) == (Convert.ToInt32(label40.Text) - 9))
                   {
                       kaybol();
                       label40.Text = label8.Text;
                   }
               }
               if (SB == pictureBox8)
               {
                   if (Convert.ToInt32(label9.Text) == (Convert.ToInt32(label40.Text) + 1) || Convert.ToInt32(label9.Text) == (Convert.ToInt32(label40.Text) - 1)|| Convert.ToInt32(label9.Text) == (Convert.ToInt32(label40.Text) + 9) || Convert.ToInt32(label9.Text) == (Convert.ToInt32(label40.Text) - 9))
                   {
                       kaybol();
                       label40.Text = label9.Text;
                   }
               }
               if (SB == pictureBox9)
               {
                   if (Convert.ToInt32(label10.Text) == (Convert.ToInt32(label40.Text) + 1) || Convert.ToInt32(label10.Text) == (Convert.ToInt32(label40.Text) - 1)|| Convert.ToInt32(label10.Text) == (Convert.ToInt32(label40.Text) + 9) || Convert.ToInt32(label10.Text) == (Convert.ToInt32(label40.Text) - 9))
                   {
                       kaybol();
                       label40.Text = label10.Text;
                   }
               }
            if (SB == pictureBox10)
            {
                if (Convert.ToInt32(label11.Text) == (Convert.ToInt32(label40.Text) + 1) || Convert.ToInt32(label11.Text) == (Convert.ToInt32(label40.Text) - 1)|| Convert.ToInt32(label11.Text) == (Convert.ToInt32(label40.Text) + 9) || Convert.ToInt32(label11.Text) == (Convert.ToInt32(label40.Text) - 9))
                {
                    kaybol();
                    label40.Text = label11.Text;
                }
            }
            if (SB == pictureBox11)
            {
                if (Convert.ToInt32(label12.Text) == (Convert.ToInt32(label40.Text) + 1) || Convert.ToInt32(label12.Text) == (Convert.ToInt32(label40.Text) - 1)|| Convert.ToInt32(label12.Text) == (Convert.ToInt32(label40.Text) + 9) || Convert.ToInt32(label12.Text) == (Convert.ToInt32(label40.Text) - 9))
                {
                    kaybol();
                    label40.Text = label12.Text;
                }
            }
            if (SB == pictureBox12)
            {
                if (Convert.ToInt32(label13.Text) == (Convert.ToInt32(label40.Text) + 1) || Convert.ToInt32(label13.Text) == (Convert.ToInt32(label40.Text) - 1)|| Convert.ToInt32(label13.Text) == (Convert.ToInt32(label40.Text) + 9) || Convert.ToInt32(label13.Text) == (Convert.ToInt32(label40.Text) - 9))
                {
                    kaybol();
                    label40.Text = label13.Text;
                }
            }
            if (SB == pictureBox13)
            {
                if (Convert.ToInt32(label14.Text) == (Convert.ToInt32(label40.Text) + 1) || Convert.ToInt32(label14.Text) == (Convert.ToInt32(label40.Text) - 1)|| Convert.ToInt32(label14.Text) == (Convert.ToInt32(label40.Text) + 9) || Convert.ToInt32(label14.Text) == (Convert.ToInt32(label40.Text) - 9))
                {
                    kaybol();
                    label40.Text = label14.Text;
                }
            }
            if (SB == pictureBox14)
            {
                if (Convert.ToInt32(label15.Text) == (Convert.ToInt32(label40.Text) + 1) || Convert.ToInt32(label15.Text) == (Convert.ToInt32(label40.Text) - 1)|| Convert.ToInt32(label15.Text) == (Convert.ToInt32(label40.Text) + 9) || Convert.ToInt32(label15.Text) == (Convert.ToInt32(label40.Text) - 9))
                {
                    kaybol();
                    label40.Text = label15.Text;
                }
            }
            if (SB == pictureBox15)
            {
                if (Convert.ToInt32(label16.Text) == (Convert.ToInt32(label40.Text) + 1) || Convert.ToInt32(label16.Text) == (Convert.ToInt32(label40.Text) - 1)|| Convert.ToInt32(label16.Text) == (Convert.ToInt32(label40.Text) + 9) || Convert.ToInt32(label16.Text) == (Convert.ToInt32(label40.Text) - 9))
                {
                    kaybol();
                    label40.Text = label16.Text;
                }
            }
            if (SB == pictureBox16)
            {
                if (Convert.ToInt32(label17.Text) == (Convert.ToInt32(label40.Text) + 1) || Convert.ToInt32(label17.Text) == (Convert.ToInt32(label40.Text) - 1)|| Convert.ToInt32(label17.Text) == (Convert.ToInt32(label40.Text) + 9) || Convert.ToInt32(label17.Text) == (Convert.ToInt32(label40.Text) - 9))
                {
                    kaybol();
                    label40.Text = label17.Text;
                }
            }
            if (SB == pictureBox17)
            {
                if (Convert.ToInt32(label18.Text) == (Convert.ToInt32(label40.Text) + 1) || Convert.ToInt32(label18.Text) == (Convert.ToInt32(label40.Text) - 1)|| Convert.ToInt32(label18.Text) == (Convert.ToInt32(label40.Text) + 9) || Convert.ToInt32(label18.Text) == (Convert.ToInt32(label40.Text) - 9))
                {
                    kaybol();
                    label40.Text = label18.Text;
                }
            }
            if (SB == pictureBox18)
            {
                if (Convert.ToInt32(label19.Text) == (Convert.ToInt32(label40.Text) + 1) || Convert.ToInt32(label19.Text) == (Convert.ToInt32(label40.Text) - 1)|| Convert.ToInt32(label19.Text) == (Convert.ToInt32(label40.Text) + 9) || Convert.ToInt32(label19.Text) == (Convert.ToInt32(label40.Text) - 9))
                {
                    kaybol();
                    label40.Text = label19.Text;
                }
            }
            if (SB == pictureBox19)
            {
                if (Convert.ToInt32(label20.Text) == (Convert.ToInt32(label40.Text) + 1) || Convert.ToInt32(label20.Text) == (Convert.ToInt32(label40.Text) - 1)|| Convert.ToInt32(label20.Text) == (Convert.ToInt32(label40.Text) + 9) || Convert.ToInt32(label20.Text) == (Convert.ToInt32(label40.Text) - 9))
                {
                    kaybol();
                    label40.Text = label20.Text;
                }
            }
            if (SB == pictureBox20)
            {
                if (Convert.ToInt32(label21.Text) == (Convert.ToInt32(label40.Text) + 1) || Convert.ToInt32(label21.Text) == (Convert.ToInt32(label40.Text) - 1)|| Convert.ToInt32(label21.Text) == (Convert.ToInt32(label40.Text) + 9) || Convert.ToInt32(label21.Text) == (Convert.ToInt32(label40.Text) - 9))
                {
                    kaybol();
                    label40.Text = label21.Text;
                }
            }

#endregion

            #region  Kart kapaklarının yok olması için kod

            if (pictureBox1.Visible==false)
            {
                pictureBox41.Visible = false;
            }
            if (pictureBox2.Visible == false)
            {
                pictureBox42.Visible = false;
            }
            if (pictureBox3.Visible == false)
            {
                pictureBox43.Visible = false;
            }
            if (pictureBox4.Visible == false)
            {
                pictureBox44.Visible = false;
            }
            if (pictureBox6.Visible == false)
            {
                pictureBox45.Visible = false;
            }
            if (pictureBox7.Visible == false)
            {
                pictureBox46.Visible = false;
            }
            if (pictureBox8.Visible == false)
            {
                pictureBox47.Visible = false;
            }
            if (pictureBox9.Visible == false)
            {
                pictureBox48.Visible = false;
            }
            if (pictureBox11.Visible == false)
            {
                pictureBox49.Visible = false;
            }
            if (pictureBox12.Visible == false)
            {
                pictureBox50.Visible = false;
            }
            if (pictureBox13.Visible == false)
            {
                pictureBox51.Visible = false;
            }
            if (pictureBox14.Visible == false)
            {
                pictureBox52.Visible = false;
            }
            if (pictureBox16.Visible == false)
            {
                pictureBox53.Visible = false;
            }
            if (pictureBox17.Visible == false)
            {
                pictureBox54.Visible = false;
            }
            if (pictureBox18.Visible == false)
            {
                pictureBox55.Visible = false;
            }
            if (pictureBox19.Visible == false)
            {
                pictureBox56.Visible = false;
            }
            #endregion
            
            if (pictureBox5.Visible==false && pictureBox10.Visible==false && pictureBox15.Visible==false&&pictureBox20.Visible==false)
            {
                sure.Stop();
                
                #region
                int sayac = 0;
                if (pictureBox21.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox22.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox23.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox24.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox25.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox26.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox27.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox28.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox29.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox30.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox31.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox32.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox33.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox34.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox35.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox36.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox37.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox38.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox39.Visible == true)
                {
                    sayac++;
                }
                #endregion
                score = score + (10*sayac);
                label1.Text = "SCORE: " + score;
                pictureBox57.Enabled = true;

                
                string mesaj = "OYUN BİTTİ\nPuanınız: " + score + "\nEn Uzun Kombo: " + d +"\nDestede Kalan Kart Sayısı: "+sayac +"\nTemizlenen Kart Sayısı: 20"+"\nOynama Süresi: "+gecen;
                string baslık = "Güzel Oyundu";
                MessageBox.Show(mesaj, baslık);
                win wn = new win();
                wn.Show();
                this.Close();

            }
        }

        private void pictureBox57_Click(object sender, EventArgs e)
        {

        }

        private void Bitirin_Click(object sender, EventArgs e)
        {
            sure.Stop();
            Bitirin.Visible = false;
            int sayac = 0;
            #region
            if (pictureBox1.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox2.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox3.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox4.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox5.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox6.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox7.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox8.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox9.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox10.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox11.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox13.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox14.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox15.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox16.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox17.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox18.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox19.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox20.Visible == true)
                {
                    sayac++;
                }
                if (pictureBox12.Visible == true)
                {
                    sayac++;
                }

                #endregion
                score = score - (10 * sayac);
            label1.Text = ("SCORE: " + score);

            string mesaj = "OYUN BİTTİ\nPuanınız: " + score + "\nEn Uzun Kombo: " + d + "\nDestede Kalan Kart Sayısı: 0 " + "\nTemizlenen Kart Sayısı: " + (20 - sayac) + "\nOynama Süresi: " + gecen;
            string baslık = "Güzel Oyundu";
           
            MessageBox.Show(mesaj, baslık);
           
            lose ls=new lose();
            ls.Show();
            this.Close();
                           
        }
        double gecen = 0;
        private void sure_Tick(object sender, EventArgs e)
        {
            
            gecen++;
            surem.Text = "Geçen Süre: " + gecen;
        }

        private void play_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\gamemusic.wav";
            sp.Stop();



            stop.Visible = true;
            play.Visible = false;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\gamemusic.wav";
            sp.PlayLooping();


            stop.Visible = false;
            play.Visible = true;
        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {
            DialogResult secme = new DialogResult();
            secme = MessageBox.Show("Oyun daha bitmedi. Anasayfaya dönmek istiyor musunuz?", "Anasayfa Sekmesi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secme == DialogResult.Yes)
            {
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Close();
            }
        }

        private void pictureBox58_Click(object sender, EventArgs e)
        {

        }
    }
}
