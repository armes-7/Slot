using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMakinası
{
    public partial class Form1 : Form
    {
        int JetonAdeti;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
      

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int Sayi1, Sayi2, Sayi3;
            Sayi1 = rnd.Next(1, 11);
            Sayi2 = rnd.Next(1, 11);
            Sayi3 = rnd.Next(1, 11);
            LblSayi1.Text = Sayi1.ToString();
            LblSayi2.Text = Sayi2.ToString();
            LblSayi3.Text = Sayi3.ToString();
        }

        

       
        private void BtnJetonAt_Click_1(object sender, EventArgs e)
        {
            JetonAdeti = JetonAdeti + 1;
            LblKasadakiPara.Text = JetonAdeti + "Jetonunuz Var".ToString();
            LblSonuc.Text = "";

        }

        private void BtnKapat_Click_1(object sender, EventArgs e)
        {
            if (JetonAdeti == 0)
                Close();

            LblSonuc.Text = "Kabettiniz";
            //LblKasadakiPara.Text = JetonAdeti + " Jeton".ToString();

          
        }

        private void BtnDurdur_Click_1(object sender, EventArgs e)
        {
          
            timer1.Stop();
            if (LblSayi1.Text == "3" && LblSayi2.Text == "3" && LblSayi3.Text == "3")
            {
                JetonAdeti = JetonAdeti + 5;
            }
            else if (LblSayi1.Text == "3" && LblSayi2.Text == "3")
            {
                JetonAdeti = JetonAdeti + 3;
            }
            else if (LblSayi2.Text == "3" && LblSayi3.Text == "3")
            {
                JetonAdeti = JetonAdeti + 3;
            }
            else if (LblSayi1.Text == "3" && LblSayi3.Text == "3")
            {
                JetonAdeti = JetonAdeti + 3;
            }
            else if (LblSayi1.Text == "3" && LblSayi2.Text == "3" && LblSayi3.Text == "3")
            {
                JetonAdeti = JetonAdeti + 5;
            }
            else if (LblSayi1.Text != "3" && LblSayi2.Text != "3" && LblSayi3.Text != "3")
            {
                JetonAdeti = JetonAdeti - 1;
            }
        }

        private void BtnBasla_Click_1(object sender, EventArgs e)
        {
           
            if (JetonAdeti > 0)
            {
                timer1.Start();
                BtnDurdur.Enabled = true;
                LblKasadakiPara.Text = JetonAdeti + "Jeton".ToString();
            }
            else
            {
                MessageBox.Show("Oyuna Başlıyabilmek İçin Jeton Atmalısınız");
            }

        }
    }
}
    

    

