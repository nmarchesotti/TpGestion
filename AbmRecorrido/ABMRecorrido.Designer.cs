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
            this.btnAltaRecorrido.Location = new System.Drawing.Point(224, 97);
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
            this.btnBajaRecorrido.Location = new System.Drawing.Point(224, 173);
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
            this.btnModificarRecorrido.Location = new System.Drawing.Point(224, 248);
            this.btnModificarRecorrido.Name = "btnModificarRecorrido";
            this.btnModificarRecorrido.Size = new System.Drawing.Size(238, 36);
            this.btnModificarRecorrido.TabIndex = 11;
            this.btnModificarRecorrido.Text = "Modificar recorrido";
            this.btnModificarRecorrido.UseVisualStyleBackColor = true;
            this.btnModificarRecorrido.Click += new System.EventHandler(this.btnModificarRecorrido_Click);
            // 
            // ABMRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 389);
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

    }
}