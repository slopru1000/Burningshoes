namespace CapaPresentacion
{
    partial class formUsuarios
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
            this.dgvdatos = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarDatos = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cborol = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtconfirmarclave = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtnombrecompleto = new System.Windows.Forms.TextBox();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iramodulos = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iramodulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdatos
            // 
            this.dgvdatos.AllowUserToAddRows = false;
            this.dgvdatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdatos.BackgroundColor = System.Drawing.Color.Black;
            this.dgvdatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.Id,
            this.Documento,
            this.NombreCompleto,
            this.Correo,
            this.Clave,
            this.IdRol,
            this.Rol,
            this.EstadoValor,
            this.Estado});
            this.dgvdatos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdatos.GridColor = System.Drawing.Color.Yellow;
            this.dgvdatos.Location = new System.Drawing.Point(51, 268);
            this.dgvdatos.MultiSelect = false;
            this.dgvdatos.Name = "dgvdatos";
            this.dgvdatos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdatos.RowTemplate.Height = 28;
            this.dgvdatos.Size = new System.Drawing.Size(1088, 370);
            this.dgvdatos.TabIndex = 19;
            this.dgvdatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdatos_CellContentClick);
            this.dgvdatos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdatos_CellPainting);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Italic);
            this.label10.Location = new System.Drawing.Point(3, 200);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(307, 50);
            this.label10.TabIndex = 20;
            this.label10.Text = "Lista de Usuarios";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Italic);
            this.label11.Location = new System.Drawing.Point(274, 665);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "Buscar por:";
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(384, 662);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(167, 31);
            this.cbobusqueda.TabIndex = 23;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.Location = new System.Drawing.Point(557, 662);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(208, 32);
            this.txtbusqueda.TabIndex = 24;
            // 
            // btnlimpiarbuscador
            // 
            this.btnlimpiarbuscador.BackColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarbuscador.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnlimpiarbuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiarbuscador.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiarbuscador.IconColor = System.Drawing.Color.Yellow;
            this.btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiarbuscador.IconSize = 40;
            this.btnlimpiarbuscador.Location = new System.Drawing.Point(876, 655);
            this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            this.btnlimpiarbuscador.Size = new System.Drawing.Size(77, 48);
            this.btnlimpiarbuscador.TabIndex = 26;
            this.btnlimpiarbuscador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiarbuscador.UseVisualStyleBackColor = false;
            this.btnlimpiarbuscador.Click += new System.EventHandler(this.btnlimpiarbuscador_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Black;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscar.IconColor = System.Drawing.Color.Yellow;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 40;
            this.btnbuscar.Location = new System.Drawing.Point(779, 655);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(77, 48);
            this.btnbuscar.TabIndex = 25;
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Transparent;
            this.btneliminar.BackgroundImage = global::CapaPresentacion.Properties.Resources.eliminarusuario;
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btneliminar.IconColor = System.Drawing.Color.White;
            this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneliminar.IconSize = 50;
            this.btneliminar.Location = new System.Drawing.Point(1071, 63);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(90, 113);
            this.btneliminar.TabIndex = 63;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click_1);
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
            this.btnLimpiarDatos.Location = new System.Drawing.Point(670, 137);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(224, 41);
            this.btnLimpiarDatos.TabIndex = 62;
            this.btnLimpiarDatos.Text = "Limpiar Datos";
            this.btnLimpiarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarDatos.UseVisualStyleBackColor = false;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click_1);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Transparent;
            this.btnguardar.BackgroundImage = global::CapaPresentacion.Properties.Resources.agregarusuario;
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnguardar.IconColor = System.Drawing.Color.White;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 50;
            this.btnguardar.Location = new System.Drawing.Point(941, 63);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(90, 113);
            this.btnguardar.TabIndex = 61;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click_1);
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(9, 171);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(20, 20);
            this.txtindice.TabIndex = 60;
            this.txtindice.Text = "-1";
            this.txtindice.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(35, 171);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(20, 20);
            this.txtid.TabIndex = 59;
            this.txtid.Text = "0";
            this.txtid.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Italic);
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(373, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(290, 42);
            this.label9.TabIndex = 58;
            this.label9.Text = "Registro de Usuario";
            // 
            // cboestado
            // 
            this.cboestado.BackColor = System.Drawing.Color.Black;
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboestado.ForeColor = System.Drawing.Color.Yellow;
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(670, 94);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(224, 29);
            this.cboestado.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(591, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 56;
            this.label8.Text = "ESTADO";
            // 
            // cborol
            // 
            this.cborol.BackColor = System.Drawing.Color.Black;
            this.cborol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cborol.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cborol.ForeColor = System.Drawing.Color.Yellow;
            this.cborol.FormattingEnabled = true;
            this.cborol.Location = new System.Drawing.Point(670, 50);
            this.cborol.Name = "cborol";
            this.cborol.Size = new System.Drawing.Size(224, 29);
            this.cborol.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(624, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 21);
            this.label7.TabIndex = 54;
            this.label7.Text = "ROL";
            // 
            // txtconfirmarclave
            // 
            this.txtconfirmarclave.BackColor = System.Drawing.Color.Black;
            this.txtconfirmarclave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtconfirmarclave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmarclave.ForeColor = System.Drawing.Color.Silver;
            this.txtconfirmarclave.Location = new System.Drawing.Point(327, 137);
            this.txtconfirmarclave.Name = "txtconfirmarclave";
            this.txtconfirmarclave.Size = new System.Drawing.Size(224, 20);
            this.txtconfirmarclave.TabIndex = 53;
            this.txtconfirmarclave.Text = "CONFIRMAR CONTRASEÑA";
            // 
            // txtclave
            // 
            this.txtclave.BackColor = System.Drawing.Color.Black;
            this.txtclave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtclave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave.ForeColor = System.Drawing.Color.Silver;
            this.txtclave.Location = new System.Drawing.Point(327, 95);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(224, 20);
            this.txtclave.TabIndex = 52;
            this.txtclave.Text = "CONTRASEÑA";
            // 
            // txtcorreo
            // 
            this.txtcorreo.BackColor = System.Drawing.Color.Black;
            this.txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.ForeColor = System.Drawing.Color.Silver;
            this.txtcorreo.Location = new System.Drawing.Point(327, 53);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(224, 20);
            this.txtcorreo.TabIndex = 51;
            this.txtcorreo.Text = "CORREO";
            // 
            // txtnombrecompleto
            // 
            this.txtnombrecompleto.BackColor = System.Drawing.Color.Black;
            this.txtnombrecompleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombrecompleto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrecompleto.ForeColor = System.Drawing.Color.Silver;
            this.txtnombrecompleto.Location = new System.Drawing.Point(52, 116);
            this.txtnombrecompleto.Name = "txtnombrecompleto";
            this.txtnombrecompleto.Size = new System.Drawing.Size(224, 20);
            this.txtnombrecompleto.TabIndex = 50;
            this.txtnombrecompleto.Text = "NOMBRE COMPLETO";
            // 
            // txtdocumento
            // 
            this.txtdocumento.BackColor = System.Drawing.Color.Black;
            this.txtdocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdocumento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocumento.ForeColor = System.Drawing.Color.Silver;
            this.txtdocumento.Location = new System.Drawing.Point(52, 73);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(224, 20);
            this.txtdocumento.TabIndex = 49;
            this.txtdocumento.Text = "DOCUMENTO";
            this.txtdocumento.TextChanged += new System.EventHandler(this.txtdocumento_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iramodulos);
            this.panel1.Controls.Add(this.btnminimizar);
            this.panel1.Controls.Add(this.Cerrar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btneliminar);
            this.panel1.Controls.Add(this.txtindice);
            this.panel1.Controls.Add(this.btnLimpiarDatos);
            this.panel1.Controls.Add(this.btnguardar);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.txtdocumento);
            this.panel1.Controls.Add(this.cboestado);
            this.panel1.Controls.Add(this.txtnombrecompleto);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtcorreo);
            this.panel1.Controls.Add(this.cborol);
            this.panel1.Controls.Add(this.txtclave);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtconfirmarclave);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 199);
            this.panel1.TabIndex = 64;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Enabled = false;
            this.pictureBox5.Image = global::CapaPresentacion.Properties.Resources.menos;
            this.pictureBox5.Location = new System.Drawing.Point(327, 157);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(225, 10);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 72;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Image = global::CapaPresentacion.Properties.Resources.menos;
            this.pictureBox4.Location = new System.Drawing.Point(327, 115);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(225, 10);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 71;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.menos;
            this.pictureBox3.Location = new System.Drawing.Point(328, 73);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(225, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 70;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.menos;
            this.pictureBox1.Location = new System.Drawing.Point(51, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.menos;
            this.pictureBox2.Location = new System.Drawing.Point(51, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(225, 10);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 68;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(47, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 67;
            this.label1.Text = "Ir a Modulos";
            // 
            // iramodulos
            // 
            this.iramodulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iramodulos.Image = global::CapaPresentacion.Properties.Resources.VolveraModulos;
            this.iramodulos.Location = new System.Drawing.Point(0, 0);
            this.iramodulos.Name = "iramodulos";
            this.iramodulos.Size = new System.Drawing.Size(50, 50);
            this.iramodulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iramodulos.TabIndex = 66;
            this.iramodulos.TabStop = false;
            this.iramodulos.Click += new System.EventHandler(this.iramodulos_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = global::CapaPresentacion.Properties.Resources.minimizar;
            this.btnminimizar.Location = new System.Drawing.Point(1131, 3);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(30, 30);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnminimizar.TabIndex = 65;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cerrar.Image = global::CapaPresentacion.Properties.Resources.cerca;
            this.Cerrar.Location = new System.Drawing.Point(1167, 3);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(30, 30);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cerrar.TabIndex = 64;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnseleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Id
            // 
            this.Id.HeaderText = "IdUsuario";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Nro. Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Visible = false;
            // 
            // IdRol
            // 
            this.IdRol.HeaderText = "IdRol";
            this.IdRol.Name = "IdRol";
            this.IdRol.ReadOnly = true;
            this.IdRol.Visible = false;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
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
            // formUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnlimpiarbuscador);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvdatos);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmUsuarios_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iramodulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvdatos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.TextBox txtbusqueda;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnLimpiarDatos;
        private FontAwesome.Sharp.IconButton btnguardar;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cborol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtconfirmarclave;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtnombrecompleto;
        private System.Windows.Forms.TextBox txtdocumento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.PictureBox iramodulos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}