﻿namespace Libreria
{
    partial class Main
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
            this.Searching = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Peliculas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "Actores";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(209, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 24);
            this.button3.TabIndex = 2;
            this.button3.Text = "Directores";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(300, 91);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 24);
            this.button4.TabIndex = 3;
            this.button4.Text = "Productores";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(391, 91);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 24);
            this.button5.TabIndex = 4;
            this.button5.Text = "Estudios";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Searching
            // 
            this.Searching.Location = new System.Drawing.Point(28, 51);
            this.Searching.Name = "Searching";
            this.Searching.Size = new System.Drawing.Size(539, 20);
            this.Searching.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(640, 203);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(38, 24);
            this.button6.TabIndex = 6;
            this.button6.Text = "Salir";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(573, 51);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 20);
            this.button7.TabIndex = 7;
            this.button7.Text = "Buscar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(28, 151);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(126, 21);
            this.ComboBox.TabIndex = 8;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(166, 148);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(38, 24);
            this.button8.TabIndex = 9;
            this.button8.Text = "Ver";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Seleccione:";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(279, 148);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(197, 24);
            this.button9.TabIndex = 11;
            this.button9.Text = "Criticar Pelicula";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 239);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Searching);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox Searching;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button9;
    }
}