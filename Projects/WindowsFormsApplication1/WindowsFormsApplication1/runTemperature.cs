using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class runTemperature : Form
    {
        // instance variables
        private Temperature myTemp;


        public runTemperature()
        {
            InitializeComponent();
            myTemp = new Temperature();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // get celsius from celsiusTxtBox
            double celsius = Double.Parse(Celsius.Text);
            // store ceslsius to myTemp -> get fahrenheit from myTemp + print in txtbox dos
            myTemp.setCelsius(celsius);
            double fahrenheit = myTemp.getFahrenheit();
            Fahrenheit.Text = fahrenheit.ToString();
        }

        private void Celsius_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
