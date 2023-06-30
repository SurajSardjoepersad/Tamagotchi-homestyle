using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamagotchi_homestyle
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            berekenProgressie();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            berekenProgressie2();
        }

        private void berekenProgressie()
        {
            int health1 = 5;
            int etenwaarde = 10;
            Convert.ToString(etenwaarde);
            this.progressBar3.Increment(etenwaarde);
            this.progressBar1.Increment(health1);
        }
        private void berekenProgressie2()
        {
            int health2 = 5;
            int drinkwaarde = 5;
            Convert.ToString(drinkwaarde);
            this.progressBar2.Increment(drinkwaarde);
            this.progressBar1.Increment(health2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int dorst = -2;
            int honger = -4;
            int health2 = -5;
            int punten = progressBar4.Value;
            int puntenop = 10;


            if (progressBar3.Value >= 0 || progressBar2.Value >= 0)
            {
                this.progressBar3.Increment(dorst);
                this.progressBar2.Increment(honger);
                this.progressBar4.Increment(puntenop);
            }

            if (progressBar2.Value == 0)
            {
                this.progressBar1.Increment(health2);
            }


            if (progressBar1.Value == 0)
            {
                MessageBox.Show(" Figaro (Uw tamagotchi) is helaas overleden omdat je niet optijd eten of drinken heb gegeven. Je hebt in totaal" + punten + "bereikt");
                int puntenstop = 10;
                this.progressBar4.Increment(puntenstop);
                timer1.Stop();
                
            }

            if (progressBar4.Value == 1000)
            {
                MessageBox.Show(" Gefeliciteerd. Je hebt Farigo genoeg eten en drinken gegeven! :)");
                timer1.Stop();
            }

            if (progressBar1.Value >= 70)
            {
                pictureBox1.Image = Properties.Resources.Happy_cat;
                pictureBox1.Refresh();
            }

            if (progressBar1.Value >= 50 && progressBar1.Value < 70)
            {
                pictureBox1.Image = Properties.Resources.Feeling_good_cat;
                pictureBox1.Refresh();
            }

            if (progressBar1.Value >= 25 && progressBar1.Value < 50)
            {
                pictureBox1.Image = Properties.Resources.Not_so_ok_cat;
                pictureBox1.Refresh();
            }

            if (progressBar1.Value >= 1 && progressBar1.Value < 25)
            {
                pictureBox1.Image = Properties.Resources.Sad_cat;
                pictureBox1.Refresh();
            }

            if (progressBar1.Value == 0 )
            {
                pictureBox1.Image = Properties.Resources.Figaro_is_dead;
                pictureBox1.Refresh();
            }
        }

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }
    }
}
