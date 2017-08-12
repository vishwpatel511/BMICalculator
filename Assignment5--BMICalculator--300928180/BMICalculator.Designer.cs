namespace Assignment5__BMICalculator__300928180
{
    partial class BMICalculator
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
            this.AppLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.KgLable = new System.Windows.Forms.Label();
            this.MeterLable = new System.Windows.Forms.Label();
            this.MyHeightLable = new System.Windows.Forms.Label();
            this.DisplayResultLable = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.MyWeightLable = new System.Windows.Forms.Label();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.AppLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppLayout
            // 
            this.AppLayout.BackColor = System.Drawing.Color.GreenYellow;
            this.AppLayout.ColumnCount = 3;
            this.AppLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AppLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.07895F));
            this.AppLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.69737F));
            this.AppLayout.Controls.Add(this.MetricRadioButton, 0, 2);
            this.AppLayout.Controls.Add(this.ImperialRadioButton, 1, 2);
            this.AppLayout.Controls.Add(this.KgLable, 2, 4);
            this.AppLayout.Controls.Add(this.MeterLable, 2, 3);
            this.AppLayout.Controls.Add(this.MyHeightLable, 0, 3);
            this.AppLayout.Controls.Add(this.DisplayResultLable, 0, 1);
            this.AppLayout.Controls.Add(this.result, 0, 0);
            this.AppLayout.Controls.Add(this.MyWeightLable, 0, 4);
            this.AppLayout.Controls.Add(this.CalculateBMIButton, 1, 5);
            this.AppLayout.Controls.Add(this.WeightTextBox, 1, 4);
            this.AppLayout.Controls.Add(this.HeightTextBox, 1, 3);
            this.AppLayout.Location = new System.Drawing.Point(1, 1);
            this.AppLayout.Name = "AppLayout";
            this.AppLayout.RowCount = 7;
            this.AppLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AppLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AppLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.97674F));
            this.AppLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.93023F));
            this.AppLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.18605F));
            this.AppLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.651163F));
            this.AppLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AppLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AppLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AppLayout.Size = new System.Drawing.Size(304, 430);
            this.AppLayout.TabIndex = 0;
            this.AppLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.AppLayout_Paint);
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricRadioButton.Location = new System.Drawing.Point(3, 125);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(67, 22);
            this.MetricRadioButton.TabIndex = 1;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.Metric_CheckedChanged);
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialRadioButton.Location = new System.Drawing.Point(104, 125);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(81, 22);
            this.ImperialRadioButton.TabIndex = 7;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = " Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.Imperial_CheckedChanged);
            // 
            // KgLable
            // 
            this.KgLable.AutoSize = true;
            this.KgLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.KgLable.Location = new System.Drawing.Point(237, 242);
            this.KgLable.Name = "KgLable";
            this.KgLable.Size = new System.Drawing.Size(36, 20);
            this.KgLable.TabIndex = 5;
            this.KgLable.Text = "  kg";
            this.KgLable.Click += new System.EventHandler(this.WightUnits_Click);
            // 
            // MeterLable
            // 
            this.MeterLable.AutoSize = true;
            this.MeterLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeterLable.Location = new System.Drawing.Point(237, 195);
            this.MeterLable.Name = "MeterLable";
            this.MeterLable.Size = new System.Drawing.Size(58, 20);
            this.MeterLable.TabIndex = 4;
            this.MeterLable.Text = "  meter";
            this.MeterLable.Click += new System.EventHandler(this.HeightUnits_Click);
            // 
            // MyHeightLable
            // 
            this.MyHeightLable.AutoSize = true;
            this.MyHeightLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyHeightLable.Location = new System.Drawing.Point(3, 195);
            this.MyHeightLable.Name = "MyHeightLable";
            this.MyHeightLable.Size = new System.Drawing.Size(80, 20);
            this.MyHeightLable.TabIndex = 2;
            this.MyHeightLable.Text = "My Height";
            this.MyHeightLable.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // DisplayResultLable
            // 
            this.DisplayResultLable.BackColor = System.Drawing.Color.SpringGreen;
            this.DisplayResultLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AppLayout.SetColumnSpan(this.DisplayResultLable, 3);
            this.DisplayResultLable.Enabled = false;
            this.DisplayResultLable.Location = new System.Drawing.Point(3, 64);
            this.DisplayResultLable.Multiline = true;
            this.DisplayResultLable.Name = "DisplayResultLable";
            this.DisplayResultLable.ReadOnly = true;
            this.DisplayResultLable.Size = new System.Drawing.Size(294, 55);
            this.DisplayResultLable.TabIndex = 8;
            this.DisplayResultLable.TextChanged += new System.EventHandler(this.BMIResults_TextChanged);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.SpringGreen;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AppLayout.SetColumnSpan(this.result, 3);
            this.result.Enabled = false;
            this.result.Location = new System.Drawing.Point(3, 3);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(294, 55);
            this.result.TabIndex = 9;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.BackColor = System.Drawing.Color.Snow;
            this.HeightTextBox.Location = new System.Drawing.Point(104, 198);
            this.HeightTextBox.Multiline = true;
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(127, 41);
            this.HeightTextBox.TabIndex = 10;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightText_TextChanged);
            this.HeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightText_KeyPress);
            // 
            // MyWeightLable
            // 
            this.MyWeightLable.AutoSize = true;
            this.MyWeightLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyWeightLable.Location = new System.Drawing.Point(3, 242);
            this.MyWeightLable.Name = "MyWeightLable";
            this.MyWeightLable.Size = new System.Drawing.Size(83, 20);
            this.MyWeightLable.TabIndex = 3;
            this.MyWeightLable.Text = "My Weight";
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.BackColor = System.Drawing.Color.DarkOrange;
            this.AppLayout.SetColumnSpan(this.CalculateBMIButton, 3);
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CalculateBMIButton.Location = new System.Drawing.Point(3, 369);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(294, 58);
            this.CalculateBMIButton.TabIndex = 6;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            this.CalculateBMIButton.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.BackColor = System.Drawing.Color.White;
            this.WeightTextBox.Location = new System.Drawing.Point(104, 245);
            this.WeightTextBox.Multiline = true;
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(127, 41);
            this.WeightTextBox.TabIndex = 11;
            this.WeightTextBox.TextChanged += new System.EventHandler(this.WeightText_TextChanged);
            this.WeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WeightText_KeyPress);
            // 
            // BMICalculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.AppLayout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculator_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AppLayout.ResumeLayout(false);
            this.AppLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AppLayout;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.Label MyHeightLable;
        private System.Windows.Forms.Label MyWeightLable;
        private System.Windows.Forms.Label KgLable;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.TextBox DisplayResultLable;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label MeterLable;
    }
}