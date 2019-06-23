namespace FrbaCrucero.AbmCrucero
{
    partial class ListaCruceros
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
            this.lista = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.Location = new System.Drawing.Point(17, 75);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(638, 337);
            this.lista.TabIndex = 0;
            this.lista.UseCompatibleStateImageBehavior = false;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ListaCruceros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 428);
            this.Controls.Add(this.lista);
            this.Name = "ListaCruceros";
            this.Text = "ListaCruceros";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lista;
    }
}