namespace CapaPresentacion
{
    partial class formVentas2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdocumentocliente = new System.Windows.Forms.TextBox();
            this.btnbuscarcliente = new FontAwesome.Sharp.IconButton();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            this.txtidproveedor = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.iramodulos = new System.Windows.Forms.PictureBox();
            this.btnagregarproducto = new FontAwesome.Sharp.IconButton();
            this.btncrearventa = new FontAwesome.Sharp.IconButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.txtcodproducto = new System.Windows.Forms.TextBox();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.cbotipodocumento = new System.Windows.Forms.ComboBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttotalpagar = new System.Windows.Forms.TextBox();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtcambio = new System.Windows.Forms.TextBox();
            this.txtpagocon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iramodulos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 89;
            this.label3.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(7, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 21);
            this.label4.TabIndex = 91;
            this.label4.Text = "Tipo Documento:";
            // 
            // txtdocumentocliente
            // 
            this.txtdocumentocliente.BackColor = System.Drawing.Color.Black;
            this.txtdocumentocliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocumentocliente.ForeColor = System.Drawing.Color.White;
            this.txtdocumentocliente.Location = new System.Drawing.Point(9, 45);
            this.txtdocumentocliente.Name = "txtdocumentocliente";
            this.txtdocumentocliente.ReadOnly = true;
            this.txtdocumentocliente.Size = new System.Drawing.Size(177, 22);
            this.txtdocumentocliente.TabIndex = 85;
            // 
            // btnbuscarcliente
            // 
            this.btnbuscarcliente.BackColor = System.Drawing.Color.Black;
            this.btnbuscarcliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarcliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscarcliente.IconColor = System.Drawing.Color.White;
            this.btnbuscarcliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarcliente.IconSize = 18;
            this.btnbuscarcliente.Location = new System.Drawing.Point(192, 45);
            this.btnbuscarcliente.Name = "btnbuscarcliente";
            this.btnbuscarcliente.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnbuscarcliente.Size = new System.Drawing.Size(45, 27);
            this.btnbuscarcliente.TabIndex = 87;
            this.btnbuscarcliente.UseVisualStyleBackColor = false;
            this.btnbuscarcliente.Click += new System.EventHandler(this.btnbuscarcliente_Click);
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.BackColor = System.Drawing.Color.Black;
            this.txtnombrecliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrecliente.ForeColor = System.Drawing.Color.White;
            this.txtnombrecliente.Location = new System.Drawing.Point(9, 106);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.ReadOnly = true;
            this.txtnombrecliente.Size = new System.Drawing.Size(266, 22);
            this.txtnombrecliente.TabIndex = 86;
            // 
            // btnbuscarproducto
            // 
            this.btnbuscarproducto.BackColor = System.Drawing.Color.Black;
            this.btnbuscarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscarproducto.IconColor = System.Drawing.Color.White;
            this.btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarproducto.IconSize = 18;
            this.btnbuscarproducto.Location = new System.Drawing.Point(149, 42);
            this.btnbuscarproducto.Name = "btnbuscarproducto";
            this.btnbuscarproducto.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnbuscarproducto.Size = new System.Drawing.Size(37, 23);
            this.btnbuscarproducto.TabIndex = 2;
            this.btnbuscarproducto.UseVisualStyleBackColor = false;
            this.btnbuscarproducto.Click += new System.EventHandler(this.btnbuscarproducto_Click);
            // 
            // txtidproveedor
            // 
            this.txtidproveedor.Location = new System.Drawing.Point(243, 45);
            this.txtidproveedor.Name = "txtidproveedor";
            this.txtidproveedor.Size = new System.Drawing.Size(32, 27);
            this.txtidproveedor.TabIndex = 88;
            this.txtidproveedor.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label14.Location = new System.Drawing.Point(5, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(174, 21);
            this.label14.TabIndex = 84;
            this.label14.Text = "Número Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(375, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 45);
            this.label2.TabIndex = 218;
            this.label2.Text = "Registrar Venta";
            // 
            // txtcantidad
            // 
            this.txtcantidad.BackColor = System.Drawing.Color.Black;
            this.txtcantidad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.ForeColor = System.Drawing.Color.White;
            this.txtcantidad.Location = new System.Drawing.Point(670, 43);
            this.txtcantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtcantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(78, 22);
            this.txtcantidad.TabIndex = 6;
            this.txtcantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(665, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 98;
            this.label5.Text = "Cantidad:";
            // 
            // txtstock
            // 
            this.txtstock.BackColor = System.Drawing.Color.Black;
            this.txtstock.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstock.ForeColor = System.Drawing.Color.White;
            this.txtstock.Location = new System.Drawing.Point(548, 43);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(106, 22);
            this.txtstock.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label8.Location = new System.Drawing.Point(189, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 21);
            this.label8.TabIndex = 97;
            this.label8.Text = "Producto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.Location = new System.Drawing.Point(543, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 100;
            this.label7.Text = "Stock:";
            // 
            // txtprecio
            // 
            this.txtprecio.BackColor = System.Drawing.Color.Black;
            this.txtprecio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.ForeColor = System.Drawing.Color.White;
            this.txtprecio.Location = new System.Drawing.Point(402, 43);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(128, 22);
            this.txtprecio.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.Location = new System.Drawing.Point(397, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 99;
            this.label6.Text = "Precio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Italic);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(50, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 25);
            this.label10.TabIndex = 217;
            this.label10.Text = "Ir a Modulos";
            // 
            // iramodulos
            // 
            this.iramodulos.BackColor = System.Drawing.Color.Black;
            this.iramodulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iramodulos.Image = global::CapaPresentacion.Properties.Resources.VolveraModulos;
            this.iramodulos.Location = new System.Drawing.Point(0, -3);
            this.iramodulos.Name = "iramodulos";
            this.iramodulos.Size = new System.Drawing.Size(50, 50);
            this.iramodulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iramodulos.TabIndex = 216;
            this.iramodulos.TabStop = false;
            this.iramodulos.Click += new System.EventHandler(this.iramodulos_Click);
            // 
            // btnagregarproducto
            // 
            this.btnagregarproducto.BackColor = System.Drawing.Color.Black;
            this.btnagregarproducto.BackgroundImage = global::CapaPresentacion.Properties.Resources.añadirproducto;
            this.btnagregarproducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnagregarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregarproducto.FlatAppearance.BorderSize = 0;
            this.btnagregarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregarproducto.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarproducto.ForeColor = System.Drawing.Color.White;
            this.btnagregarproducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnagregarproducto.IconColor = System.Drawing.Color.ForestGreen;
            this.btnagregarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnagregarproducto.IconSize = 80;
            this.btnagregarproducto.Location = new System.Drawing.Point(1021, 112);
            this.btnagregarproducto.Name = "btnagregarproducto";
            this.btnagregarproducto.Size = new System.Drawing.Size(167, 140);
            this.btnagregarproducto.TabIndex = 223;
            this.btnagregarproducto.Text = "Agregar Producto";
            this.btnagregarproducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregarproducto.UseVisualStyleBackColor = false;
            this.btnagregarproducto.Click += new System.EventHandler(this.btnagregarproducto_Click);
            // 
            // btncrearventa
            // 
            this.btncrearventa.BackColor = System.Drawing.Color.Black;
            this.btncrearventa.BackgroundImage = global::CapaPresentacion.Properties.Resources.registrar;
            this.btncrearventa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncrearventa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncrearventa.FlatAppearance.BorderSize = 0;
            this.btncrearventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncrearventa.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrearventa.ForeColor = System.Drawing.Color.White;
            this.btncrearventa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btncrearventa.IconColor = System.Drawing.Color.DodgerBlue;
            this.btncrearventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncrearventa.IconSize = 70;
            this.btncrearventa.Location = new System.Drawing.Point(1049, 300);
            this.btncrearventa.Name = "btncrearventa";
            this.btncrearventa.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btncrearventa.Size = new System.Drawing.Size(118, 117);
            this.btncrearventa.TabIndex = 226;
            this.btncrearventa.Text = "Crear Venta";
            this.btncrearventa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncrearventa.UseVisualStyleBackColor = false;
            this.btncrearventa.Click += new System.EventHandler(this.btncrearventa_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtidproducto);
            this.groupBox3.Controls.Add(this.btnbuscarproducto);
            this.groupBox3.Controls.Add(this.txtcodproducto);
            this.groupBox3.Controls.Add(this.txtproducto);
            this.groupBox3.Controls.Add(this.txtcantidad);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtstock);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtprecio);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(32, 521);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(770, 78);
            this.groupBox3.TabIndex = 221;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion de Producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label9.Location = new System.Drawing.Point(4, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 21);
            this.label9.TabIndex = 96;
            this.label9.Text = "Cod. Producto:";
            // 
            // txtidproducto
            // 
            this.txtidproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidproducto.Location = new System.Drawing.Point(150, 19);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(32, 20);
            this.txtidproducto.TabIndex = 0;
            this.txtidproducto.Visible = false;
            // 
            // txtcodproducto
            // 
            this.txtcodproducto.BackColor = System.Drawing.Color.Black;
            this.txtcodproducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodproducto.ForeColor = System.Drawing.Color.White;
            this.txtcodproducto.Location = new System.Drawing.Point(9, 43);
            this.txtcodproducto.Name = "txtcodproducto";
            this.txtcodproducto.Size = new System.Drawing.Size(133, 22);
            this.txtcodproducto.TabIndex = 1;
            this.txtcodproducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodproducto_KeyDown);
            // 
            // txtproducto
            // 
            this.txtproducto.BackColor = System.Drawing.Color.Black;
            this.txtproducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproducto.ForeColor = System.Drawing.Color.White;
            this.txtproducto.Location = new System.Drawing.Point(193, 43);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.ReadOnly = true;
            this.txtproducto.Size = new System.Drawing.Size(195, 22);
            this.txtproducto.TabIndex = 3;
            // 
            // cbotipodocumento
            // 
            this.cbotipodocumento.BackColor = System.Drawing.Color.Black;
            this.cbotipodocumento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbotipodocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipodocumento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotipodocumento.ForeColor = System.Drawing.Color.White;
            this.cbotipodocumento.FormattingEnabled = true;
            this.cbotipodocumento.Location = new System.Drawing.Point(9, 106);
            this.cbotipodocumento.Name = "cbotipodocumento";
            this.cbotipodocumento.Size = new System.Drawing.Size(188, 25);
            this.cbotipodocumento.TabIndex = 93;
            // 
            // btncerrar
            // 
            this.btncerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = global::CapaPresentacion.Properties.Resources.x;
            this.btncerrar.Location = new System.Drawing.Point(1158, 4);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(30, 30);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btncerrar.TabIndex = 227;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label15.Location = new System.Drawing.Point(4, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(156, 21);
            this.label15.TabIndex = 83;
            this.label15.Text = "Nombre Completo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(820, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 224;
            this.label1.Text = "Total a Pagar:";
            // 
            // txttotalpagar
            // 
            this.txttotalpagar.BackColor = System.Drawing.Color.Black;
            this.txttotalpagar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttotalpagar.Font = new System.Drawing.Font("Century Gothic", 28F);
            this.txttotalpagar.ForeColor = System.Drawing.Color.White;
            this.txttotalpagar.Location = new System.Drawing.Point(820, 545);
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.ReadOnly = true;
            this.txttotalpagar.Size = new System.Drawing.Size(117, 46);
            this.txttotalpagar.TabIndex = 225;
            this.txttotalpagar.Text = "0";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.Black;
            this.dgvdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.SubTotal,
            this.btneliminar});
            this.dgvdata.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvdata.GridColor = System.Drawing.Color.Black;
            this.dgvdata.Location = new System.Drawing.Point(337, 112);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(607, 326);
            this.dgvdata.TabIndex = 222;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            this.IdProducto.Width = 150;
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
            // btnminimizar
            // 
            this.btnminimizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = global::CapaPresentacion.Properties.Resources.signo_menos_de_una_linea_en_posicion_horizontal;
            this.btnminimizar.Location = new System.Drawing.Point(1118, 4);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(30, 30);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnminimizar.TabIndex = 228;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.txtidproveedor);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtdocumentocliente);
            this.groupBox2.Controls.Add(this.btnbuscarcliente);
            this.groupBox2.Controls.Add(this.txtnombrecliente);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(32, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 138);
            this.groupBox2.TabIndex = 220;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Cliente";
            // 
            // txtfecha
            // 
            this.txtfecha.BackColor = System.Drawing.Color.Black;
            this.txtfecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha.ForeColor = System.Drawing.Color.White;
            this.txtfecha.Location = new System.Drawing.Point(10, 51);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.ReadOnly = true;
            this.txtfecha.Size = new System.Drawing.Size(119, 22);
            this.txtfecha.TabIndex = 90;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.txtfecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbotipodocumento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(32, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 157);
            this.groupBox1.TabIndex = 219;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Venta";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Italic);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(944, 519);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 23);
            this.label11.TabIndex = 229;
            this.label11.Text = "Paga con:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Italic);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(1067, 520);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 23);
            this.label12.TabIndex = 231;
            this.label12.Text = "Cambio:";
            // 
            // txtcambio
            // 
            this.txtcambio.BackColor = System.Drawing.Color.Black;
            this.txtcambio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcambio.Font = new System.Drawing.Font("Century Gothic", 28F);
            this.txtcambio.ForeColor = System.Drawing.Color.White;
            this.txtcambio.Location = new System.Drawing.Point(1067, 545);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.ReadOnly = true;
            this.txtcambio.Size = new System.Drawing.Size(117, 46);
            this.txtcambio.TabIndex = 232;
            // 
            // txtpagocon
            // 
            this.txtpagocon.BackColor = System.Drawing.Color.Black;
            this.txtpagocon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpagocon.Font = new System.Drawing.Font("Century Gothic", 28F);
            this.txtpagocon.ForeColor = System.Drawing.Color.White;
            this.txtpagocon.Location = new System.Drawing.Point(944, 545);
            this.txtpagocon.Name = "txtpagocon";
            this.txtpagocon.Size = new System.Drawing.Size(117, 46);
            this.txtpagocon.TabIndex = 233;
            this.txtpagocon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpagocon_KeyDown_1);
            this.txtpagocon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpagocon_KeyPress_1);
            // 
            // formVentas2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.txtpagocon);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtcambio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.iramodulos);
            this.Controls.Add(this.btnagregarproducto);
            this.Controls.Add(this.btncrearventa);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttotalpagar);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formVentas2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVentas2";
            this.Load += new System.EventHandler(this.frmVentas2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmVentas2_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iramodulos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdocumentocliente;
        private FontAwesome.Sharp.IconButton btnbuscarcliente;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
        private System.Windows.Forms.TextBox txtidproveedor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox iramodulos;
        private FontAwesome.Sharp.IconButton btnagregarproducto;
        private FontAwesome.Sharp.IconButton btncrearventa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.TextBox txtcodproducto;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.ComboBox cbotipodocumento;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttotalpagar;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtcambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
        private System.Windows.Forms.TextBox txtpagocon;
    }
}