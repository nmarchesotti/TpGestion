namespace FrbaCrucero.AbmPuerto
{
    partial class ABMPuerto
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
            this.btnABMModificarPuerto = new System.Windows.Forms.Button();
            this.btnABMBajaPuerto = new System.Windows.Forms.Button();
            this.btnABMAltaPuerto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnListado = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnABMModificarPuerto
            // 
            this.btnABMModificarPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABMModificarPuerto.Location = new System.Drawing.Point(239, 292);
            this.btnABMModificarPuerto.Name = "btnABMModificarPuerto";
            this.btnABMModificarPuerto.Size = new System.Drawing.Size(321, 49);
            this.btnABMModificarPuerto.TabIndex = 5;
            this.btnABMModificarPuerto.Text = "Modificar puerto";
            this.btnABMModificarPuerto.UseVisualStyleBackColor = true;
            this.btnABMModificarPuerto.Click += new System.EventHandler(this.btnABMModificarPuerto_Click);
            // 
            // btnABMBajaPuerto
            // 
            this.btnABMBajaPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABMBajaPuerto.Location = new System.Drawing.Point(239, 212);
            this.btnABMBajaPuerto.Name = "btnABMBajaPuerto";
            this.btnABMBajaPuerto.Size = new System.Drawing.Size(321, 49);
            this.btnABMBajaPuerto.TabIndex = 4;
            this.btnABMBajaPuerto.Text = "Baja puerto";
            this.btnABMBajaPuerto.UseVisualStyleBackColor = true;
            this.btnABMBajaPuerto.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnABMAltaPuerto
            // 
            this.btnABMAltaPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABMAltaPuerto.Location = new System.Drawing.Point(239, 129);
            this.btnABMAltaPuerto.Name = "btnABMAltaPuerto";
            this.btnABMAltaPuerto.Size = new System.Drawing.Size(321, 49);
            this.btnABMAltaPuerto.TabIndex = 3;
            this.btnABMAltaPuerto.Text = "Alta puerto";
            this.btnABMAltaPuerto.UseVisualStyleBackColor = true;
            this.btnABMAltaPuerto.Click += new System.EventHandler(this.btnABMAltaPuerto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Puertos";
            // 
            // btnListado
            // 
            this.btnListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListado.Location = new System.Drawing.Point(239, 372);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(321, 49);
            this.btnListado.TabIndex = 7;
            this.btnListado.Text = "Listado de puertos";
            this.btnListado.UseVisualStyleBackColor = true;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Menu principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ABMPuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnListado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnABMModificarPuerto);
            this.Controls.Add(this.btnABMBajaPuerto);
            this.Controls.Add(this.btnABMAltaPuerto);
            this.Name = "ABMPuerto";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnABMModificarPuerto;
        private System.Windows.Forms.Button btnABMBajaPuerto;
        private System.Windows.Forms.Button btnABMAltaPuerto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.Button button1;
    }
}