using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodeDay
{

    public partial class Form1 : Form
    {

        DateTime startTime;
        TimeSpan stoppedTime;
        DateTime stopTime;

        private static DateTime dateTime = DateTime.Now;

        private static int sec = dateTime.Second;

        private int counterWin = 0;
        
        private int timer = 60;

        private Random gen = new Random();

        public Form1()
        {



            InitializeComponent();

            // initial to running state
                startTime = DateTime.Now;
                stoppedTime = new TimeSpan(0);
                timDisplay.Enabled = true;
                btnStartStop.Text = "Stop";
                btnExit.Enabled = false;
                TimeSpan diff = DateTime.Now - startTime;

            label2.Text = (timer - sec).ToString();
            if (label2.Text == "0")
            {
                this.Close();
                // running to stopped state
                stopTime = DateTime.Now;
                timDisplay.Enabled = false;
                btnStartStop.Text = "Restart";
                btnReset.Enabled = true;
                btnExit.Enabled = true;
            }
        }

        private string HMS(TimeSpan t)
        {
            string hs, ms, ss;
            // Break time down into hours, minutes, and seconds
            hs = t.Hours.ToString();
            ms = t.Minutes.ToString();
            ss = t.Seconds.ToString();
            if (t.Hours < 10) // output into the one's digit
                hs = "0" + hs;
            if (t.Minutes < 10)
                ms = "0" + ms;
            if (t.Seconds < 10)
                ss = "0" + ss;
            return (hs + ":" + ms + ":" + ss);
        }

        private void timDisplay_Tick(object sender, EventArgs e)
        {
            TimeSpan totalTime;
            TimeSpan runningTime;
            // Determine total and running times in seconds
            totalTime = DateTime.Now - startTime;
            runningTime = totalTime - stoppedTime;
            // Display times
            label2.Text = HMS(totalTime);
            label3.Text = HMS(runningTime);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // return to initial state
            label2.Text = "00:00:00";
            label3.Text = "00:00:00";
            //btnStartStop.Text = "Start";
            //btnReset.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counterWin ++;
            label1.Text = counterWin.ToString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       


}
