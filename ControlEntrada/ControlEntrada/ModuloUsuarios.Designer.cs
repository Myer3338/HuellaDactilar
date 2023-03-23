namespace ControlEntrada
{
    partial class ModuloUsuarios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuloUsuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.Button();
            this.labelMenu = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UsuariosNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.MoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.MovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.MoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BNuevo = new System.Windows.Forms.ToolStripButton();
            this.BGuardar = new System.Windows.Forms.ToolStripButton();
            this.BCancelar = new System.Windows.Forms.ToolStripButton();
            this.BEliminar = new System.Windows.Forms.ToolStripButton();
            this.BEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Buscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BBuscar = new System.Windows.Forms.ToolStripButton();
            this.BTodosRegistros = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rolComboBox = new System.Windows.Forms.ComboBox();
            this.contrasenaTextEdit = new System.Windows.Forms.TextBox();
            this.id_UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTtextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextEdit = new System.Windows.Forms.TextBox();
            this.cedulaTextBox = new System.Windows.Forms.TextBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelIDUsuario = new System.Windows.Forms.Label();
            this.labelRol = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDocumento = new System.Windows.Forms.Label();
            this.BEliminarFoto = new System.Windows.Forms.Button();
            this.BFoto = new System.Windows.Forms.Button();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.UsuariosbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosNavigator)).BeginInit();
            this.UsuariosNavigator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosbindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.cerrar);
            this.panel1.Controls.Add(this.labelMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 39);
            this.panel1.TabIndex = 8;
            // 
            // cerrar
            // 
            this.cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cerrar.BackgroundImage")));
            this.cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Location = new System.Drawing.Point(903, 0);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(42, 39);
            this.cerrar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cerrar, "Cerrar");
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.Color.White;
            this.labelMenu.Location = new System.Drawing.Point(12, 9);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(196, 22);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "Usuarios del sistema";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UsuariosNavigator);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(32, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(882, 354);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // UsuariosNavigator
            // 
            this.UsuariosNavigator.AddNewItem = null;
            this.UsuariosNavigator.CountItem = this.bindingNavigatorCountItem;
            this.UsuariosNavigator.DeleteItem = null;
            this.UsuariosNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MoveFirstItem,
            this.MovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.MoveNextItem,
            this.MoveLastItem,
            this.bindingNavigatorSeparator2,
            this.BNuevo,
            this.BGuardar,
            this.BCancelar,
            this.BEliminar,
            this.BEditar,
            this.toolStripSeparator1,
            this.Buscar,
            this.toolStripSeparator2,
            this.BBuscar,
            this.BTodosRegistros});
            this.UsuariosNavigator.Location = new System.Drawing.Point(3, 16);
            this.UsuariosNavigator.MoveFirstItem = this.MoveFirstItem;
            this.UsuariosNavigator.MoveLastItem = this.MoveLastItem;
            this.UsuariosNavigator.MoveNextItem = this.MoveNextItem;
            this.UsuariosNavigator.MovePreviousItem = this.MovePreviousItem;
            this.UsuariosNavigator.Name = "UsuariosNavigator";
            this.UsuariosNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.UsuariosNavigator.Size = new System.Drawing.Size(876, 25);
            this.UsuariosNavigator.TabIndex = 11;
            this.UsuariosNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // MoveFirstItem
            // 
            this.MoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("MoveFirstItem.Image")));
            this.MoveFirstItem.Name = "MoveFirstItem";
            this.MoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.MoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.MoveFirstItem.Text = "Mover primero";
            // 
            // MovePreviousItem
            // 
            this.MovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("MovePreviousItem.Image")));
            this.MovePreviousItem.Name = "MovePreviousItem";
            this.MovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.MovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.MovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // MoveNextItem
            // 
            this.MoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("MoveNextItem.Image")));
            this.MoveNextItem.Name = "MoveNextItem";
            this.MoveNextItem.RightToLeftAutoMirrorImage = true;
            this.MoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.MoveNextItem.Text = "Mover siguiente";
            // 
            // MoveLastItem
            // 
            this.MoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("MoveLastItem.Image")));
            this.MoveLastItem.Name = "MoveLastItem";
            this.MoveLastItem.RightToLeftAutoMirrorImage = true;
            this.MoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.MoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BNuevo
            // 
            this.BNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BNuevo.Image")));
            this.BNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BNuevo.Name = "BNuevo";
            this.BNuevo.Size = new System.Drawing.Size(23, 22);
            this.BNuevo.Text = "toolStripButton1";
            this.BNuevo.ToolTipText = "Crear Registro";
            this.BNuevo.Click += new System.EventHandler(this.BNuevo_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BGuardar.Enabled = false;
            this.BGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BGuardar.Image")));
            this.BGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(23, 22);
            this.BGuardar.Text = "Guardar Registro";
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BCancelar.Enabled = false;
            this.BCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BCancelar.Image")));
            this.BCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(23, 22);
            this.BCancelar.Text = "Cancelar Registro";
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BEliminar
            // 
            this.BEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BEliminar.Enabled = false;
            this.BEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BEliminar.Image")));
            this.BEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(23, 22);
            this.BEliminar.Text = "Eliminar Registro";
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // BEditar
            // 
            this.BEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BEditar.Enabled = false;
            this.BEditar.Image = ((System.Drawing.Image)(resources.GetObject("BEditar.Image")));
            this.BEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(23, 22);
            this.BEditar.Text = "Editar Registro";
            this.BEditar.Click += new System.EventHandler(this.BEditar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Buscar
            // 
            this.Buscar.Enabled = false;
            this.Buscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BBuscar
            // 
            this.BBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BBuscar.Enabled = false;
            this.BBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BBuscar.Image")));
            this.BBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(23, 22);
            this.BBuscar.Text = "Buscar Registro";
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // BTodosRegistros
            // 
            this.BTodosRegistros.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTodosRegistros.Enabled = false;
            this.BTodosRegistros.Image = ((System.Drawing.Image)(resources.GetObject("BTodosRegistros.Image")));
            this.BTodosRegistros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTodosRegistros.Name = "BTodosRegistros";
            this.BTodosRegistros.Size = new System.Drawing.Size(23, 22);
            this.BTodosRegistros.Text = "Ver Todos los Registros";
            this.BTodosRegistros.Click += new System.EventHandler(this.BTodosRegistros_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.rolComboBox);
            this.groupBox2.Controls.Add(this.contrasenaTextEdit);
            this.groupBox2.Controls.Add(this.usuarioTtextBox);
            this.groupBox2.Controls.Add(this.correoTextBox);
            this.groupBox2.Controls.Add(this.nombreTextEdit);
            this.groupBox2.Controls.Add(this.cedulaTextBox);
            this.groupBox2.Controls.Add(this.labelContraseña);
            this.groupBox2.Controls.Add(this.labelRol);
            this.groupBox2.Controls.Add(this.labelUsuario);
            this.groupBox2.Controls.Add(this.labelCorreo);
            this.groupBox2.Controls.Add(this.labelNombre);
            this.groupBox2.Controls.Add(this.labelDocumento);
            this.groupBox2.Controls.Add(this.BEliminarFoto);
            this.groupBox2.Controls.Add(this.BFoto);
            this.groupBox2.Controls.Add(this.fotoPictureBox);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(55, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 277);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // rolComboBox
            // 
            this.rolComboBox.FormattingEnabled = true;
            this.rolComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Invitado"});
            this.rolComboBox.Location = new System.Drawing.Point(638, 160);
            this.rolComboBox.Name = "rolComboBox";
            this.rolComboBox.Size = new System.Drawing.Size(100, 21);
            this.rolComboBox.TabIndex = 17;
            this.rolComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxRol_KeyPress);
            // 
            // contrasenaTextEdit
            // 
            this.contrasenaTextEdit.Location = new System.Drawing.Point(444, 192);
            this.contrasenaTextEdit.Name = "contrasenaTextEdit";
            this.contrasenaTextEdit.Size = new System.Drawing.Size(294, 20);
            this.contrasenaTextEdit.TabIndex = 16;
            // 
            // id_UsuarioTextBox
            // 
            this.id_UsuarioTextBox.Enabled = false;
            this.id_UsuarioTextBox.Location = new System.Drawing.Point(83, -3);
            this.id_UsuarioTextBox.Name = "id_UsuarioTextBox";
            this.id_UsuarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_UsuarioTextBox.TabIndex = 15;
            // 
            // usuarioTtextBox
            // 
            this.usuarioTtextBox.Location = new System.Drawing.Point(444, 160);
            this.usuarioTtextBox.Name = "usuarioTtextBox";
            this.usuarioTtextBox.Size = new System.Drawing.Size(100, 20);
            this.usuarioTtextBox.TabIndex = 13;
            // 
            // correoTextBox
            // 
            this.correoTextBox.Location = new System.Drawing.Point(444, 128);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(100, 20);
            this.correoTextBox.TabIndex = 12;
            // 
            // nombreTextEdit
            // 
            this.nombreTextEdit.Location = new System.Drawing.Point(444, 96);
            this.nombreTextEdit.Name = "nombreTextEdit";
            this.nombreTextEdit.Size = new System.Drawing.Size(100, 20);
            this.nombreTextEdit.TabIndex = 11;
            // 
            // cedulaTextBox
            // 
            this.cedulaTextBox.Location = new System.Drawing.Point(445, 64);
            this.cedulaTextBox.Name = "cedulaTextBox";
            this.cedulaTextBox.Size = new System.Drawing.Size(100, 20);
            this.cedulaTextBox.TabIndex = 10;
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Location = new System.Drawing.Point(371, 189);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(64, 13);
            this.labelContraseña.TabIndex = 9;
            this.labelContraseña.Text = "Contraseña:";
            // 
            // labelIDUsuario
            // 
            this.labelIDUsuario.AutoSize = true;
            this.labelIDUsuario.Location = new System.Drawing.Point(27, 0);
            this.labelIDUsuario.Name = "labelIDUsuario";
            this.labelIDUsuario.Size = new System.Drawing.Size(58, 13);
            this.labelIDUsuario.TabIndex = 8;
            this.labelIDUsuario.Text = "Id Usuario:";
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Location = new System.Drawing.Point(582, 163);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(26, 13);
            this.labelRol.TabIndex = 7;
            this.labelRol.Text = "Rol:";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(371, 164);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(46, 13);
            this.labelUsuario.TabIndex = 6;
            this.labelUsuario.Text = "Usuario:";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Location = new System.Drawing.Point(371, 132);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(41, 13);
            this.labelCorreo.TabIndex = 5;
            this.labelCorreo.Text = "Correo:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(371, 100);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelDocumento
            // 
            this.labelDocumento.AutoSize = true;
            this.labelDocumento.Location = new System.Drawing.Point(371, 68);
            this.labelDocumento.Name = "labelDocumento";
            this.labelDocumento.Size = new System.Drawing.Size(65, 13);
            this.labelDocumento.TabIndex = 3;
            this.labelDocumento.Text = "Documento:";
            // 
            // BEliminarFoto
            // 
            this.BEliminarFoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BEliminarFoto.BackgroundImage")));
            this.BEliminarFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BEliminarFoto.FlatAppearance.BorderSize = 0;
            this.BEliminarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEliminarFoto.Location = new System.Drawing.Point(34, 159);
            this.BEliminarFoto.Name = "BEliminarFoto";
            this.BEliminarFoto.Size = new System.Drawing.Size(99, 76);
            this.BEliminarFoto.TabIndex = 2;
            this.BEliminarFoto.UseVisualStyleBackColor = true;
            this.BEliminarFoto.Click += new System.EventHandler(this.BEliminarFoto_Click);
            // 
            // BFoto
            // 
            this.BFoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BFoto.BackgroundImage")));
            this.BFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BFoto.FlatAppearance.BorderSize = 0;
            this.BFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BFoto.Location = new System.Drawing.Point(34, 56);
            this.BFoto.Name = "BFoto";
            this.BFoto.Size = new System.Drawing.Size(99, 77);
            this.BFoto.TabIndex = 1;
            this.BFoto.UseVisualStyleBackColor = true;
            this.BFoto.Click += new System.EventHandler(this.BFoto_Click);
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fotoPictureBox.Location = new System.Drawing.Point(151, 56);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(203, 179);
            this.fotoPictureBox.TabIndex = 0;
            this.fotoPictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.id_UsuarioTextBox);
            this.panel2.Controls.Add(this.labelIDUsuario);
            this.panel2.Location = new System.Drawing.Point(555, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(23, 12);
            this.panel2.TabIndex = 18;
            // 
            // ModuloUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 445);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModuloUsuarios";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModuloUsuarios";
            this.Load += new System.EventHandler(this.ModuloUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosNavigator)).EndInit();
            this.UsuariosNavigator.ResumeLayout(false);
            this.UsuariosNavigator.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosbindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.BindingNavigator UsuariosNavigator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label labelIDUsuario;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDocumento;
        private System.Windows.Forms.Button BEliminarFoto;
        private System.Windows.Forms.Button BFoto;
        public System.Windows.Forms.ToolStripButton MoveFirstItem;
        public System.Windows.Forms.ToolStripButton MovePreviousItem;
        public System.Windows.Forms.ToolStripButton MoveNextItem;
        public System.Windows.Forms.ToolStripButton MoveLastItem;
        public System.Windows.Forms.ToolStripButton BNuevo;
        public System.Windows.Forms.ToolStripButton BGuardar;
        public System.Windows.Forms.ToolStripButton BCancelar;
        public System.Windows.Forms.ToolStripButton BEliminar;
        public System.Windows.Forms.ToolStripButton BEditar;
        public System.Windows.Forms.ToolStripTextBox Buscar;
        public System.Windows.Forms.ToolStripButton BBuscar;
        public System.Windows.Forms.ToolStripButton BTodosRegistros;
        public System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        public System.Windows.Forms.PictureBox fotoPictureBox;
        public System.Windows.Forms.ComboBox rolComboBox;
        public System.Windows.Forms.TextBox contrasenaTextEdit;
        public System.Windows.Forms.TextBox usuarioTtextBox;
        public System.Windows.Forms.TextBox correoTextBox;
        public System.Windows.Forms.TextBox nombreTextEdit;
        public System.Windows.Forms.TextBox cedulaTextBox;
        public System.Windows.Forms.TextBox id_UsuarioTextBox;
        public System.Windows.Forms.BindingSource UsuariosbindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
    }
}