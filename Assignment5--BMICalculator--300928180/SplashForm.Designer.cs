﻿namespace Assignment5__BMICalculator__300928180
{
    partial class SplashForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SplashFormTimer = new System.Windows.Forms.Timer(this.components);
            this.WelcomeLable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SplashFormTimer
            // 
            this.SplashFormTimer.Enabled = true;
            this.SplashFormTimer.Interval = 3000;
            this.SplashFormTimer.Tick += new System.EventHandler(this.SplashFormTimer_Tick);
            // 
            // WelcomeLable
            // 
            this.WelcomeLable.AutoSize = true;
            this.WelcomeLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.WelcomeLable.Location = new System.Drawing.Point(2, 55);
            this.WelcomeLable.Name = "WelcomeLable";
            this.WelcomeLable.Size = new System.Drawing.Size(290, 62);
            this.WelcomeLable.TabIndex = 0;
            this.WelcomeLable.Text = "Welcome to \r\nmy BMI Calculator App\r\n";
            this.WelcomeLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WelcomeLable.Click += new System.EventHandler(this.WelcomeLable_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assignment5__BMICalculator__300928180.Properties.Resources.BMIImage;
            this.pictureBox1.Location = new System.Drawing.Point(21, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 256);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // SplashForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.WelcomeLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer SplashFormTimer;
        private System.Windows.Forms.Label WelcomeLable;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}