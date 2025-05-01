namespace CapaPresentacion
{
    partial class formCategoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.dgvdatos = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textindice = new System.Windows.Forms.TextBox();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iramodulo = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.btnLimpiarDatos = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.iramodulos = new System.Windows.Forms.PictureBox();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iramodulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iramodulos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(137, -205);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(20, 20);
            this.txtindice.TabIndex = 55;
            this.txtindice.Text = "-1";
            this.txtindice.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(285, 146);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(20, 20);
            this.txtid.TabIndex = 49;
            this.txtid.Text = "0";
            this.txtid.Visible = false;
            // 
            // dgvdatos
            // 
            this.dgvdatos.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvdatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvdatos.BackgroundColor = System.Drawing.Color.Black;
            this.dgvdatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.Id,
            this.Descripcion,
            this.EstadoValor,
            this.Estado});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvdatos.GridColor = System.Drawing.Color.Black;
            this.dgvdatos.Location = new System.Drawing.Point(30, 180);
            this.dgvdatos.MultiSelect = false;
            this.dgvdatos.Name = "dgvdatos";
            this.dgvdatos.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvdatos.RowTemplate.Height = 28;
            this.dgvdatos.Size = new System.Drawing.Size(275, 392);
            this.dgvdatos.TabIndex = 47;
            this.dgvdatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdatos_CellContentClick);
            this.dgvdatos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdatos_CellPainting);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnseleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnseleccionar.Width = 30;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EstadoValor";
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // textindice
            // 
            this.textindice.Location = new System.Drawing.Point(258, 146);
            this.textindice.Name = "textindice";
            this.textindice.Size = new System.Drawing.Size(20, 20);
            this.textindice.TabIndex = 56;
            this.textindice.Text = "-1";
            this.textindice.Visible = false;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Transparent;
            this.btneliminar.BackgroundImage = global::CapaPresentacion.Properties.Resources.eliminarcategoria;
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.Black;
            this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btneliminar.IconColor = System.Drawing.Color.White;
            this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneliminar.IconSize = 50;
            this.btneliminar.Location = new System.Drawing.Point(426, 185);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(90, 98);
            this.btneliminar.TabIndex = 59;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Transparent;
            this.btnguardar.BackgroundImage = global::CapaPresentacion.Properties.Resources.guardarcategoria;
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.Black;
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnguardar.IconColor = System.Drawing.Color.White;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 50;
            this.btnguardar.Location = new System.Drawing.Point(330, 185);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(90, 98);
            this.btnguardar.TabIndex = 57;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnlimpiarbuscador
            // 
            this.btnlimpiarbuscador.BackColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarbuscador.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnlimpiarbuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiarbuscador.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiarbuscador.IconColor = System.Drawing.Color.White;
            this.btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiarbuscador.IconSize = 40;
            this.btnlimpiarbuscador.Location = new System.Drawing.Point(420, 417);
            this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            this.btnlimpiarbuscador.Size = new System.Drawing.Size(77, 48);
            this.btnlimpiarbuscador.TabIndex = 64;
            this.btnlimpiarbuscador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiarbuscador.UseVisualStyleBackColor = false;
            this.btnlimpiarbuscador.Click += new System.EventHandler(this.btnlimpiarbuscador_Click_1);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Black;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscar.IconColor = System.Drawing.Color.White;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 40;
            this.btnbuscar.Location = new System.Drawing.Point(330, 417);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(77, 48);
            this.btnbuscar.TabIndex = 63;
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click_1);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.Location = new System.Drawing.Point(330, 379);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(167, 32);
            this.txtbusqueda.TabIndex = 62;
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(330, 342);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(167, 31);
            this.cbobusqueda.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Italic);
            this.label11.Location = new System.Drawing.Point(325, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 25);
            this.label11.TabIndex = 60;
            this.label11.Text = "Buscar por:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iramodulo);
            this.panel1.Controls.Add(this.btnminimizar);
            this.panel1.Controls.Add(this.Cerrar);
            this.panel1.Controls.Add(this.btnLimpiarDatos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.iramodulos);
            this.panel1.Controls.Add(this.cboestado);
            this.panel1.Controls.Add(this.txtdescripcion);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 140);
            this.panel1.TabIndex = 65;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(1, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 126;
            this.label1.Text = "Ir a Modulos";
            // 
            // iramodulo
            // 
            this.iramodulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iramodulo.Image = global::CapaPresentacion.Properties.Resources.VolveraModulos;
            this.iramodulo.Location = new System.Drawing.Point(0, 0);
            this.iramodulo.Name = "iramodulo";
            this.iramodulo.Size = new System.Drawing.Size(50, 50);
            this.iramodulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iramodulo.TabIndex = 125;
            this.iramodulo.TabStop = false;
            this.iramodulo.Click += new System.EventHandler(this.iramodulo_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = global::CapaPresentacion.Properties.Resources.minimizar;
            this.btnminimizar.Location = new System.Drawing.Point(472, 5);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(30, 30);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnminimizar.TabIndex = 124;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cerrar.Image = global::CapaPresentacion.Properties.Resources.cerca;
            this.Cerrar.Location = new System.Drawing.Point(503, 5);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(30, 30);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cerrar.TabIndex = 123;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.BackColor = System.Drawing.Color.DarkGray;
            this.btnLimpiarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarDatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLimpiarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarDatos.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDatos.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarDatos.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarDatos.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarDatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarDatos.IconSize = 25;
            this.btnLimpiarDatos.Location = new System.Drawing.Point(345, 101);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(152, 30);
            this.btnLimpiarDatos.TabIndex = 71;
            this.btnLimpiarDatos.Text = "Limpiar Datos";
            this.btnLimpiarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarDatos.UseVisualStyleBackColor = false;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(-435, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 122;
            this.label2.Text = "Ir Modulos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.menos;
            this.pictureBox2.Location = new System.Drawing.Point(91, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(225, 10);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 70;
            this.pictureBox2.TabStop = false;
            // 
            // iramodulos
            // 
            this.iramodulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iramodulos.Image = global::CapaPresentacion.Properties.Resources.VolveraModulos;
            this.iramodulos.Location = new System.Drawing.Point(-482, 2);
            this.iramodulos.Name = "iramodulos";
            this.iramodulos.Size = new System.Drawing.Size(50, 50);
            this.iramodulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iramodulos.TabIndex = 121;
            this.iramodulos.TabStop = false;
            // 
            // cboestado
            // 
            this.cboestado.BackColor = System.Drawing.Color.Black;
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboestado.ForeColor = System.Drawing.Color.Yellow;
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(89, 102);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(224, 29);
            this.cboestado.TabIndex = 67;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.Color.Black;
            this.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.ForeColor = System.Drawing.Color.Silver;
            this.txtdescripcion.Location = new System.Drawing.Point(92, 66);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(224, 20);
            this.txtdescripcion.TabIndex = 69;
            this.txtdescripcion.Text = "DESCRIPCION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(9, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 66;
            this.label8.Text = "ESTADO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Italic);
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(97, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(318, 42);
            this.label9.TabIndex = 66;
            this.label9.Text = "Registro de Categoria";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Italic);
            this.label10.Location = new System.Drawing.Point(-2, 143);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(281, 34);
            this.label10.TabIndex = 66;
            this.label10.Text = "Lista de Categorias";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // formCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(531, 578);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnlimpiarbuscador);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.textindice);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.dgvdatos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCategoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmCategoria_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iramodulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iramodulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridView dgvdatos;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.TextBox textindice;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtdescripcion;
        private FontAwesome.Sharp.IconButton btnLimpiarDatos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox iramodulos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox iramodulo;
    }
}