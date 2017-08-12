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
    * Version: 0.2 Started SplashForm First
    */
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
        }
    }
}
