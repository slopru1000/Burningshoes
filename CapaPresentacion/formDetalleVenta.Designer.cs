namespace CapaPresentacion
{
    partial class formDetalleVenta
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
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnexporterexcel = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmontototal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnumerodocumento = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtdoccliente = new System.Windows.Forms.TextBox();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttipodocumento = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnborrar = new FontAwesome.Sharp.IconButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.label26 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.iramodulos = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmontopago = new System.Windows.Forms.TextBox();
            this.txtmontocambio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iramodulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.Black;
            this.dgvdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.SubTotal,
            this.btneliminar});
            this.dgvdata.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.GridColor = System.Drawing.Color.Black;
            this.dgvdata.Location = new System.Drawing.Point(29, 64);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(582, 198);
            this.dgvdata.TabIndex = 223;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 200;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 130;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // btneliminar
            // 
            this.btneliminar.HeaderText = "";
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.ReadOnly = true;
            this.btneliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btneliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btneliminar.Width = 35;
            // 
            // btnexporterexcel
            // 
            this.btnexporterexcel.BackColor = System.Drawing.Color.Transparent;
            this.btnexporterexcel.BackgroundImage = global::CapaPresentacion.Properties.Resources.descargarpdf;
            this.btnexporterexcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnexporterexcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexporterexcel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnexporterexcel.FlatAppearance.BorderSize = 0;
            this.btnexporterexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexporterexcel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexporterexcel.ForeColor = System.Drawing.Color.Black;
            this.btnexporterexcel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnexporterexcel.IconColor = System.Drawing.Color.White;
            this.btnexporterexcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnexporterexcel.IconSize = 30;
            this.btnexporterexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexporterexcel.Location = new System.Drawing.Point(349, 361);
            this.btnexporterexcel.Name = "btnexporterexcel";
            this.btnexporterexcel.Size = new System.Drawing.Size(99, 159);
            this.btnexporterexcel.TabIndex = 232;
            this.btnexporterexcel.Text = "Descargar PDF";
            this.btnexporterexcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnexporterexcel.UseVisualStyleBackColor = false;
            this.btnexporterexcel.Click += new System.EventHandler(this.btnexporterexcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(644, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 27);
            this.label1.TabIndex = 230;
            this.label1.Text = "Monto Total:";
            // 
            // txtmontototal
            // 
            this.txtmontototal.BackColor = System.Drawing.Color.Black;
            this.txtmontototal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmontototal.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.txtmontototal.ForeColor = System.Drawing.Color.White;
            this.txtmontototal.Location = new System.Drawing.Point(635, 94);
            this.txtmontototal.Name = "txtmontototal";
            this.txtmontototal.ReadOnly = true;
            this.txtmontototal.Size = new System.Drawing.Size(139, 50);
            this.txtmontototal.TabIndex = 231;
            this.txtmontototal.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.txtnumerodocumento);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtdoccliente);
            this.groupBox2.Controls.Add(this.txtnombrecliente);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(507, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 159);
            this.groupBox2.TabIndex = 229;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Cliente";
            // 
            // txtnumerodocumento
            // 
            this.txtnumerodocumento.Location = new System.Drawing.Point(522, 39);
            this.txtnumerodocumento.Name = "txtnumerodocumento";
            this.txtnumerodocumento.Size = new System.Drawing.Size(54, 26);
            this.txtnumerodocumento.TabIndex = 194;
            this.txtnumerodocumento.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Black;
            this.label14.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 17);
            this.label14.TabIndex = 84;
            this.label14.Text = "Documento:";
            // 
            // txtdoccliente
            // 
            this.txtdoccliente.BackColor = System.Drawing.Color.Black;
            this.txtdoccliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdoccliente.ForeColor = System.Drawing.Color.White;
            this.txtdoccliente.Location = new System.Drawing.Point(11, 59);
            this.txtdoccliente.Name = "txtdoccliente";
            this.txtdoccliente.ReadOnly = true;
            this.txtdoccliente.Size = new System.Drawing.Size(200, 22);
            this.txtdoccliente.TabIndex = 85;
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.BackColor = System.Drawing.Color.Black;
            this.txtnombrecliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrecliente.ForeColor = System.Drawing.Color.White;
            this.txtnombrecliente.Location = new System.Drawing.Point(10, 104);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.ReadOnly = true;
            this.txtnombrecliente.Size = new System.Drawing.Size(201, 22);
            this.txtnombrecliente.TabIndex = 86;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Black;
            this.label15.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 17);
            this.label15.TabIndex = 83;
            this.label15.Text = "Nombre Cliente:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.txtusuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txttipodocumento);
            this.groupBox1.Controls.Add(this.txtfecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 361);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 156);
            this.groupBox1.TabIndex = 228;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Venta";
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.Black;
            this.txtusuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.ForeColor = System.Drawing.Color.White;
            this.txtusuario.Location = new System.Drawing.Point(9, 123);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.ReadOnly = true;
            this.txtusuario.Size = new System.Drawing.Size(201, 22);
            this.txtusuario.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 92;
            this.label2.Text = "Usuario:";
            // 
            // txttipodocumento
            // 
            this.txttipodocumento.BackColor = System.Drawing.Color.Black;
            this.txttipodocumento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipodocumento.ForeColor = System.Drawing.Color.White;
            this.txttipodocumento.Location = new System.Drawing.Point(9, 81);
            this.txttipodocumento.Name = "txttipodocumento";
            this.txttipodocumento.ReadOnly = true;
            this.txttipodocumento.Size = new System.Drawing.Size(201, 22);
            this.txttipodocumento.TabIndex = 87;
            // 
            // txtfecha
            // 
            this.txtfecha.BackColor = System.Drawing.Color.Black;
            this.txtfecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha.ForeColor = System.Drawing.Color.White;
            this.txtfecha.Location = new System.Drawing.Point(9, 39);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.ReadOnly = true;
            this.txtfecha.Size = new System.Drawing.Size(201, 22);
            this.txtfecha.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 89;
            this.label3.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 91;
            this.label4.Text = "Tipo Documento:";
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.Color.Transparent;
            this.btnborrar.BackgroundImage = global::CapaPresentacion.Properties.Resources.limpiar;
            this.btnborrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnborrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrar.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnborrar.IconColor = System.Drawing.Color.Black;
            this.btnborrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnborrar.IconSize = 30;
            this.btnborrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnborrar.Location = new System.Drawing.Point(505, 268);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(75, 87);
            this.btnborrar.TabIndex = 227;
            this.btnborrar.Text = "Limpiar";
            this.btnborrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnborrar.UseVisualStyleBackColor = false;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click_1);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnbuscar.BackgroundImage = global::CapaPresentacion.Properties.Resources.buscar;
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 30;
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnbuscar.Location = new System.Drawing.Point(427, 268);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(72, 87);
            this.btnbuscar.TabIndex = 225;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click_1);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Italic);
            this.label26.Location = new System.Drawing.Point(24, 291);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(195, 27);
            this.label26.TabIndex = 226;
            this.label26.Text = "Numero Documento:";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.BackColor = System.Drawing.Color.Black;
            this.txtbusqueda.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.ForeColor = System.Drawing.Color.White;
            this.txtbusqueda.Location = new System.Drawing.Point(225, 290);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(160, 33);
            this.txtbusqueda.TabIndex = 224;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Italic);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(52, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 25);
            this.label10.TabIndex = 237;
            this.label10.Text = "Ir a Modulos";
            // 
            // iramodulos
            // 
            this.iramodulos.BackColor = System.Drawing.Color.Black;
            this.iramodulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iramodulos.Image = global::CapaPresentacion.Properties.Resources.VolveraModulos;
            this.iramodulos.Location = new System.Drawing.Point(0, 0);
            this.iramodulos.Name = "iramodulos";
            this.iramodulos.Size = new System.Drawing.Size(50, 50);
            this.iramodulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iramodulos.TabIndex = 236;
            this.iramodulos.TabStop = false;
            this.iramodulos.Click += new System.EventHandler(this.iramodulos_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = global::CapaPresentacion.Properties.Resources.signo_menos_de_una_linea_en_posicion_horizontal;
            this.btnminimizar.Location = new System.Drawing.Point(719, 4);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(30, 30);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnminimizar.TabIndex = 235;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = global::CapaPresentacion.Properties.Resources.x;
            this.btncerrar.Location = new System.Drawing.Point(755, 4);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(30, 30);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btncerrar.TabIndex = 234;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(285, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(236, 48);
            this.label9.TabIndex = 233;
            this.label9.Text = "Detalle Venta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(644, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 26);
            this.label6.TabIndex = 240;
            this.label6.Text = "Monto Pago:";
            // 
            // txtmontopago
            // 
            this.txtmontopago.BackColor = System.Drawing.Color.Black;
            this.txtmontopago.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.txtmontopago.ForeColor = System.Drawing.Color.White;
            this.txtmontopago.Location = new System.Drawing.Point(635, 176);
            this.txtmontopago.Name = "txtmontopago";
            this.txtmontopago.ReadOnly = true;
            this.txtmontopago.Size = new System.Drawing.Size(139, 57);
            this.txtmontopago.TabIndex = 241;
            this.txtmontopago.Text = "0";
            // 
            // txtmontocambio
            // 
            this.txtmontocambio.BackColor = System.Drawing.Color.Black;
            this.txtmontocambio.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.txtmontocambio.ForeColor = System.Drawing.Color.White;
            this.txtmontocambio.Location = new System.Drawing.Point(635, 265);
            this.txtmontocambio.Name = "txtmontocambio";
            this.txtmontocambio.ReadOnly = true;
            this.txtmontocambio.Size = new System.Drawing.Size(139, 57);
            this.txtmontocambio.TabIndex = 239;
            this.txtmontocambio.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(635, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 26);
            this.label5.TabIndex = 238;
            this.label5.Text = "Monto Cambio:";
            // 
            // formDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(788, 526);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmontocambio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.iramodulos);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnexporterexcel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmontototal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.txtmontopago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formDetalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetalleVenta";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmDetalleVenta_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iramodulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton btnexporterexcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmontototal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtnumerodocumento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtdoccliente;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttipodocumento;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnborrar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox iramodulos;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmontopago;
        private System.Windows.Forms.TextBox txtmontocambio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
    }
}