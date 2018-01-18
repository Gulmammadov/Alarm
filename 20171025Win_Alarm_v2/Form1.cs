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

namespace _20171025Win_Alarm_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Text = "Alarm işə düşdü";
        } 

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = true;
            textBox1.Text = DateTime.Now.ToShortDateString();
            textBox2.Text = DateTime.Now.ToLongTimeString();
            timer1.Interval = 1000;
            timer2.Interval = 100;
            Text = "ALARM";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {   
            if (textBox1.Text == DateTime.Now.ToShortDateString() && textBox2.Text == DateTime.Now.ToLongTimeString())
            {
                timer2.Enabled = true;
                textBox3.Text = "Vaxtdi";
            }
        }

        Color c;
        SystemSound s = SystemSounds.Exclamation;
        private void timer2_Tick(object sender, EventArgs e)
        {
            s.Play();
            c = textBox3.BackColor;
            textBox3.BackColor = textBox3.ForeColor;
            textBox3.ForeColor = c;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();
        }
    }
}
