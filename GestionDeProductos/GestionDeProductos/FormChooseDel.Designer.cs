namespace GestionDeProductos
{
    partial class FormChooseDel
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
            this.listArticulos = new System.Windows.Forms.ListBox();
            this.btnFCDCanc = new System.Windows.Forms.Button();
            this.btnFCDElim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tittle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listArticulos
            // 
            this.listArticulos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listArticulos.FormattingEnabled = true;
            this.listArticulos.HorizontalScrollbar = true;
            this.listArticulos.Location = new System.Drawing.Point(287, 103);
            this.listArticulos.Name = "listArticulos";
            this.listArticulos.Size = new System.Drawing.Size(233, 199);
            this.listArticulos.TabIndex = 0;
            this.listArticulos.SelectedIndexChanged += new System.EventHandler(this.listArticulos_SelectedIndexChanged);
            // 
            // btnFCDCanc
            // 
            this.btnFCDCanc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFCDCanc.Location = new System.Drawing.Point(113, 332);
            this.btnFCDCanc.Name = "btnFCDCanc";
            this.btnFCDCanc.Size = new System.Drawing.Size(117, 39);
            this.btnFCDCanc.TabIndex = 1;
            this.btnFCDCanc.Text = "Cancelar";
            this.btnFCDCanc.UseVisualStyleBackColor = true;
            this.btnFCDCanc.Click += new System.EventHandler(this.btnFCDCanc_Click);
            // 
            // btnFCDElim
            // 
            this.btnFCDElim.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFCDElim.Location = new System.Drawing.Point(551, 332);
            this.btnFCDElim.Name = "btnFCDElim";
            this.btnFCDElim.Size = new System.Drawing.Size(117, 39);
            this.btnFCDElim.TabIndex = 2;
            this.btnFCDElim.Text = "Eliminar";
            this.btnFCDElim.UseVisualStyleBackColor = true;
            this.btnFCDElim.Click += new System.EventHandler(this.btnFCDElim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tittle.Location = new System.Drawing.Point(284, 42);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(222, 16);
            this.tittle.TabIndex = 4;
            this.tittle.Text = "Selecciona un producto para borrar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(297, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(436, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Producto";
            // 
            // FormChooseDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tittle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFCDElim);
            this.Controls.Add(this.btnFCDCanc);
            this.Controls.Add(this.listArticulos);
            this.Name = "FormChooseDel";
            this.Text = "FormChooseDel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ListBox listArticulos;
        private System.Windows.Forms.Button btnFCDCanc;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label tittle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnFCDElim;
    }
}