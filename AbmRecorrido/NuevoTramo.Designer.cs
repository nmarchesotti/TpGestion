namespace FrbaCrucero.AbmRecorrido
{
    partial class NuevoTramo
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPuertoS = new System.Windows.Forms.TextBox();
            this.textBoxPuertoL = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puerto Salida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puerto llegada";
            // 
            // textBoxPuertoS
            // 
            this.textBoxPuertoS.Location = new System.Drawing.Point(77, 47);
            this.textBoxPuertoS.Name = "textBoxPuertoS";
            this.textBoxPuertoS.ReadOnly = true;
            this.textBoxPuertoS.Size = new System.Drawing.Size(100, 20);
            this.textBoxPuertoS.TabIndex = 2;
            this.textBoxPuertoS.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxPuertoL
            // 
            this.textBoxPuertoL.Location = new System.Drawing.Point(274, 47);
            this.textBoxPuertoL.Name = "textBoxPuertoL";
            this.textBoxPuertoL.ReadOnly = true;
            this.textBoxPuertoL.Size = new System.Drawing.Size(100, 20);
            this.textBoxPuertoL.TabIndex = 3;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(158, 147);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecio.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NuevoTramo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxPuertoL);
            this.Controls.Add(this.textBoxPuertoS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NuevoTramo";
            this.Text = "NuevoTramo";
            this.Load += new System.EventHandler(this.NuevoTramo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPuertoS;
        private System.Windows.Forms.TextBox textBoxPuertoL;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}