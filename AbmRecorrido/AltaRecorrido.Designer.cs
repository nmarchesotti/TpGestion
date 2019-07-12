namespace FrbaCrucero.AbmRecorrido
{
    partial class AltaRecorrido
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
            this.label3 = new System.Windows.Forms.Label();
            this.DescripcionRecorrido = new System.Windows.Forms.TextBox();
            this.CodigoRecorrido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PrecioRecorrido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAltaRecorrido = new System.Windows.Forms.Button();
            this.btnMenuRecorrido = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Alta recorrido";
            // 
            // DescripcionRecorrido
            // 
            this.DescripcionRecorrido.Location = new System.Drawing.Point(402, 219);
            this.DescripcionRecorrido.Name = "DescripcionRecorrido";
            this.DescripcionRecorrido.Size = new System.Drawing.Size(237, 20);
            this.DescripcionRecorrido.TabIndex = 12;
            // 
            // CodigoRecorrido
            // 
            this.CodigoRecorrido.Location = new System.Drawing.Point(402, 140);
            this.CodigoRecorrido.Name = "CodigoRecorrido";
            this.CodigoRecorrido.Size = new System.Drawing.Size(237, 20);
            this.CodigoRecorrido.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "(*)Código del recorrido";
            // 
            // PrecioRecorrido
            // 
            this.PrecioRecorrido.Location = new System.Drawing.Point(402, 302);
            this.PrecioRecorrido.Name = "PrecioRecorrido";
            this.PrecioRecorrido.Size = new System.Drawing.Size(237, 20);
            this.PrecioRecorrido.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "(*)Precio";
            // 
            // btnAltaRecorrido
            // 
            this.btnAltaRecorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaRecorrido.Location = new System.Drawing.Point(311, 366);
            this.btnAltaRecorrido.Name = "btnAltaRecorrido";
            this.btnAltaRecorrido.Size = new System.Drawing.Size(151, 72);
            this.btnAltaRecorrido.TabIndex = 15;
            this.btnAltaRecorrido.Text = "Dar de alta";
            this.btnAltaRecorrido.UseVisualStyleBackColor = true;
            this.btnAltaRecorrido.Click += new System.EventHandler(this.btnAltaRecorrido_Click);
            // 
            // btnMenuRecorrido
            // 
            this.btnMenuRecorrido.Location = new System.Drawing.Point(686, 396);
            this.btnMenuRecorrido.Name = "btnMenuRecorrido";
            this.btnMenuRecorrido.Size = new System.Drawing.Size(102, 42);
            this.btnMenuRecorrido.TabIndex = 25;
            this.btnMenuRecorrido.Text = "Menu recorrido";
            this.btnMenuRecorrido.UseVisualStyleBackColor = true;
            this.btnMenuRecorrido.Click += new System.EventHandler(this.btnMenuRecorrido_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label6.Location = new System.Drawing.Point(491, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "(*)Campos Obligatorios";
            // 
            // AltaRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnMenuRecorrido);
            this.Controls.Add(this.btnAltaRecorrido);
            this.Controls.Add(this.PrecioRecorrido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DescripcionRecorrido);
            this.Controls.Add(this.CodigoRecorrido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "AltaRecorrido";
            this.Text = "NuevoRecorrido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescripcionRecorrido;
        private System.Windows.Forms.TextBox CodigoRecorrido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrecioRecorrido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAltaRecorrido;
        private System.Windows.Forms.Button btnMenuRecorrido;
        private System.Windows.Forms.Label label6;
    }
}