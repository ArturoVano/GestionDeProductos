namespace GestionDeProductos {
    partial class FormMod {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.MODIFICAR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MODIFICAR
            // 
            this.MODIFICAR.Location = new System.Drawing.Point(305, 30);
            this.MODIFICAR.Name = "MODIFICAR";
            this.MODIFICAR.Size = new System.Drawing.Size(90, 40);
            this.MODIFICAR.TabIndex = 0;
            this.MODIFICAR.Text = "MODIFICAR";
            this.MODIFICAR.Click += new System.EventHandler(this.MODIFICAR_Click);
            // 
            // FormMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MODIFICAR);
            this.Name = "FormMod";
            this.Text = "FormMod";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MODIFICAR;
    }
}