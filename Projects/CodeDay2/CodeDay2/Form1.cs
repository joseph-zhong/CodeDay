using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodeDay2
{
    

    public partial class Form1 : Form
    {
        //instance variables
        private int pointCounter = 0;
        private Random gen = new Random();

        private int maxX;
        private int maxY;
        private int setX;
        private int setY;

        private int xLocation;
        private int yLocation;

        Timer timer = new Timer();
        private int seconds = 60;
        private int minutes;
        private int hours;

        Timer timer2 = new Timer();
        private int pass = 0;

        //VERSION 2
        private bool work;
        

        public Form1()
        {
            InitializeComponent();
            //seconds = 0;
            //minutes = 0;
            //hours = 0;

            xLocation = gen.Next(640);
            yLocation = gen.Next(480);

            //setX = gen.Next

            //VERSION 2
            //seconds = 60;
            work = true;

            timer.Tick += new EventHandler(timer_Tick); // Everytime timer ticks, timer_Tick will be called
            timer.Interval = (1000);                    // Timer will tick evert 1 seconds
            timer.Start();

            
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (work == true)
            {
                //timer.Enabled = true;                       // Enable the timer
                
                pointCounter++;
                label1.Text = "Points: " + pointCounter.ToString();

                
            }
            
            
        }

        void timer_Tick(object sender, EventArgs e)
        {

            /*
             *  VERSION 1 COUNTS UPWARD
            seconds++;
            if(seconds == 60)
            {
                minutes++;
                seconds = 0;
            }
            if(minutes == 60)
            {
                minutes = 0;
                hours++;
            }
            label2.Text = "Timer: " + hours.ToString() + ":" + minutes.ToString() + ":" + seconds.ToString();
            */
            
            seconds--;

            button1.Location = new Point(xLocation, yLocation);

            label2.Text = "Time Left: " + seconds.ToString();
            if (seconds == 0)
            {
                work = false; 
                timer.Stop();
            }

        }

        

        
    }
}
