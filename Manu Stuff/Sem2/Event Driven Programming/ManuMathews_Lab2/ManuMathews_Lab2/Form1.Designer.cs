namespace ManuMathews_Lab2
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
            this.components = new System.ComponentModel.Container();
            this.btn_NewPattern = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Draw = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Cycle = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_NewPattern
            // 
            this.btn_NewPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewPattern.Location = new System.Drawing.Point(98, 27);
            this.btn_NewPattern.Name = "btn_NewPattern";
            this.btn_NewPattern.Size = new System.Drawing.Size(97, 23);
            this.btn_NewPattern.TabIndex = 0;
            this.btn_NewPattern.Text = "New Pattern";
            this.btn_NewPattern.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cycle:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(44, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btn_Draw
            // 
            this.btn_Draw.Location = new System.Drawing.Point(29, 185);
            this.btn_Draw.Name = "btn_Draw";
            this.btn_Draw.Size = new System.Drawing.Size(75, 23);
            this.btn_Draw.TabIndex = 3;
            this.btn_Draw.Text = "Draw";
            this.btn_Draw.UseVisualStyleBackColor = true;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(29, 217);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 4;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(111, 217);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 5;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            // 
            // btn_Cycle
            // 
            this.btn_Cycle.Location = new System.Drawing.Point(192, 217);
            this.btn_Cycle.Name = "btn_Cycle";
            this.btn_Cycle.Size = new System.Drawing.Size(75, 23);
            this.btn_Cycle.TabIndex = 6;
            this.btn_Cycle.Text = "Cycle";
            this.btn_Cycle.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 287);
            this.Controls.Add(this.btn_Cycle);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_Draw);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_NewPattern);
            this.Name = "Form1";
            this.Text = "Life";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NewPattern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Draw;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Cycle;
        private System.Windows.Forms.Timer timer1;
    }
}

