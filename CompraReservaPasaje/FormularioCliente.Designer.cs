﻿namespace FrbaCrucero.CompraReservaPasaje
{
    partial class FormularioCliente
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
            this.label5 = new System.Windows.Forms.Label();
            this.buttonComprar = new System.Windows.Forms.Button();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonReservar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(170, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Datos del Cliente";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // buttonComprar
            // 
            this.buttonComprar.Location = new System.Drawing.Point(61, 276);
            this.buttonComprar.Name = "buttonComprar";
            this.buttonComprar.Size = new System.Drawing.Size(102, 54);
            this.buttonComprar.TabIndex = 32;
            this.buttonComprar.Text = "Comprar";
            this.buttonComprar.UseVisualStyleBackColor = true;
            this.buttonComprar.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(278, 55);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(179, 20);
            this.textBoxDni.TabIndex = 28;
            this.textBoxDni.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label7.Location = new System.Drawing.Point(103, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "DNI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(514, 173);
            this.dataGridView1.TabIndex = 33;
            // 
            // buttonReservar
            // 
            this.buttonReservar.Location = new System.Drawing.Point(355, 276);
            this.buttonReservar.Name = "buttonReservar";
            this.buttonReservar.Size = new System.Drawing.Size(102, 54);
            this.buttonReservar.TabIndex = 34;
            this.buttonReservar.Text = "Reservar";
            this.buttonReservar.UseVisualStyleBackColor = true;
            this.buttonReservar.Click += new System.EventHandler(this.buttonReservar_Click);
            // 
            // FormularioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 338);
            this.Controls.Add(this.buttonReservar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonComprar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDni);
            this.Controls.Add(this.label5);
            this.Name = "FormularioCliente";
            this.Text = "FormularioCliente";
            this.Load += new System.EventHandler(this.FormularioCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonComprar;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonReservar;
    }
}