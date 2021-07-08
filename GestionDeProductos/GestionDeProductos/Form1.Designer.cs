namespace GestionDeProductos {
    partial class pSideMenu {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pSideMenu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Añadir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img = new System.Windows.Forms.DataGridViewImageColumn();
            this.EditarFil = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EliminarFil = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.otrosSubMenu = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btnOtros = new System.Windows.Forms.Button();
            this.DelSubMenu = new System.Windows.Forms.Panel();
            this.btnSubDel2 = new System.Windows.Forms.Button();
            this.btnSubDel1 = new System.Windows.Forms.Button();
            this.btnEliminaciones = new System.Windows.Forms.Button();
            this.ModSubMenu = new System.Windows.Forms.Panel();
            this.btnSubMod2 = new System.Windows.Forms.Button();
            this.btnSubMod1 = new System.Windows.Forms.Button();
            this.btnModificaciones = new System.Windows.Forms.Button();
            this.AddSubMenu = new System.Windows.Forms.Panel();
            this.btnSubAdd2 = new System.Windows.Forms.Button();
            this.btnSubAdd1 = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.pLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.infoCursor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.otrosSubMenu.SuspendLayout();
            this.DelSubMenu.SuspendLayout();
            this.ModSubMenu.SuspendLayout();
            this.AddSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Añadir,
            this.Modificar,
            this.Borrar,
            this.Precio,
            this.Descripción,
            this.Tipo,
            this.img,
            this.EditarFil,
            this.EliminarFil});
            this.dataGridView1.Location = new System.Drawing.Point(286, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 221);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Añadir
            // 
            this.Añadir.HeaderText = "Nombre";
            this.Añadir.Name = "Añadir";
            this.Añadir.Width = 69;
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Código";
            this.Modificar.Name = "Modificar";
            this.Modificar.Width = 65;
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Cantidad";
            this.Borrar.Name = "Borrar";
            this.Borrar.Width = 74;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 62;
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            this.Descripción.Width = 88;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 53;
            // 
            // img
            // 
            this.img.HeaderText = "Imagen ";
            this.img.Name = "img";
            this.img.Width = 51;
            // 
            // EditarFil
            // 
            this.EditarFil.HeaderText = "Editar";
            this.EditarFil.Name = "EditarFil";
            this.EditarFil.Text = "✎";
            this.EditarFil.Width = 40;
            // 
            // EliminarFil
            // 
            this.EliminarFil.HeaderText = "Borrar";
            this.EliminarFil.Name = "EliminarFil";
            this.EliminarFil.Text = "⌧";
            this.EliminarFil.ToolTipText = "⌧";
            this.EliminarFil.Width = 41;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(358, 289);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 38);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMod
            // 
            this.btnMod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMod.Location = new System.Drawing.Point(554, 289);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(76, 38);
            this.btnMod.TabIndex = 2;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDel.Location = new System.Drawing.Point(762, 289);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(74, 38);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Borrar";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.otrosSubMenu);
            this.panel1.Controls.Add(this.btnOtros);
            this.panel1.Controls.Add(this.DelSubMenu);
            this.panel1.Controls.Add(this.btnEliminaciones);
            this.panel1.Controls.Add(this.ModSubMenu);
            this.panel1.Controls.Add(this.btnModificaciones);
            this.panel1.Controls.Add(this.AddSubMenu);
            this.panel1.Controls.Add(this.btnAñadir);
            this.panel1.Controls.Add(this.pLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 544);
            this.panel1.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.ImageList = this.imageList1;
            this.btnExit.Location = new System.Drawing.Point(0, 626);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(233, 45);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Salir";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "05_1-512.png");
            this.imageList1.Images.SetKeyName(1, "exit.png");
            this.imageList1.Images.SetKeyName(2, "salidapng.png");
            // 
            // otrosSubMenu
            // 
            this.otrosSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.otrosSubMenu.Controls.Add(this.button10);
            this.otrosSubMenu.Controls.Add(this.button11);
            this.otrosSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.otrosSubMenu.Location = new System.Drawing.Point(0, 538);
            this.otrosSubMenu.Name = "otrosSubMenu";
            this.otrosSubMenu.Size = new System.Drawing.Size(233, 88);
            this.otrosSubMenu.TabIndex = 8;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.SystemColors.Window;
            this.button10.Location = new System.Drawing.Point(0, 40);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(233, 40);
            this.button10.TabIndex = 1;
            this.button10.Text = "Importar desde .csv";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.SystemColors.Window;
            this.button11.Location = new System.Drawing.Point(0, 0);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button11.Size = new System.Drawing.Size(233, 40);
            this.button11.TabIndex = 0;
            this.button11.Text = "Exportar a fichero .csv";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnOtros
            // 
            this.btnOtros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOtros.FlatAppearance.BorderSize = 0;
            this.btnOtros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtros.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnOtros.Location = new System.Drawing.Point(0, 493);
            this.btnOtros.Name = "btnOtros";
            this.btnOtros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOtros.Size = new System.Drawing.Size(233, 45);
            this.btnOtros.TabIndex = 7;
            this.btnOtros.Text = "Otros";
            this.btnOtros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOtros.UseVisualStyleBackColor = true;
            this.btnOtros.Click += new System.EventHandler(this.btnOtros_Click);
            // 
            // DelSubMenu
            // 
            this.DelSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.DelSubMenu.Controls.Add(this.btnSubDel2);
            this.DelSubMenu.Controls.Add(this.btnSubDel1);
            this.DelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.DelSubMenu.Location = new System.Drawing.Point(0, 405);
            this.DelSubMenu.Name = "DelSubMenu";
            this.DelSubMenu.Size = new System.Drawing.Size(233, 88);
            this.DelSubMenu.TabIndex = 6;
            // 
            // btnSubDel2
            // 
            this.btnSubDel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubDel2.FlatAppearance.BorderSize = 0;
            this.btnSubDel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubDel2.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSubDel2.Location = new System.Drawing.Point(0, 40);
            this.btnSubDel2.Name = "btnSubDel2";
            this.btnSubDel2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubDel2.Size = new System.Drawing.Size(233, 40);
            this.btnSubDel2.TabIndex = 1;
            this.btnSubDel2.Text = "Borrar sin seleción";
            this.btnSubDel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubDel2.UseVisualStyleBackColor = true;
            this.btnSubDel2.Click += new System.EventHandler(this.btnSubDel2_Click);
            // 
            // btnSubDel1
            // 
            this.btnSubDel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubDel1.FlatAppearance.BorderSize = 0;
            this.btnSubDel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubDel1.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSubDel1.Location = new System.Drawing.Point(0, 0);
            this.btnSubDel1.Name = "btnSubDel1";
            this.btnSubDel1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubDel1.Size = new System.Drawing.Size(233, 40);
            this.btnSubDel1.TabIndex = 0;
            this.btnSubDel1.Text = "Borrar por selección";
            this.btnSubDel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubDel1.UseVisualStyleBackColor = true;
            this.btnSubDel1.Click += new System.EventHandler(this.btnSubDel1_Click);
            // 
            // btnEliminaciones
            // 
            this.btnEliminaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminaciones.FlatAppearance.BorderSize = 0;
            this.btnEliminaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminaciones.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEliminaciones.Location = new System.Drawing.Point(0, 360);
            this.btnEliminaciones.Name = "btnEliminaciones";
            this.btnEliminaciones.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEliminaciones.Size = new System.Drawing.Size(233, 45);
            this.btnEliminaciones.TabIndex = 5;
            this.btnEliminaciones.Text = "Eliminaciones";
            this.btnEliminaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminaciones.UseVisualStyleBackColor = true;
            this.btnEliminaciones.Click += new System.EventHandler(this.btnEliminaciones_Click);
            // 
            // ModSubMenu
            // 
            this.ModSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ModSubMenu.Controls.Add(this.btnSubMod2);
            this.ModSubMenu.Controls.Add(this.btnSubMod1);
            this.ModSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ModSubMenu.Location = new System.Drawing.Point(0, 272);
            this.ModSubMenu.Name = "ModSubMenu";
            this.ModSubMenu.Size = new System.Drawing.Size(233, 88);
            this.ModSubMenu.TabIndex = 4;
            // 
            // btnSubMod2
            // 
            this.btnSubMod2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMod2.FlatAppearance.BorderSize = 0;
            this.btnSubMod2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMod2.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSubMod2.Location = new System.Drawing.Point(0, 40);
            this.btnSubMod2.Name = "btnSubMod2";
            this.btnSubMod2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubMod2.Size = new System.Drawing.Size(233, 40);
            this.btnSubMod2.TabIndex = 1;
            this.btnSubMod2.Text = "Modificar sin selección";
            this.btnSubMod2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMod2.UseVisualStyleBackColor = true;
            this.btnSubMod2.Click += new System.EventHandler(this.btnSubMod2_Click);
            // 
            // btnSubMod1
            // 
            this.btnSubMod1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMod1.FlatAppearance.BorderSize = 0;
            this.btnSubMod1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMod1.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSubMod1.Location = new System.Drawing.Point(0, 0);
            this.btnSubMod1.Name = "btnSubMod1";
            this.btnSubMod1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubMod1.Size = new System.Drawing.Size(233, 40);
            this.btnSubMod1.TabIndex = 0;
            this.btnSubMod1.Text = "Modificar por selección";
            this.btnSubMod1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMod1.UseVisualStyleBackColor = true;
            this.btnSubMod1.Click += new System.EventHandler(this.btnSubMod1_Click);
            // 
            // btnModificaciones
            // 
            this.btnModificaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificaciones.FlatAppearance.BorderSize = 0;
            this.btnModificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificaciones.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnModificaciones.Location = new System.Drawing.Point(0, 227);
            this.btnModificaciones.Name = "btnModificaciones";
            this.btnModificaciones.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnModificaciones.Size = new System.Drawing.Size(233, 45);
            this.btnModificaciones.TabIndex = 3;
            this.btnModificaciones.Text = "Modificaciones";
            this.btnModificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificaciones.UseVisualStyleBackColor = true;
            this.btnModificaciones.Click += new System.EventHandler(this.btnModificaciones_Click);
            // 
            // AddSubMenu
            // 
            this.AddSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.AddSubMenu.Controls.Add(this.btnSubAdd2);
            this.AddSubMenu.Controls.Add(this.btnSubAdd1);
            this.AddSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddSubMenu.Location = new System.Drawing.Point(0, 139);
            this.AddSubMenu.Name = "AddSubMenu";
            this.AddSubMenu.Size = new System.Drawing.Size(233, 88);
            this.AddSubMenu.TabIndex = 2;
            // 
            // btnSubAdd2
            // 
            this.btnSubAdd2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubAdd2.FlatAppearance.BorderSize = 0;
            this.btnSubAdd2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubAdd2.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSubAdd2.Location = new System.Drawing.Point(0, 40);
            this.btnSubAdd2.Name = "btnSubAdd2";
            this.btnSubAdd2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubAdd2.Size = new System.Drawing.Size(233, 40);
            this.btnSubAdd2.TabIndex = 1;
            this.btnSubAdd2.Text = "Añadir sin selección";
            this.btnSubAdd2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubAdd2.UseVisualStyleBackColor = true;
            this.btnSubAdd2.Click += new System.EventHandler(this.btnSubAdd2_Click);
            // 
            // btnSubAdd1
            // 
            this.btnSubAdd1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubAdd1.FlatAppearance.BorderSize = 0;
            this.btnSubAdd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubAdd1.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSubAdd1.Location = new System.Drawing.Point(0, 0);
            this.btnSubAdd1.Name = "btnSubAdd1";
            this.btnSubAdd1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubAdd1.Size = new System.Drawing.Size(233, 40);
            this.btnSubAdd1.TabIndex = 0;
            this.btnSubAdd1.Text = "Añadir por selección";
            this.btnSubAdd1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubAdd1.UseVisualStyleBackColor = true;
            this.btnSubAdd1.Click += new System.EventHandler(this.btnSubAdd1_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAñadir.FlatAppearance.BorderSize = 0;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAñadir.Location = new System.Drawing.Point(0, 94);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAñadir.Size = new System.Drawing.Size(233, 45);
            this.btnAñadir.TabIndex = 1;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.SystemColors.Desktop;
            this.pLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pLogo.BackgroundImage")));
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(233, 94);
            this.pLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(297, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fila seleccionada:";
            // 
            // infoCursor
            // 
            this.infoCursor.AutoSize = true;
            this.infoCursor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoCursor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.infoCursor.Location = new System.Drawing.Point(407, 242);
            this.infoCursor.Name = "infoCursor";
            this.infoCursor.Size = new System.Drawing.Size(0, 16);
            this.infoCursor.TabIndex = 6;
            // 
            // pSideMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(956, 544);
            this.Controls.Add(this.infoCursor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "pSideMenu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.otrosSubMenu.ResumeLayout(false);
            this.DelSubMenu.ResumeLayout(false);
            this.ModSubMenu.ResumeLayout(false);
            this.AddSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        protected System.Windows.Forms.Button btnAdd;
        protected System.Windows.Forms.Button btnMod;
        protected System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel AddSubMenu;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.Button btnSubAdd2;
        private System.Windows.Forms.Button btnSubAdd1;
        private System.Windows.Forms.Panel otrosSubMenu;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnOtros;
        private System.Windows.Forms.Panel DelSubMenu;
        private System.Windows.Forms.Button btnSubDel2;
        private System.Windows.Forms.Button btnSubDel1;
        private System.Windows.Forms.Button btnEliminaciones;
        private System.Windows.Forms.Panel ModSubMenu;
        private System.Windows.Forms.Button btnSubMod2;
        private System.Windows.Forms.Button btnSubMod1;
        private System.Windows.Forms.Button btnModificaciones;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Añadir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewImageColumn img;
        private System.Windows.Forms.DataGridViewButtonColumn EditarFil;
        private System.Windows.Forms.DataGridViewButtonColumn EliminarFil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label infoCursor;
    }
}

