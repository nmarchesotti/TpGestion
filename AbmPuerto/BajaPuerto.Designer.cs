﻿namespace FrbaCrucero.AbmPuerto
{
    partial class BajaPuerto
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBajaPuerto = new System.Windows.Forms.Button();
            this.comboBoxPuertos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puerto";
            // 
            // btnBajaPuerto
            // 
            this.btnBajaPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaPuerto.Location = new System.Drawing.Point(177, 259);
            this.btnBajaPuerto.Name = "btnBajaPuerto";
            this.btnBajaPuerto.Size = new System.Drawing.Size(158, 93);
            this.btnBajaPuerto.TabIndex = 2;
            this.btnBajaPuerto.Text = "Dar de baja";
            this.btnBajaPuerto.UseVisualStyleBackColor = true;
            this.btnBajaPuerto.Click += new System.EventHandler(this.btnBajaPuerto_Click);
            // 
            // comboBoxPuertos
            // 
            this.comboBoxPuertos.FormattingEnabled = true;
            this.comboBoxPuertos.Location = new System.Drawing.Point(210, 149);
            this.comboBoxPuertos.Name = "comboBoxPuertos";
            this.comboBoxPuertos.Size = new System.Drawing.Size(247, 21);
            this.comboBoxPuertos.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Eliminación de puerto";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 54);
            this.button2.TabIndex = 23;
            this.button2.Text = "Menu puerto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BajaPuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 397);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxPuertos);
            this.Controls.Add(this.btnBajaPuerto);
            this.Controls.Add(this.label1);
            this.Name = "BajaPuerto";
            this.Text = "l";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBajaPuerto;
        private System.Windows.Forms.ComboBox comboBoxPuertos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}