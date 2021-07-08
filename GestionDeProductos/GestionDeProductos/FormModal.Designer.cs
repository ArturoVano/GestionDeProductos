namespace GestionDeProductos {
    partial class FormModal {
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
            this.labelAdd = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.tBAdd = new System.Windows.Forms.TextBox();
            this.btn_cnl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tBAdd2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBAdd5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBAdd6 = new System.Windows.Forms.TextBox();
            this.Tittle = new System.Windows.Forms.Label();
            this.tBAdd3 = new System.Windows.Forms.NumericUpDown();
            this.tBAdd4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btLoadImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tBAdd3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Location = new System.Drawing.Point(48, 69);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(203, 13);
            this.labelAdd.TabIndex = 0;
            this.labelAdd.Text = "*Introduce el nombre del nuevo producto:";
            // 
            // btn_add
            // 
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Location = new System.Drawing.Point(434, 352);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(96, 38);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Añadir";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tBAdd
            // 
            this.tBAdd.Location = new System.Drawing.Point(267, 66);
            this.tBAdd.Name = "tBAdd";
            this.tBAdd.Size = new System.Drawing.Size(181, 20);
            this.tBAdd.TabIndex = 2;
            // 
            // btn_cnl
            // 
            this.btn_cnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cnl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cnl.Location = new System.Drawing.Point(41, 352);
            this.btn_cnl.Name = "btn_cnl";
            this.btn_cnl.Size = new System.Drawing.Size(96, 38);
            this.btn_cnl.TabIndex = 3;
            this.btn_cnl.Text = "Cancelar";
            this.btn_cnl.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "*Introduce el código:";
            // 
            // tBAdd2
            // 
            this.tBAdd2.Location = new System.Drawing.Point(267, 115);
            this.tBAdd2.Name = "tBAdd2";
            this.tBAdd2.Size = new System.Drawing.Size(181, 20);
            this.tBAdd2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad del producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio del producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Descripción:";
            // 
            // tBAdd5
            // 
            this.tBAdd5.Location = new System.Drawing.Point(267, 224);
            this.tBAdd5.Name = "tBAdd5";
            this.tBAdd5.Size = new System.Drawing.Size(181, 20);
            this.tBAdd5.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tipo de producto:";
            // 
            // tBAdd6
            // 
            this.tBAdd6.Location = new System.Drawing.Point(267, 262);
            this.tBAdd6.Name = "tBAdd6";
            this.tBAdd6.Size = new System.Drawing.Size(181, 20);
            this.tBAdd6.TabIndex = 13;
            this.tBAdd6.TextChanged += new System.EventHandler(this.tBAdd6_TextChanged);
            // 
            // Tittle
            // 
            this.Tittle.AutoSize = true;
            this.Tittle.Location = new System.Drawing.Point(242, 22);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(35, 13);
            this.Tittle.TabIndex = 14;
            this.Tittle.Text = "label6";
            // 
            // tBAdd3
            // 
            this.tBAdd3.Location = new System.Drawing.Point(267, 153);
            this.tBAdd3.Name = "tBAdd3";
            this.tBAdd3.Size = new System.Drawing.Size(181, 20);
            this.tBAdd3.TabIndex = 15;
            // 
            // tBAdd4
            // 
            this.tBAdd4.Location = new System.Drawing.Point(267, 192);
            this.tBAdd4.Name = "tBAdd4";
            this.tBAdd4.Size = new System.Drawing.Size(181, 20);
            this.tBAdd4.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Imagen del producto:";
            // 
            // btLoadImg
            // 
            this.btLoadImg.Location = new System.Drawing.Point(267, 303);
            this.btLoadImg.Name = "btLoadImg";
            this.btLoadImg.Size = new System.Drawing.Size(181, 23);
            this.btLoadImg.TabIndex = 17;
            this.btLoadImg.Text = "Cargar Imagen";
            this.btLoadImg.UseVisualStyleBackColor = true;
            this.btLoadImg.Click += new System.EventHandler(this.btLoadImg_Click);
            // 
            // FormModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 432);
            this.Controls.Add(this.btLoadImg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tBAdd3);
            this.Controls.Add(this.Tittle);
            this.Controls.Add(this.tBAdd6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBAdd5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBAdd4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBAdd2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cnl);
            this.Controls.Add(this.tBAdd);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.labelAdd);
            this.Name = "FormModal";
            this.Text = "Añadir fila";
            ((System.ComponentModel.ISupportInitialize)(this.tBAdd3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Button btn_cnl;
        protected System.Windows.Forms.TextBox tBAdd;
        protected System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox tBAdd2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox tBAdd5;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.TextBox tBAdd6;
        private System.Windows.Forms.Label Tittle;
        protected System.Windows.Forms.NumericUpDown tBAdd3;
        protected System.Windows.Forms.TextBox tBAdd4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btLoadImg;
    }
}