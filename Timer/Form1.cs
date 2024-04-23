using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "00";
            label2.Text = "00";
            label3.Text = "00";
        }

        int hundradelar = 0;
        int sekunder = 0;
        int minuter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            hundradelar++;
            label1.Text = hundradelar.ToString();

            if (hundradelar > 99)
            {
                hundradelar = 0;
                sekunder++;
                label2.Text = sekunder.ToString();
            }

            if (sekunder > 59)
            {
                sekunder = 0;
                minuter++;
                label3.Text = minuter.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(minuter + ":" + sekunder + ":" + hundradelar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hundradelar = 0;
            sekunder = 0;
            minuter = 0;
            
            listBox1.Items.Clear();

            label1.Text = hundradelar.ToString();
            label2.Text = sekunder.ToString();
            label3.Text = minuter.ToString();
        }
    }
}
