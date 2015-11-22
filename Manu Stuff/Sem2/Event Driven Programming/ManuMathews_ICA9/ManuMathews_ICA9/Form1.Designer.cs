namespace ManuMathews_ICA9
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
            this.Btn_Size = new System.Windows.Forms.Button();
            this.Btn_Color = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Size
            // 
            this.Btn_Size.Location = new System.Drawing.Point(12, 12);
            this.Btn_Size.Name = "Btn_Size";
            this.Btn_Size.Size = new System.Drawing.Size(75, 23);
            this.Btn_Size.TabIndex = 0;
            this.Btn_Size.Text = "Size";
            this.Btn_Size.UseVisualStyleBackColor = true;
            this.Btn_Size.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Color
            // 
            this.Btn_Color.Location = new System.Drawing.Point(12, 41);
            this.Btn_Color.Name = "Btn_Color";
            this.Btn_Color.Size = new System.Drawing.Size(75, 23);
            this.Btn_Color.TabIndex = 1;
            this.Btn_Color.Text = "Color";
            this.Btn_Color.UseVisualStyleBackColor = true;
            this.Btn_Color.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 77);
            this.Controls.Add(this.Btn_Color);
            this.Controls.Add(this.Btn_Size);
            this.Name = "Form1";
            this.Text = "ICA8";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Size;
        private System.Windows.Forms.Button Btn_Color;
    }
}

