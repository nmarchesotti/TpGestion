namespace FrbaCrucero.AbmRecorrido
{
    partial class BajaRecorrido
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBajaRecorrido = new System.Windows.Forms.Button();
            this.comboBoxReco = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(282, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Baja recorrido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Código del recorrido";
            // 
            // btnBajaRecorrido
            // 
            this.btnBajaRecorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaRecorrido.Location = new System.Drawing.Point(310, 289);
            this.btnBajaRecorrido.Name = "btnBajaRecorrido";
            this.btnBajaRecorrido.Size = new System.Drawing.Size(151, 72);
            this.btnBajaRecorrido.TabIndex = 21;
            this.btnBajaRecorrido.Text = "Dar de baja";
            this.btnBajaRecorrido.UseVisualStyleBackColor = true;
            this.btnBajaRecorrido.Click += new System.EventHandler(this.btnBajaRecorrido_Click);
            // 
            // comboBoxReco
            // 
            this.comboBoxReco.FormattingEnabled = true;
            this.comboBoxReco.Location = new System.Drawing.Point(450, 179);
            this.comboBoxReco.Name = "comboBoxReco";
            this.comboBoxReco.Size = new System.Drawing.Size(212, 21);
            this.comboBoxReco.TabIndex = 22;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(691, 385);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 53);
            this.button3.TabIndex = 23;
            this.button3.Text = "Menu recorrido";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BajaRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBoxReco);
            this.Controls.Add(this.btnBajaRecorrido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "BajaRecorrido";
            this.Text = "BajaRecorrido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBajaRecorrido;
        private System.Windows.Forms.ComboBox comboBoxReco;
        private System.Windows.Forms.Button button3;
    }
}