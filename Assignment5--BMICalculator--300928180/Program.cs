using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5__BMICalculator__300928180
{
    /*
    * Name: Vishw Patel
    * Student ID: 300928180
    * Date Modified: August 11, 2017
    * Description: Assignment 5 
    * Version: 0.3 Created Instance of the bmiCalcutor object
    */
    public static class Program
    {
        // Create Reference to forms..
        public static BMICalculator bmiCalculator;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bmiCalculator = new BMICalculator();  // Intantiate a new object of type BMICalcutor 

            Application.Run(new SplashForm());
        }
    }
}
