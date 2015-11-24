namespace ManuMathews_ICA9
{
    partial class Color
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rbt_Blue = new System.Windows.Forms.RadioButton();
            this.Rbt_Green = new System.Windows.Forms.RadioButton();
            this.Rbt_Red = new System.Windows.Forms.RadioButton();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rbt_Blue);
            this.groupBox1.Controls.Add(this.Rbt_Green);
            this.groupBox1.Controls.Add(this.Rbt_Red);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 97);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // Rbt_Blue
            // 
            this.Rbt_Blue.AutoSize = true;
            this.Rbt_Blue.Location = new System.Drawing.Point(6, 65);
            this.Rbt_Blue.Name = "Rbt_Blue";
            this.Rbt_Blue.Size = new System.Drawing.Size(46, 17);
            this.Rbt_Blue.TabIndex = 4;
            this.Rbt_Blue.TabStop = true;
            this.Rbt_Blue.Text = "Blue";
            this.Rbt_Blue.UseVisualStyleBackColor = true;
            this.Rbt_Blue.CheckedChanged += new System.EventHandler(this.Rbt_Blue_CheckedChanged);
            // 
            // Rbt_Green
            // 
            this.Rbt_Green.AutoSize = true;
            this.Rbt_Green.Location = new System.Drawing.Point(6, 42);
            this.Rbt_Green.Name = "Rbt_Green";
            this.Rbt_Green.Size = new System.Drawing.Size(54, 17);
            this.Rbt_Green.TabIndex = 3;
            this.Rbt_Green.TabStop = true;
            this.Rbt_Green.Text = "Green";
            this.Rbt_Green.UseVisualStyleBackColor = true;
            this.Rbt_Green.CheckedChanged += new System.EventHandler(this.Rbt_Green_CheckedChanged);
            // 
            // Rbt_Red
            // 
            this.Rbt_Red.AutoSize = true;
            this.Rbt_Red.Location = new System.Drawing.Point(6, 19);
            this.Rbt_Red.Name = "Rbt_Red";
            this.Rbt_Red.Size = new System.Drawing.Size(45, 17);
            this.Rbt_Red.TabIndex = 2;
            this.Rbt_Red.TabStop = true;
            this.Rbt_Red.Text = "Red";
            this.Rbt_Red.UseVisualStyleBackColor = true;
            this.Rbt_Red.CheckedChanged += new System.EventHandler(this.Rbt_Red_CheckedChanged);
            // 
            // Btn_OK
            // 
            this.Btn_OK.Location = new System.Drawing.Point(12, 115);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(75, 23);
            this.Btn_OK.TabIndex = 2;
            this.Btn_OK.Text = "OK";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(104, 115);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 3;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Color
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 180);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Color";
            this.ShowInTaskbar = false;
            this.Text = "Color";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rbt_Blue;
        private System.Windows.Forms.RadioButton Rbt_Green;
        private System.Windows.Forms.RadioButton Rbt_Red;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}