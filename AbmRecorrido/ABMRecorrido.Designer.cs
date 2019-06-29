namespace FrbaCrucero.AbmRecorrido
{
    partial class ABMRecorrido
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
            this.btnAltaRecorrido = new System.Windows.Forms.Button();
            this.btnBajaRecorrido = new System.Windows.Forms.Button();
            this.btnModificarRecorrido = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Recorridos";
            // 
            // btnAltaRecorrido
            // 
            this.btnAltaRecorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaRecorrido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAltaRecorrido.Location = new System.Drawing.Point(224, 62);
            this.btnAltaRecorrido.Name = "btnAltaRecorrido";
            this.btnAltaRecorrido.Size = new System.Drawing.Size(238, 36);
            this.btnAltaRecorrido.TabIndex = 8;
            this.btnAltaRecorrido.Text = "Alta recorrido";
            this.btnAltaRecorrido.UseVisualStyleBackColor = true;
            this.btnAltaRecorrido.Click += new System.EventHandler(this.btnAltaRecorrido_Click);
            // 
            // btnBajaRecorrido
            // 
            this.btnBajaRecorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaRecorrido.Location = new System.Drawing.Point(224, 122);
            this.btnBajaRecorrido.Name = "btnBajaRecorrido";
            this.btnBajaRecorrido.Size = new System.Drawing.Size(238, 32);
            this.btnBajaRecorrido.TabIndex = 9;
            this.btnBajaRecorrido.Text = "Baja recorrido";
            this.btnBajaRecorrido.UseVisualStyleBackColor = true;
            this.btnBajaRecorrido.Click += new System.EventHandler(this.btnBajaRecorrido_Click);
            // 
            // btnModificarRecorrido
            // 
            this.btnModificarRecorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarRecorrido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModificarRecorrido.Location = new System.Drawing.Point(224, 179);
            this.btnModificarRecorrido.Name = "btnModificarRecorrido";
            this.btnModificarRecorrido.Size = new System.Drawing.Size(238, 36);
            this.btnModificarRecorrido.TabIndex = 11;
            this.btnModificarRecorrido.Text = "Modificar recorrido";
            this.btnModificarRecorrido.UseVisualStyleBackColor = true;
            this.btnModificarRecorrido.Click += new System.EventHandler(this.btnModificarRecorrido_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(557, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 53);
            this.button3.TabIndex = 15;
            this.button3.Text = "Menu principal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(224, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Listado de recorridos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(224, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 36);
            this.button2.TabIndex = 17;
            this.button2.Text = "Información de recorridos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ABMRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 389);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnModificarRecorrido);
            this.Controls.Add(this.btnBajaRecorrido);
            this.Controls.Add(this.btnAltaRecorrido);
            this.Controls.Add(this.label3);
            this.Name = "ABMRecorrido";
            this.Text = "ABMRecorrido";
            this.Load += new System.EventHandler(this.ABMRecorrido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAltaRecorrido;
        private System.Windows.Forms.Button btnBajaRecorrido;
        private System.Windows.Forms.Button btnModificarRecorrido;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}