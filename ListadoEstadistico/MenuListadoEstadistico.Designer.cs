﻿namespace FrbaCrucero.ListadoEstadistico
{
    partial class MenuListadoEstadistico
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(396, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Top 5 recorridos con mas pasajes comprados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(396, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "Top 5 de los recorridos con más cabinas libres en cada uno de los viajes realizad" +
    "os. ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(199, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(396, 55);
            this.button3.TabIndex = 2;
            this.button3.Text = "Top 5 de los cruceros con mayor cantidad de días fuera de servicio. ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 44);
            this.button4.TabIndex = 13;
            this.button4.Text = "Menu principal";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MenuListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 350);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MenuListadoEstadistico";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}