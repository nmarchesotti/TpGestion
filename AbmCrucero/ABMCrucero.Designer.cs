namespace FrbaCrucero.AbmCrucero
{
    partial class ABMCrucero
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
            this.btnABMModificarCrucero = new System.Windows.Forms.Button();
            this.btnABMBajaCrucero = new System.Windows.Forms.Button();
            this.btnABMAltaCrucero = new System.Windows.Forms.Button();
            this.btnListaCruceros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cruceros";
            // 
            // btnABMModificarCrucero
            // 
            this.btnABMModificarCrucero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABMModificarCrucero.Location = new System.Drawing.Point(167, 273);
            this.btnABMModificarCrucero.Name = "btnABMModificarCrucero";
            this.btnABMModificarCrucero.Size = new System.Drawing.Size(321, 49);
            this.btnABMModificarCrucero.TabIndex = 8;
            this.btnABMModificarCrucero.Text = "Modificar crucero";
            this.btnABMModificarCrucero.UseVisualStyleBackColor = true;
            this.btnABMModificarCrucero.Click += new System.EventHandler(this.btnABMModificarCrucero_Click);
            // 
            // btnABMBajaCrucero
            // 
            this.btnABMBajaCrucero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABMBajaCrucero.Location = new System.Drawing.Point(167, 191);
            this.btnABMBajaCrucero.Name = "btnABMBajaCrucero";
            this.btnABMBajaCrucero.Size = new System.Drawing.Size(321, 49);
            this.btnABMBajaCrucero.TabIndex = 9;
            this.btnABMBajaCrucero.Text = "Baja crucero";
            this.btnABMBajaCrucero.UseVisualStyleBackColor = true;
            this.btnABMBajaCrucero.Click += new System.EventHandler(this.btnABMBajaCrucero_Click);
            // 
            // btnABMAltaCrucero
            // 
            this.btnABMAltaCrucero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABMAltaCrucero.Location = new System.Drawing.Point(167, 111);
            this.btnABMAltaCrucero.Name = "btnABMAltaCrucero";
            this.btnABMAltaCrucero.Size = new System.Drawing.Size(321, 49);
            this.btnABMAltaCrucero.TabIndex = 10;
            this.btnABMAltaCrucero.Text = "Alta crucero";
            this.btnABMAltaCrucero.UseVisualStyleBackColor = true;
            this.btnABMAltaCrucero.Click += new System.EventHandler(this.btnABMAltaCrucero_Click);
            // 
            // btnListaCruceros
            // 
            this.btnListaCruceros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaCruceros.Location = new System.Drawing.Point(167, 355);
            this.btnListaCruceros.Name = "btnListaCruceros";
            this.btnListaCruceros.Size = new System.Drawing.Size(321, 49);
            this.btnListaCruceros.TabIndex = 11;
            this.btnListaCruceros.Text = "Lista de cruceros";
            this.btnListaCruceros.UseVisualStyleBackColor = true;
            this.btnListaCruceros.Click += new System.EventHandler(this.btnListaCruceros_Click);
            // 
            // ABMCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 486);
            this.Controls.Add(this.btnListaCruceros);
            this.Controls.Add(this.btnABMAltaCrucero);
            this.Controls.Add(this.btnABMBajaCrucero);
            this.Controls.Add(this.btnABMModificarCrucero);
            this.Controls.Add(this.label3);
            this.Name = "ABMCrucero";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnABMModificarCrucero;
        private System.Windows.Forms.Button btnABMBajaCrucero;
        private System.Windows.Forms.Button btnABMAltaCrucero;
        private System.Windows.Forms.Button btnListaCruceros;
    }
}