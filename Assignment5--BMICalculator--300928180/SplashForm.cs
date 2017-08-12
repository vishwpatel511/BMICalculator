using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5__BMICalculator__300928180
{
    /*
* Name: Vishw Patel
* Student ID: 300928180
* Date Modified: August 11, 2017
* Description: Assignment 5 BMI Calculator
* Version: 0.4 Created public properties..
*/
    public partial class SplashForm : Form
    {

        // PROPERTIES....

        public BMICalculator bmiCalculator
        {
            get
            {
                return Program.bmiCalculator;
            }
        }
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// That's the event handler for the "Tick"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            this.bmiCalculator.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;   // turn the timer off after one tick..
        }

        private void WelcomeLable_Click(object sender, EventArgs e)
        {

        }
    }
}


      