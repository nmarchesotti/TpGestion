namespace FrbaCrucero.AbmRecorrido
{
    partial class ModificarRecorrido
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
            this.btnCambiarTramo = new System.Windows.Forms.Button();
            this.comboBoxModifReco = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTramos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPuertoS = new System.Windows.Forms.ComboBox();
            this.comboBoxPuertoL = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Modificar recorrido";
            // 
            // btnCambiarTramo
            // 
            this.btnCambiarTramo.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnCambiarTramo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarTramo.Location = new System.Drawing.Point(176, 156);
            this.btnCambiarTramo.Name = "btnCambiarTramo";
            this.btnCambiarTramo.Size = new System.Drawing.Size(197, 42);
            this.btnCambiarTramo.TabIndex = 21;
            this.btnCambiarTramo.Text = "Listar tramos";
            this.btnCambiarTramo.UseVisualStyleBackColor = true;
            this.btnCambiarTramo.Click += new System.EventHandler(this.btnCambiarTramo_Click);
            // 
            // comboBoxModifReco
            // 
            this.comboBoxModifReco.FormattingEnabled = true;
            this.comboBoxModifReco.Location = new System.Drawing.Point(275, 97);
            this.comboBoxModifReco.Name = "comboBoxModifReco";
            this.comboBoxModifReco.Size = new System.Drawing.Size(212, 21);
            this.comboBoxModifReco.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Código del recorrido";
            // 
            // comboBoxTramos
            // 
            this.comboBoxTramos.FormattingEnabled = true;
            this.comboBoxTramos.Location = new System.Drawing.Point(275, 230);
            this.comboBoxTramos.Name = "comboBoxTramos";
            this.comboBoxTramos.Size = new System.Drawing.Size(212, 21);
            this.comboBoxTramos.TabIndex = 26;
            this.comboBoxTramos.Text = "Puerto salida - Puerto llegada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tramo a modificar";
            // 
            // comboBoxPuertoS
            // 
            this.comboBoxPuertoS.FormattingEnabled = true;
            this.comboBoxPuertoS.Location = new System.Drawing.Point(58, 308);
            this.comboBoxPuertoS.Name = "comboBoxPuertoS";
            this.comboBoxPuertoS.Size = new System.Drawing.Size(128, 21);
            this.comboBoxPuertoS.TabIndex = 28;
            // 
            // comboBoxPuertoL
            // 
            this.comboBoxPuertoL.FormattingEnabled = true;
            this.comboBoxPuertoL.Location = new System.Drawing.Point(359, 308);
            this.comboBoxPuertoL.Name = "comboBoxPuertoL";
            this.comboBoxPuertoL.Size = new System.Drawing.Size(128, 21);
            this.comboBoxPuertoL.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(199, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 42);
            this.button1.TabIndex = 30;
            this.button1.Text = "Cambiar tramo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nuevo puerto salida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(369, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nuevo puerto llegada:";
            // 
            // ModificarRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 431);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxPuertoL);
            this.Controls.Add(this.comboBoxPuertoS);
            this.Controls.Add(this.comboBoxTramos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxModifReco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCambiarTramo);
            this.Controls.Add(this.label5);
            this.Name = "ModificarRecorrido";
            this.Text = "ModificarRecorrido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCambiarTramo;
        private System.Windows.Forms.ComboBox comboBoxModifReco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTramos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPuertoS;
        private System.Windows.Forms.ComboBox comboBoxPuertoL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}