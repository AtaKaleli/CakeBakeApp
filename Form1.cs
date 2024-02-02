using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_6_Pasta_Pişirme_Uygulaması_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if(progressBar1.Value%20==10)
            {
                label1.BackColor = Color.Red;
            }
            if (progressBar1.Value%20==0)
            {
                label1.BackColor = Color.White;
            }
            if (progressBar1.Value==100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 5;
            if (progressBar2.Value % 10 == 5)
            {
                label2.BackColor = Color.Transparent;
            }
            if (progressBar2.Value % 10 == 0)
            {
                label2.BackColor = Color.Magenta;
            }



            if (progressBar2.Value==100)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 20;
            if (progressBar3.Value % 40 == 20)
            {
                label3.BackColor = Color.Green;
            }
            if (progressBar3.Value % 40 == 0)
            {
                label3.BackColor = Color.GreenYellow;
            }


            if (progressBar3.Value==100)
            {
                timer3.Stop();
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar4.Value += 10;

            if(progressBar4.Value==100)
            {
                timer4.Stop();
                
            }
            if (progressBar4.Value % 20 == 10)
            {
                label4.BackColor = Color.Orange;
            }
            if (progressBar4.Value % 20 == 0)
            {
                label4.BackColor = Color.Blue;
            }
            if (progressBar4.Value == 100)
            {
                
                label5.Visible = true;
                pictureBox1.Visible = true;
                label6.Visible = true;
                button1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }
    }
}
