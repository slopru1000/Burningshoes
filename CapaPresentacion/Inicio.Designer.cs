namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuusuarios = new FontAwesome.Sharp.IconMenuItem();
            this.submenuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuroles = new System.Windows.Forms.ToolStripMenuItem();
            this.menucompras = new FontAwesome.Sharp.IconMenuItem();
            this.submenuregistrarcompra = new FontAwesome.Sharp.IconMenuItem();
            this.submenuverdetallecompra = new FontAwesome.Sharp.IconMenuItem();
            this.submenuhistorialdecompras = new System.Windows.Forms.ToolStripMenuItem();
            this.menuinventario = new FontAwesome.Sharp.IconMenuItem();
            this.submenucategoria = new FontAwesome.Sharp.IconMenuItem();
            this.submenuproducto = new FontAwesome.Sharp.IconMenuItem();
            this.submenunegocio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuclientes = new FontAwesome.Sharp.IconMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.menu2 = new System.Windows.Forms.MenuStrip();
            this.menuproveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menuventas = new FontAwesome.Sharp.IconMenuItem();
            this.submenuregistrarventa = new FontAwesome.Sharp.IconMenuItem();
            this.submenuverdetalleventa = new FontAwesome.Sharp.IconMenuItem();
            this.menureportes = new FontAwesome.Sharp.IconMenuItem();
            this.botoncerrarsesion = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            this.menu2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(316, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 80);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.DarkGray;
            this.lblusuario.Location = new System.Drawing.Point(6, 52);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(100, 26);
            this.lblusuario.TabIndex = 5;
            this.lblusuario.Text = "lblusuario";
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.DarkGray;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.GripMargin = new System.Windows.Forms.Padding(3);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuusuarios,
            this.menucompras,
            this.menuinventario,
            this.menuclientes});
            this.menu.Location = new System.Drawing.Point(57, 120);
            this.menu.Margin = new System.Windows.Forms.Padding(2);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(1162, 282);
            this.menu.TabIndex = 6;
            this.menu.Text = "menuStrip1";
            // 
            // menuusuarios
            // 
            this.menuusuarios.AutoSize = false;
            this.menuusuarios.BackColor = System.Drawing.Color.Transparent;
            this.menuusuarios.BackgroundImage = global::CapaPresentacion.Properties.Resources.MenuUsusariosfinal;
            this.menuusuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuusuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuUsuarios,
            this.submenuroles});
            this.menuusuarios.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuusuarios.ForeColor = System.Drawing.Color.Black;
            this.menuusuarios.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menuusuarios.IconColor = System.Drawing.Color.Black;
            this.menuusuarios.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.menuusuarios.IconSize = 1;
            this.menuusuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuusuarios.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuusuarios.Name = "menuusuarios";
            this.menuusuarios.ShowShortcutKeys = false;
            this.menuusuarios.Size = new System.Drawing.Size(250, 250);
            this.menuusuarios.Text = "Administracion";
            this.menuusuarios.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menuusuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // submenuUsuarios
            // 
            this.submenuUsuarios.Name = "submenuUsuarios";
            this.submenuUsuarios.Size = new System.Drawing.Size(161, 30);
            this.submenuUsuarios.Text = "Usuarios";
            this.submenuUsuarios.Click += new System.EventHandler(this.submenuUsuarios_Click);
            // 
            // submenuroles
            // 
            this.submenuroles.Name = "submenuroles";
            this.submenuroles.Size = new System.Drawing.Size(161, 30);
            this.submenuroles.Text = "Roles";
            this.submenuroles.Click += new System.EventHandler(this.submenuroles_Click);
            // 
            // menucompras
            // 
            this.menucompras.AutoSize = false;
            this.menucompras.BackColor = System.Drawing.Color.Transparent;
            this.menucompras.BackgroundImage = global::CapaPresentacion.Properties.Resources.Comprasnuevo__1_;
            this.menucompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menucompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuregistrarcompra,
            this.submenuverdetallecompra,
            this.submenuhistorialdecompras});
            this.menucompras.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menucompras.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menucompras.IconColor = System.Drawing.Color.Black;
            this.menucompras.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.menucompras.IconSize = 55;
            this.menucompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menucompras.ImageTransparentColor = System.Drawing.Color.Black;
            this.menucompras.Name = "menucompras";
            this.menucompras.Size = new System.Drawing.Size(250, 250);
            this.menucompras.Text = "Compras";
            this.menucompras.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menucompras.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // submenuregistrarcompra
            // 
            this.submenuregistrarcompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuregistrarcompra.IconColor = System.Drawing.Color.Black;
            this.submenuregistrarcompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuregistrarcompra.Name = "submenuregistrarcompra";
            this.submenuregistrarcompra.Size = new System.Drawing.Size(270, 32);
            this.submenuregistrarcompra.Text = "Registrar";
            this.submenuregistrarcompra.Click += new System.EventHandler(this.submenuregistrarcompra_Click);
            // 
            // submenuverdetallecompra
            // 
            this.submenuverdetallecompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuverdetallecompra.IconColor = System.Drawing.Color.Black;
            this.submenuverdetallecompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuverdetallecompra.Name = "submenuverdetallecompra";
            this.submenuverdetallecompra.Size = new System.Drawing.Size(270, 32);
            this.submenuverdetallecompra.Text = "Ver detalle";
            this.submenuverdetallecompra.Click += new System.EventHandler(this.submenuverdetallecompra_Click);
            // 
            // submenuhistorialdecompras
            // 
            this.submenuhistorialdecompras.Name = "submenuhistorialdecompras";
            this.submenuhistorialdecompras.Size = new System.Drawing.Size(270, 32);
            this.submenuhistorialdecompras.Text = "Historial de compras";
            this.submenuhistorialdecompras.Click += new System.EventHandler(this.submenuhistorialdecompras_Click);
            // 
            // menuinventario
            // 
            this.menuinventario.AutoSize = false;
            this.menuinventario.BackgroundImage = global::CapaPresentacion.Properties.Resources.Menuproductosnuevos__1_;
            this.menuinventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuinventario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenucategoria,
            this.submenuproducto,
            this.submenunegocio});
            this.menuinventario.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Italic);
            this.menuinventario.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menuinventario.IconColor = System.Drawing.Color.Black;
            this.menuinventario.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.menuinventario.IconSize = 55;
            this.menuinventario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuinventario.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuinventario.Name = "menuinventario";
            this.menuinventario.Size = new System.Drawing.Size(250, 250);
            this.menuinventario.Text = "Productos";
            this.menuinventario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menuinventario.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // submenucategoria
            // 
            this.submenucategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenucategoria.IconColor = System.Drawing.Color.Black;
            this.submenucategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenucategoria.Name = "submenucategoria";
            this.submenucategoria.Size = new System.Drawing.Size(180, 30);
            this.submenucategoria.Text = "Categoría";
            this.submenucategoria.Click += new System.EventHandler(this.submenucategoria_Click);
            // 
            // submenuproducto
            // 
            this.submenuproducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuproducto.IconColor = System.Drawing.Color.Black;
            this.submenuproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuproducto.Name = "submenuproducto";
            this.submenuproducto.Size = new System.Drawing.Size(180, 30);
            this.submenuproducto.Text = "Producto";
            this.submenuproducto.Click += new System.EventHandler(this.submenuproducto_Click);
            // 
            // submenunegocio
            // 
            this.submenunegocio.Name = "submenunegocio";
            this.submenunegocio.Size = new System.Drawing.Size(180, 30);
            this.submenunegocio.Text = "Negocio";
            this.submenunegocio.Click += new System.EventHandler(this.submenunegocio_Click_2);
            // 
            // menuclientes
            // 
            this.menuclientes.AutoSize = false;
            this.menuclientes.BackColor = System.Drawing.Color.Transparent;
            this.menuclientes.BackgroundImage = global::CapaPresentacion.Properties.Resources.menuclientesnuevo__1_;
            this.menuclientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuclientes.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Italic);
            this.menuclientes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menuclientes.IconColor = System.Drawing.Color.Black;
            this.menuclientes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.menuclientes.IconSize = 55;
            this.menuclientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuclientes.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuclientes.Name = "menuclientes";
            this.menuclientes.Size = new System.Drawing.Size(250, 250);
            this.menuclientes.Text = "Clientes";
            this.menuclientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menuclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.menuclientes.Click += new System.EventHandler(this.menuclientes_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnminimizar);
            this.panel1.Controls.Add(this.Cerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblusuario);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 105);
            this.panel1.TabIndex = 7;
            // 
            // btnminimizar
            // 
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = global::CapaPresentacion.Properties.Resources.minimizar;
            this.btnminimizar.Location = new System.Drawing.Point(1122, 0);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(30, 30);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnminimizar.TabIndex = 9;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click_1);
            // 
            // Cerrar
            // 
            this.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cerrar.Image = global::CapaPresentacion.Properties.Resources.cerca;
            this.Cerrar.Location = new System.Drawing.Point(1158, 0);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(30, 30);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cerrar.TabIndex = 8;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // menu2
            // 
            this.menu2.AutoSize = false;
            this.menu2.BackColor = System.Drawing.Color.DarkGray;
            this.menu2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu2.Dock = System.Windows.Forms.DockStyle.None;
            this.menu2.GripMargin = new System.Windows.Forms.Padding(3);
            this.menu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuproveedores,
            this.menuventas,
            this.menureportes});
            this.menu2.Location = new System.Drawing.Point(205, 419);
            this.menu2.Margin = new System.Windows.Forms.Padding(2);
            this.menu2.Name = "menu2";
            this.menu2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu2.Size = new System.Drawing.Size(1162, 279);
            this.menu2.TabIndex = 8;
            this.menu2.Text = "menuStrip1";
            // 
            // menuproveedores
            // 
            this.menuproveedores.AutoSize = false;
            this.menuproveedores.BackColor = System.Drawing.Color.Transparent;
            this.menuproveedores.BackgroundImage = global::CapaPresentacion.Properties.Resources.MenuProveedores2;
            this.menuproveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuproveedores.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuproveedores.ForeColor = System.Drawing.Color.Black;
            this.menuproveedores.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menuproveedores.IconColor = System.Drawing.Color.Black;
            this.menuproveedores.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.menuproveedores.IconSize = 55;
            this.menuproveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuproveedores.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuproveedores.Name = "menuproveedores";
            this.menuproveedores.Size = new System.Drawing.Size(250, 250);
            this.menuproveedores.Text = "Proveedores";
            this.menuproveedores.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menuproveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.menuproveedores.Click += new System.EventHandler(this.menuproveedores_Click_2);
            // 
            // menuventas
            // 
            this.menuventas.AutoSize = false;
            this.menuventas.BackColor = System.Drawing.Color.Transparent;
            this.menuventas.BackgroundImage = global::CapaPresentacion.Properties.Resources.Menu_Ventas_Nuevo;
            this.menuventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuregistrarventa,
            this.submenuverdetalleventa});
            this.menuventas.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Italic);
            this.menuventas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menuventas.IconColor = System.Drawing.Color.Black;
            this.menuventas.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.menuventas.IconSize = 55;
            this.menuventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuventas.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuventas.Name = "menuventas";
            this.menuventas.Size = new System.Drawing.Size(250, 250);
            this.menuventas.Text = "Ventas";
            this.menuventas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menuventas.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // submenuregistrarventa
            // 
            this.submenuregistrarventa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuregistrarventa.IconColor = System.Drawing.Color.Black;
            this.submenuregistrarventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuregistrarventa.Name = "submenuregistrarventa";
            this.submenuregistrarventa.Size = new System.Drawing.Size(166, 28);
            this.submenuregistrarventa.Text = "Registrar";
            this.submenuregistrarventa.Click += new System.EventHandler(this.submenuregistrarventa_Click);
            // 
            // submenuverdetalleventa
            // 
            this.submenuverdetalleventa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuverdetalleventa.IconColor = System.Drawing.Color.Black;
            this.submenuverdetalleventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuverdetalleventa.Name = "submenuverdetalleventa";
            this.submenuverdetalleventa.Size = new System.Drawing.Size(166, 28);
            this.submenuverdetalleventa.Text = "Ver Detalle";
            this.submenuverdetalleventa.Click += new System.EventHandler(this.submenuverdetalleventa_Click);
            // 
            // menureportes
            // 
            this.menureportes.AutoSize = false;
            this.menureportes.BackColor = System.Drawing.Color.Transparent;
            this.menureportes.BackgroundImage = global::CapaPresentacion.Properties.Resources.menureportes__1_;
            this.menureportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menureportes.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Italic);
            this.menureportes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menureportes.IconColor = System.Drawing.Color.Black;
            this.menureportes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.menureportes.IconSize = 50;
            this.menureportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menureportes.ImageTransparentColor = System.Drawing.Color.Black;
            this.menureportes.Name = "menureportes";
            this.menureportes.Size = new System.Drawing.Size(250, 250);
            this.menureportes.Text = "Reportes";
            this.menureportes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menureportes.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // botoncerrarsesion
            // 
            this.botoncerrarsesion.BackColor = System.Drawing.Color.Black;
            this.botoncerrarsesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.botoncerrarsesion.FlatAppearance.BorderSize = 0;
            this.botoncerrarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoncerrarsesion.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoncerrarsesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botoncerrarsesion.Location = new System.Drawing.Point(1083, 288);
            this.botoncerrarsesion.Name = "botoncerrarsesion";
            this.botoncerrarsesion.Size = new System.Drawing.Size(105, 137);
            this.botoncerrarsesion.TabIndex = 10;
            this.botoncerrarsesion.Text = "Cerrar sesión";
            this.botoncerrarsesion.UseVisualStyleBackColor = false;
            this.botoncerrarsesion.Click += new System.EventHandler(this.botoncerrarsesion_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.botoncerrarsesion);
            this.Controls.Add(this.menu2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            this.menu2.ResumeLayout(false);
            this.menu2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menuusuarios;
        private FontAwesome.Sharp.IconMenuItem menucompras;
        private FontAwesome.Sharp.IconMenuItem submenuregistrarcompra;
        private FontAwesome.Sharp.IconMenuItem submenuverdetallecompra;
        private FontAwesome.Sharp.IconMenuItem menuinventario;
        private FontAwesome.Sharp.IconMenuItem submenucategoria;
        private FontAwesome.Sharp.IconMenuItem submenuproducto;
        private System.Windows.Forms.ToolStripMenuItem submenunegocio;
        private FontAwesome.Sharp.IconMenuItem menuclientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.ToolStripMenuItem submenuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem submenuroles;
        private System.Windows.Forms.MenuStrip menu2;
        private FontAwesome.Sharp.IconMenuItem menuproveedores;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem submenuregistrarventa;
        private FontAwesome.Sharp.IconMenuItem submenuverdetalleventa;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private System.Windows.Forms.Button botoncerrarsesion;
        private System.Windows.Forms.ToolStripMenuItem submenuhistorialdecompras;
    }
}

