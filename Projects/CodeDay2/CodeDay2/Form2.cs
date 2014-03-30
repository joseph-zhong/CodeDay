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
    public partial class Form2 : Form
    {

        private static int points;
        public Form2()
        {
            points = 0;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            points++;
            label2.Text = points.ToString();
        }
    }
}
