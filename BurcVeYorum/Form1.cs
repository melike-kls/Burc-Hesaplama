using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurcVeYorum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int gun;
        int ay;
        private void button1_Click(object sender, EventArgs e)
        {
            ay = Convert.ToInt16(dtptarih.Value.Month);
            gun = Convert.ToInt16(dtptarih.Value.Day);

            

            if ((ay == 12 & gun >= 12) || (ay == 1 & gun <= 20))
            {
                txtburc.Text = "OĞLAK";
               
            }

            if ((ay == 9 & gun >= 22) || (ay == 10 & gun <= 23))
            {
                txtburc.Text = "TERAZİ";
               
            }

            if ((ay == 1 & gun >= 21) || (ay == 2 & gun <= 19))
            {
                txtburc.Text = "KOVA";
                
            }


            if ((ay == 2 & gun >= 20) || (ay == 3 & gun <= 20))
            {
                txtburc.Text = "BALIK";
               
            }

            if ((ay == 3 & gun >= 21) || (ay == 4 & gun <= 20))
            {
                txtburc.Text = "KOÇ";
               
            }

            if ((ay == 4 & gun >= 21) || (ay == 5 & gun <= 21))
            {
                txtburc.Text = "BOĞA";
                
            }


            if ((ay == 5 & gun >= 22) || (ay == 6 & gun <= 21))
            {
                txtburc.Text = "İKİZLER";
               
            }

            if ((ay == 6 & gun >= 22) || (ay == 7 & gun <= 23))
            {
                txtburc.Text = "YENGEÇ";
              
            }

            if ((ay == 7 & gun >= 24) || (ay == 8 & gun <= 23))
            {
                txtburc.Text = "ASLAN";
               
            }

            if ((ay == 8 & gun >= 24) || (ay == 9 & gun <= 23))
            {
                txtburc.Text = "BAŞAK";
                
            }


            if ((ay == 102 & gun >= 23) || (ay == 11 & gun <= 22))
            {
                txtburc.Text = "AKREP";
               
            }

            if ((ay == 11 & gun >= 23) || (ay == 12 & gun <= 22))
            {
                txtburc.Text = "YAY";
              
            }


        }

    }
}
