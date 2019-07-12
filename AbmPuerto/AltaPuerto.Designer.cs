namespace FrbaCrucero.AbmPuerto
{
    partial class AltaPuerto
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
            this.label2 = new System.Windows.Forms.Label();
            this.NombrePuerto = new System.Windows.Forms.TextBox();
            this.DescripcionPuerto = new System.Windows.Forms.TextBox();
            this.btnAltaPuerto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "(*)Nombre del puerto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // NombrePuerto
            // 
            this.NombrePuerto.Location = new System.Drawing.Point(349, 107);
            this.NombrePuerto.Name = "NombrePuerto";
            this.NombrePuerto.Size = new System.Drawing.Size(237, 20);
            this.NombrePuerto.TabIndex = 2;
            // 
            // DescripcionPuerto
            // 
            this.DescripcionPuerto.Location = new System.Drawing.Point(349, 222);
            this.DescripcionPuerto.Name = "DescripcionPuerto";
            this.DescripcionPuerto.Size = new System.Drawing.Size(237, 20);
            this.DescripcionPuerto.TabIndex = 3;
            // 
            // btnAltaPuerto
            // 
            this.btnAltaPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaPuerto.Location = new System.Drawing.Point(232, 321);
            this.btnAltaPuerto.Name = "btnAltaPuerto";
            this.btnAltaPuerto.Size = new System.Drawing.Size(163, 72);
            this.btnAltaPuerto.TabIndex = 4;
            this.btnAltaPuerto.Text = "Dar de alta";
            this.btnAltaPuerto.UseVisualStyleBackColor = true;
            this.btnAltaPuerto.Click += new System.EventHandler(this.btnAltaPuerto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Registro de nuevo puerto";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(528, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 54);
            this.button2.TabIndex = 24;
            this.button2.Text = "Menu puerto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label6.Location = new System.Drawing.Point(438, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "(*)Campos Obligatorios";
            // 
            // AltaPuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 508);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAltaPuerto);
            this.Controls.Add(this.DescripcionPuerto);
            this.Controls.Add(this.NombrePuerto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaPuerto";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombrePuerto;
        private System.Windows.Forms.TextBox DescripcionPuerto;
        private System.Windows.Forms.Button btnAltaPuerto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}