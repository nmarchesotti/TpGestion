namespace FrbaCrucero.AbmCrucero
{
    partial class DecisionBajaCrucero
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
            this.txtDisponibilidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "¿Que desea hacer?";
            // 
            // txtDisponibilidad
            // 
            this.txtDisponibilidad.AutoSize = true;
            this.txtDisponibilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisponibilidad.Location = new System.Drawing.Point(32, 473);
            this.txtDisponibilidad.Name = "txtDisponibilidad";
            this.txtDisponibilidad.Size = new System.Drawing.Size(232, 29);
            this.txtDisponibilidad.TabIndex = 19;
            this.txtDisponibilidad.Text = "Baja de un crucero";
            // 
            // DecisionBajaCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 530);
            this.Controls.Add(this.txtDisponibilidad);
            this.Controls.Add(this.label5);
            this.Name = "DecisionBajaCrucero";
            this.Text = "DecisionBajaCrucero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtDisponibilidad;
    }
}