using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private int points;
        private int seconds;
        private Timer t1 = new Timer();

        public Form1()
        {
            label2.Text = "Time Left: 60"; 
            label1.Text = "Points: 0";
            points = 0;
            seconds = 60;
            InitializeComponent();

            t1.Tick += new EventHandler(Timer1_Tick);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            points++;
            label1.Text = "Points: " + points.ToString();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            seconds--;
        }
}
