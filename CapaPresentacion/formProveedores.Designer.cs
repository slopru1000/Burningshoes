namespace CapaPresentacion
{
    partial class formProveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnexporterexcel = new FontAwesome.Sharp.IconButton();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.dgvdatos = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.txtrazonsocial = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiarDatos = new FontAwesome.Sharp.IconButton();
            this.iramodulos = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iramodulos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexporterexcel
            // 
            this.btnexporterexcel.BackColor = System.Drawing.Color.Transparent;
            this.btnexporterexcel.BackgroundImage = global::CapaPresentacion.Properties.Resources.exportarexcel;
            this.btnexporterexcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnexporterexcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexporterexcel.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnexporterexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexporterexcel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexporterexcel.ForeColor = System.Drawing.Color.Black;
            this.btnexporterexcel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnexporterexcel.IconColor = System.Drawing.Color.White;
            this.btnexporterexcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnexporterexcel.IconSize = 30;
            this.btnexporterexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexporterexcel.Location = new System.Drawing.Point(1039, 357);
            this.btnexporterexcel.Name = "btnexporterexcel";
            this.btnexporterexcel.Size = new System.Drawing.Size(99, 136);
            this.btnexporterexcel.TabIndex = 102;
            this.btnexporterexcel.Text = "Exportar Excel";
            this.btnexporterexcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnexporterexcel.UseVisualStyleBackColor = false;
            this.btnexporterexcel.Click += new System.EventHandler(this.btnexporterexcel_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Transparent;
            this.btneliminar.BackgroundImage = global::CapaPresentacion.Properties.Resources.eliminarusuario;
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btneliminar.IconColor = System.Drawing.Color.White;
            this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneliminar.IconSize = 50;
            this.btneliminar.Location = new System.Drawing.Point(1006, 38);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(90, 103);
            this.btneliminar.TabIndex = 101;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Transparent;
            this.btnguardar.BackgroundImage = global::CapaPresentacion.Properties.Resources.agregarusuario;
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnguardar.IconColor = System.Drawing.Color.White;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 50;
            this.btnguardar.Location = new System.Drawing.Point(900, 38);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(90, 103);
            this.btnguardar.TabIndex = 99;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(10, 176);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(20, 20);
            this.txtindice.TabIndex = 98;
            this.txtindice.Text = "-1";
            this.txtindice.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(36, 176);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(20, 20);
            this.txtid.TabIndex = 92;
            this.txtid.Text = "0";
            this.txtid.Visible = false;
            // 
            // dgvdatos
            // 
            this.dgvdatos.AllowUserToAddRows = false;
            this.dgvdatos.BackgroundColor = System.Drawing.Color.Black;
            this.dgvdatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.Id,
            this.Documento,
            this.RazonSocial,
            this.Correo,
            this.Telefono,
            this.EstadoValor,
            this.Estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdatos.GridColor = System.Drawing.Color.Black;
            this.dgvdatos.Location = new System.Drawing.Point(241, 262);
            this.dgvdatos.MultiSelect = false;
            this.dgvdatos.Name = "dgvdatos";
            this.dgvdatos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdatos.RowTemplate.Height = 28;
            this.dgvdatos.Size = new System.Drawing.Size(749, 360);
            this.dgvdatos.TabIndex = 90;
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
            // Documento
            // 
            this.Documento.HeaderText = "Nro. Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 150;
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Razon Social";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            this.RazonSocial.Width = 180;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 150;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
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
            // txtdocumento
            // 
            this.txtdocumento.BackColor = System.Drawing.Color.Black;
            this.txtdocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdocumento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocumento.ForeColor = System.Drawing.Color.Silver;
            this.txtdocumento.Location = new System.Drawing.Point(116, 77);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(224, 20);
            this.txtdocumento.TabIndex = 103;
            this.txtdocumento.Text = "DOCUMENTO";
            // 
            // txtrazonsocial
            // 
            this.txtrazonsocial.BackColor = System.Drawing.Color.Black;
            this.txtrazonsocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrazonsocial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrazonsocial.ForeColor = System.Drawing.Color.Silver;
            this.txtrazonsocial.Location = new System.Drawing.Point(116, 121);
            this.txtrazonsocial.Name = "txtrazonsocial";
            this.txtrazonsocial.Size = new System.Drawing.Size(224, 20);
            this.txtrazonsocial.TabIndex = 104;
            this.txtrazonsocial.Text = "RAZON SOCIAL";
            // 
            // txtcorreo
            // 
            this.txtcorreo.BackColor = System.Drawing.Color.Black;
            this.txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.ForeColor = System.Drawing.Color.Silver;
            this.txtcorreo.Location = new System.Drawing.Point(401, 57);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(224, 20);
            this.txtcorreo.TabIndex = 105;
            this.txtcorreo.Text = "CORREO";
            // 
            // txttelefono
            // 
            this.txttelefono.BackColor = System.Drawing.Color.Black;
            this.txttelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.ForeColor = System.Drawing.Color.Silver;
            this.txttelefono.Location = new System.Drawing.Point(401, 97);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(224, 20);
            this.txttelefono.TabIndex = 106;
            this.txttelefono.Text = "TELEFONO";
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
            this.btnlimpiarbuscador.Location = new System.Drawing.Point(883, 638);
            this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            this.btnlimpiarbuscador.Size = new System.Drawing.Size(77, 48);
            this.btnlimpiarbuscador.TabIndex = 111;
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
            this.btnbuscar.Location = new System.Drawing.Point(795, 638);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(77, 48);
            this.btnbuscar.TabIndex = 110;
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click_1);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.Location = new System.Drawing.Point(564, 645);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(208, 32);
            this.txtbusqueda.TabIndex = 109;
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(391, 645);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(167, 31);
            this.cbobusqueda.TabIndex = 108;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Italic);
            this.label11.Location = new System.Drawing.Point(281, 648);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 25);
            this.label11.TabIndex = 107;
            this.label11.Text = "Buscar por:";
            // 
            // cboestado
            // 
            this.cboestado.BackColor = System.Drawing.Color.Black;
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboestado.ForeColor = System.Drawing.Color.Yellow;
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(481, 146);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(224, 29);
            this.cboestado.TabIndex = 113;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(401, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 112;
            this.label8.Text = "ESTADO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(373, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 42);
            this.label1.TabIndex = 114;
            this.label1.Text = "Registro de Proveedores";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.btnminimizar);
            this.panel1.Controls.Add(this.Cerrar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnLimpiarDatos);
            this.panel1.Controls.Add(this.iramodulos);
            this.panel1.Controls.Add(this.cboestado);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtdocumento);
            this.panel1.Controls.Add(this.txtrazonsocial);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.btneliminar);
            this.panel1.Controls.Add(this.txtindice);
            this.panel1.Controls.Add(this.btnguardar);
            this.panel1.Controls.Add(this.txtcorreo);
            this.panel1.Controls.Add(this.txttelefono);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 199);
            this.panel1.TabIndex = 115;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Image = global::CapaPresentacion.Properties.Resources.menos;
            this.pictureBox4.Location = new System.Drawing.Point(116, 143);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(225, 10);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 124;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.menos;
            this.pictureBox2.Location = new System.Drawing.Point(116, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(225, 10);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 123;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.menos;
            this.pictureBox1.Location = new System.Drawing.Point(400, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 122;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.menos;
            this.pictureBox3.Location = new System.Drawing.Point(400, 79);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(225, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 121;
            this.pictureBox3.TabStop = false;
            // 
            // btnminimizar
            // 
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = global::CapaPresentacion.Properties.Resources.minimizar;
            this.btnminimizar.Location = new System.Drawing.Point(1122, 4);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(30, 30);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnminimizar.TabIndex = 120;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cerrar.Image = global::CapaPresentacion.Properties.Resources.cerca;
            this.Cerrar.Location = new System.Drawing.Point(1158, 4);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(30, 30);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cerrar.TabIndex = 119;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(47, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 118;
            this.label2.Text = "Ir a Modulos";
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
            this.btnLimpiarDatos.Location = new System.Drawing.Point(886, 147);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(224, 41);
            this.btnLimpiarDatos.TabIndex = 116;
            this.btnLimpiarDatos.Text = "Limpiar Datos";
            this.btnLimpiarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarDatos.UseVisualStyleBackColor = false;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click_1);
            // 
            // iramodulos
            // 
            this.iramodulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iramodulos.Image = global::CapaPresentacion.Properties.Resources.VolveraModulos;
            this.iramodulos.Location = new System.Drawing.Point(0, 0);
            this.iramodulos.Name = "iramodulos";
            this.iramodulos.Size = new System.Drawing.Size(50, 50);
            this.iramodulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iramodulos.TabIndex = 117;
            this.iramodulos.TabStop = false;
            this.iramodulos.Click += new System.EventHandler(this.iramodulos_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Italic);
            this.label10.Location = new System.Drawing.Point(-7, 199);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(307, 50);
            this.label10.TabIndex = 116;
            this.label10.Text = "Lista de Proveedores";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // formProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnlimpiarbuscador);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnexporterexcel);
            this.Controls.Add(this.dgvdatos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmProveedores_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iramodulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnexporterexcel;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridView dgvdatos;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.TextBox txtdocumento;
        private System.Windows.Forms.TextBox txtrazonsocial;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txttelefono;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnLimpiarDatos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox iramodulos;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}