using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodeDay4
{
    public partial class Form1 : Form
    {
        private int cursorLocationY;
        private int cursorLocationX;

        private int buttonLocationY;
        private int buttonLocationX;

        public Form1()
        {
            InitializeComponent();

            buttonLocationX = button1.Location.X;
            buttonLocationY = button1.Location.Y;

            cursorLocationX = Cursor.Position.X;
            cursorLocationY = Cursor.Position.Y;

            label1.Text = "X: " + cursorLocationX.ToString() 
                + "Y: " + cursorLocationY.ToString();

            while (true)
            {
                updateMouse();
            }



            //button1.Location = new Point(button1.Location.X + 20, button1.Location.Y + 20);
        }

        void updateMouse()
        {
            //while (true)
            {
                cursorLocationX = Cursor.Position.X;
                cursorLocationY = Cursor.Position.Y;

                label1.Text = "X: " + cursorLocationX.ToString() + "Y: " 
                    + cursorLocationY.ToString();
            }

            if (button1.Location.X == cursorLocationX)
            {
                if ((button1.Location.Y - cursorLocationY) == 20)
                {
                    button1.Location = new Point(button1.Location.X, button1.Location.Y - 20);
                }
                else if ((button1.Location.Y - cursorLocationY) == -20)
                {
                    button1.Location = new Point(button1.Location.X, button1.Location.Y + 20);
                }
            }
            button1.Location = new Point(cursorLocationX + 20, cursorLocationY + 20);
        }
        
    }
}
