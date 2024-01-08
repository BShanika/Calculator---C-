namespace WindowsFormsAppCalculator
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_Multi = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_Plus = new System.Windows.Forms.Button();
            this.button_Mins = new System.Windows.Forms.Button();
            this.button_Divide = new System.Windows.Forms.Button();
            this.button_Point = new System.Windows.Forms.Button();
            this.button_Equal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button_Equal);
            this.panel2.Controls.Add(this.button_Point);
            this.panel2.Controls.Add(this.button_Divide);
            this.panel2.Controls.Add(this.button_Mins);
            this.panel2.Controls.Add(this.button_Plus);
            this.panel2.Controls.Add(this.button_0);
            this.panel2.Controls.Add(this.button_Multi);
            this.panel2.Controls.Add(this.button_3);
            this.panel2.Controls.Add(this.button_2);
            this.panel2.Controls.Add(this.button_1);
            this.panel2.Controls.Add(this.button_Delete);
            this.panel2.Controls.Add(this.button_6);
            this.panel2.Controls.Add(this.button_5);
            this.panel2.Controls.Add(this.button_4);
            this.panel2.Controls.Add(this.button_Clear);
            this.panel2.Controls.Add(this.button_9);
            this.panel2.Controls.Add(this.button_8);
            this.panel2.Controls.Add(this.button_7);
            this.panel2.Controls.Add(this.textBox_Result);
            this.panel2.Location = new System.Drawing.Point(16, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 460);
            this.panel2.TabIndex = 0;
            // 
            // textBox_Result
            // 
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Result.Location = new System.Drawing.Point(16, 26);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(230, 58);
            this.textBox_Result.TabIndex = 0;
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Result.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_7
            // 
            this.button_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_7.Location = new System.Drawing.Point(16, 130);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(45, 38);
            this.button_7.TabIndex = 1;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_8
            // 
            this.button_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_8.Location = new System.Drawing.Point(77, 130);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(45, 38);
            this.button_8.TabIndex = 2;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_9
            // 
            this.button_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_9.Location = new System.Drawing.Point(137, 130);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(45, 38);
            this.button_9.TabIndex = 3;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.Location = new System.Drawing.Point(201, 192);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(45, 38);
            this.button_Clear.TabIndex = 4;
            this.button_Clear.Text = "C";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_4
            // 
            this.button_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_4.Location = new System.Drawing.Point(16, 192);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(45, 38);
            this.button_4.TabIndex = 5;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_5
            // 
            this.button_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_5.Location = new System.Drawing.Point(77, 192);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(45, 38);
            this.button_5.TabIndex = 6;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_6
            // 
            this.button_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_6.Location = new System.Drawing.Point(137, 192);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(45, 38);
            this.button_6.TabIndex = 7;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(16, 380);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(45, 38);
            this.button_Delete.TabIndex = 8;
            this.button_Delete.Text = "Del";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_1
            // 
            this.button_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_1.Location = new System.Drawing.Point(16, 254);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(45, 38);
            this.button_1.TabIndex = 9;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_2
            // 
            this.button_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_2.Location = new System.Drawing.Point(77, 254);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(45, 38);
            this.button_2.TabIndex = 10;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_3
            // 
            this.button_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_3.Location = new System.Drawing.Point(137, 254);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(45, 38);
            this.button_3.TabIndex = 11;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_Multi
            // 
            this.button_Multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Multi.Location = new System.Drawing.Point(201, 254);
            this.button_Multi.Name = "button_Multi";
            this.button_Multi.Size = new System.Drawing.Size(45, 38);
            this.button_Multi.TabIndex = 12;
            this.button_Multi.Text = "x";
            this.button_Multi.UseVisualStyleBackColor = true;
            this.button_Multi.Click += new System.EventHandler(this.button_Multi_Click);
            // 
            // button_0
            // 
            this.button_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_0.Location = new System.Drawing.Point(16, 320);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(45, 38);
            this.button_0.TabIndex = 13;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_Plus
            // 
            this.button_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Plus.Location = new System.Drawing.Point(77, 320);
            this.button_Plus.Name = "button_Plus";
            this.button_Plus.Size = new System.Drawing.Size(45, 38);
            this.button_Plus.TabIndex = 14;
            this.button_Plus.Text = "+";
            this.button_Plus.UseVisualStyleBackColor = true;
            this.button_Plus.Click += new System.EventHandler(this.button_Plus_Click);
            // 
            // button_Mins
            // 
            this.button_Mins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Mins.Location = new System.Drawing.Point(137, 320);
            this.button_Mins.Name = "button_Mins";
            this.button_Mins.Size = new System.Drawing.Size(45, 38);
            this.button_Mins.TabIndex = 15;
            this.button_Mins.Text = "-";
            this.button_Mins.UseVisualStyleBackColor = true;
            this.button_Mins.Click += new System.EventHandler(this.button_Mins_Click);
            // 
            // button_Divide
            // 
            this.button_Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Divide.Location = new System.Drawing.Point(201, 320);
            this.button_Divide.Name = "button_Divide";
            this.button_Divide.Size = new System.Drawing.Size(45, 38);
            this.button_Divide.TabIndex = 16;
            this.button_Divide.Text = "/";
            this.button_Divide.UseVisualStyleBackColor = true;
            this.button_Divide.Click += new System.EventHandler(this.button_Divide_Click);
            // 
            // button_Point
            // 
            this.button_Point.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Point.Location = new System.Drawing.Point(77, 380);
            this.button_Point.Name = "button_Point";
            this.button_Point.Size = new System.Drawing.Size(45, 38);
            this.button_Point.TabIndex = 18;
            this.button_Point.Text = ".";
            this.button_Point.UseVisualStyleBackColor = true;
            this.button_Point.Click += new System.EventHandler(this.button_Point_Click);
            // 
            // button_Equal
            // 
            this.button_Equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Equal.Location = new System.Drawing.Point(137, 380);
            this.button_Equal.Name = "button_Equal";
            this.button_Equal.Size = new System.Drawing.Size(109, 38);
            this.button_Equal.TabIndex = 20;
            this.button_Equal.Text = "=";
            this.button_Equal.UseVisualStyleBackColor = true;
            this.button_Equal.Click += new System.EventHandler(this.button_Equal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::WindowsFormsAppCalculator.Properties.Resources._17009745942651;
            this.pictureBox1.Location = new System.Drawing.Point(201, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "CALCULATOR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 512);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 516);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Equal;
        private System.Windows.Forms.Button button_Point;
        private System.Windows.Forms.Button button_Divide;
        private System.Windows.Forms.Button button_Mins;
        private System.Windows.Forms.Button button_Plus;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_Multi;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

