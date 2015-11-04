namespace ManuMathews_ICA2
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.tb_HourlyRate = new System.Windows.Forms.TextBox();
            this.tb_HoursWorked = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_PayDue = new System.Windows.Forms.Label();
            this.lb_OvertimePay = new System.Windows.Forms.Label();
            this.lb_RegularPay = new System.Windows.Forms.Label();
            this.lb_OvertimeHours = new System.Windows.Forms.Label();
            this.lb_RegularHour = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_HourlyRate
            // 
            this.tb_HourlyRate.AcceptsReturn = true;
            this.tb_HourlyRate.Location = new System.Drawing.Point(133, 36);
            this.tb_HourlyRate.Name = "tb_HourlyRate";
            this.tb_HourlyRate.Size = new System.Drawing.Size(100, 20);
            this.tb_HourlyRate.TabIndex = 0;
            this.tb_HourlyRate.Click += new System.EventHandler(this.tb_HourlyRate_TextChanged);
            this.tb_HourlyRate.TextChanged += new System.EventHandler(this.tb_HourlyRate_TextChanged);
            // 
            // tb_HoursWorked
            // 
            this.tb_HoursWorked.Location = new System.Drawing.Point(133, 62);
            this.tb_HoursWorked.Name = "tb_HoursWorked";
            this.tb_HoursWorked.Size = new System.Drawing.Size(100, 20);
            this.tb_HoursWorked.TabIndex = 1;
            this.tb_HoursWorked.Click += new System.EventHandler(this.tb_HoursWorked_TextChanged);
            this.tb_HoursWorked.TextChanged += new System.EventHandler(this.tb_HoursWorked_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hourly Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hours Worked";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Regular Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Overtime Hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Regular Pay";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Overtime Pay";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Pay Due";
            // 
            // lb_PayDue
            // 
            this.lb_PayDue.AutoSize = true;
            this.lb_PayDue.Location = new System.Drawing.Point(166, 186);
            this.lb_PayDue.Name = "lb_PayDue";
            this.lb_PayDue.Size = new System.Drawing.Size(34, 13);
            this.lb_PayDue.TabIndex = 7;
            this.lb_PayDue.Text = "$0.00";
            // 
            // lb_OvertimePay
            // 
            this.lb_OvertimePay.AutoSize = true;
            this.lb_OvertimePay.Location = new System.Drawing.Point(166, 162);
            this.lb_OvertimePay.Name = "lb_OvertimePay";
            this.lb_OvertimePay.Size = new System.Drawing.Size(34, 13);
            this.lb_OvertimePay.TabIndex = 6;
            this.lb_OvertimePay.Text = "$0.00";
            // 
            // lb_RegularPay
            // 
            this.lb_RegularPay.AutoSize = true;
            this.lb_RegularPay.Location = new System.Drawing.Point(166, 146);
            this.lb_RegularPay.Name = "lb_RegularPay";
            this.lb_RegularPay.Size = new System.Drawing.Size(34, 13);
            this.lb_RegularPay.TabIndex = 5;
            this.lb_RegularPay.Text = "$0.00";
            // 
            // lb_OvertimeHours
            // 
            this.lb_OvertimeHours.AutoSize = true;
            this.lb_OvertimeHours.Location = new System.Drawing.Point(166, 130);
            this.lb_OvertimeHours.Name = "lb_OvertimeHours";
            this.lb_OvertimeHours.Size = new System.Drawing.Size(22, 13);
            this.lb_OvertimeHours.TabIndex = 4;
            this.lb_OvertimeHours.Text = "0.0";
            // 
            // lb_RegularHour
            // 
            this.lb_RegularHour.AutoSize = true;
            this.lb_RegularHour.Location = new System.Drawing.Point(166, 115);
            this.lb_RegularHour.Name = "lb_RegularHour";
            this.lb_RegularHour.Size = new System.Drawing.Size(22, 13);
            this.lb_RegularHour.TabIndex = 3;
            this.lb_RegularHour.Text = "0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lb_PayDue);
            this.Controls.Add(this.lb_OvertimePay);
            this.Controls.Add(this.lb_RegularPay);
            this.Controls.Add(this.lb_OvertimeHours);
            this.Controls.Add(this.lb_RegularHour);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_HoursWorked);
            this.Controls.Add(this.tb_HourlyRate);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Pay Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_HourlyRate;
        private System.Windows.Forms.TextBox tb_HoursWorked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_PayDue;
        private System.Windows.Forms.Label lb_OvertimePay;
        private System.Windows.Forms.Label lb_RegularPay;
        private System.Windows.Forms.Label lb_OvertimeHours;
        private System.Windows.Forms.Label lb_RegularHour;
    }
}

