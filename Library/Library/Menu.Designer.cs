﻿namespace Library
{
    partial class Menu
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "1. Create new member";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "2. Create new book";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(142, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "3. Borrow book";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(142, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(206, 44);
            this.button4.TabIndex = 3;
            this.button4.Text = "4. Return book";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(142, 277);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(206, 45);
            this.button5.TabIndex = 4;
            this.button5.Text = "5. Print Members";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(142, 345);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(206, 41);
            this.button6.TabIndex = 5;
            this.button6.Text = "6. Print books";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(142, 403);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(206, 42);
            this.button7.TabIndex = 6;
            this.button7.Text = "7. Print loans";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(142, 466);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(206, 44);
            this.button8.TabIndex = 7;
            this.button8.Text = "8. Quit";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 545);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}