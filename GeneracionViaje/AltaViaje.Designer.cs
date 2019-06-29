namespace FrbaCrucero.GeneracionViaje
{
    partial class AltaViaje
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
            this.fechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaLlegada = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCruceros = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxRecorrido = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generar nuevo viaje";
            // 
            // fechaSalida
            // 
            this.fechaSalida.Location = new System.Drawing.Point(271, 126);
            this.fechaSalida.Name = "fechaSalida";
            this.fechaSalida.Size = new System.Drawing.Size(288, 20);
            this.fechaSalida.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de salida";
            // 
            // fechaLlegada
            // 
            this.fechaLlegada.Location = new System.Drawing.Point(271, 177);
            this.fechaLlegada.Name = "fechaLlegada";
            this.fechaLlegada.Size = new System.Drawing.Size(288, 20);
            this.fechaLlegada.TabIndex = 3;
            this.fechaLlegada.ValueChanged += new System.EventHandler(this.fechaLlegada_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de llegada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cruceros disponibles";
            // 
            // comboBoxCruceros
            // 
            this.comboBoxCruceros.FormattingEnabled = true;
            this.comboBoxCruceros.Location = new System.Drawing.Point(272, 240);
            this.comboBoxCruceros.Name = "comboBoxCruceros";
            this.comboBoxCruceros.Size = new System.Drawing.Size(286, 21);
            this.comboBoxCruceros.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Recorrido";
            // 
            // comboBoxRecorrido
            // 
            this.comboBoxRecorrido.FormattingEnabled = true;
            this.comboBoxRecorrido.Location = new System.Drawing.Point(271, 306);
            this.comboBoxRecorrido.Name = "comboBoxRecorrido";
            this.comboBoxRecorrido.Size = new System.Drawing.Size(286, 21);
            this.comboBoxRecorrido.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(166, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 71);
            this.button1.TabIndex = 9;
            this.button1.Text = "Generar nuevo viaje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(531, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 60);
            this.button2.TabIndex = 10;
            this.button2.Text = "Menu viaje";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AltaViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 525);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxRecorrido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxCruceros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fechaLlegada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fechaSalida);
            this.Controls.Add(this.label1);
            this.Name = "AltaViaje";
            this.Text = "AltaViaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaSalida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaLlegada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCruceros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxRecorrido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}