namespace CapaPresentacion
{
    partial class formRoles
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
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.iramodulos = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombredelrol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clbPrivilegios = new System.Windows.Forms.CheckedListBox();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.dgvdatarol = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iramodulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatarol)).BeginInit();
            this.SuspendLayout();
            // 
            // btnminimizar
            // 
            this.btnminimizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = global::CapaPresentacion.Properties.Resources.signo_menos_de_una_linea_en_posicion_horizontal;
            this.btnminimizar.Location = new System.Drawing.Point(1126, 2);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(30, 30);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnminimizar.TabIndex = 222;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = global::CapaPresentacion.Properties.Resources.x;
            this.btncerrar.Location = new System.Drawing.Point(1162, 2);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(30, 30);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btncerrar.TabIndex = 221;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(433, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 45);
            this.label2.TabIndex = 220;
            this.label2.Text = "Gestion de Roles";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Italic);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(52, -1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 25);
            this.label10.TabIndex = 219;
            this.label10.Text = "Ir a Modulos";
            // 
            // iramodulos
            // 
            this.iramodulos.BackColor = System.Drawing.Color.Transparent;
            this.iramodulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iramodulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iramodulos.Image = global::CapaPresentacion.Properties.Resources.VolveraModulos;
            this.iramodulos.Location = new System.Drawing.Point(0, -1);
            this.iramodulos.Name = "iramodulos";
            this.iramodulos.Size = new System.Drawing.Size(50, 50);
            this.iramodulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iramodulos.TabIndex = 218;
            this.iramodulos.TabStop = false;
            this.iramodulos.Click += new System.EventHandler(this.iramodulos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 223;
            this.label1.Text = "Nuevo Rol\r\n";
            // 
            // txtnombredelrol
            // 
            this.txtnombredelrol.BackColor = System.Drawing.Color.DarkGray;
            this.txtnombredelrol.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombredelrol.ForeColor = System.Drawing.Color.Black;
            this.txtnombredelrol.Location = new System.Drawing.Point(40, 213);
            this.txtnombredelrol.Name = "txtnombredelrol";
            this.txtnombredelrol.Size = new System.Drawing.Size(239, 22);
            this.txtnombredelrol.TabIndex = 224;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(35, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 225;
            this.label3.Text = "Nombre del Rol\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(35, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 226;
            this.label4.Text = "Privilegios";
            // 
            // clbPrivilegios
            // 
            this.clbPrivilegios.BackColor = System.Drawing.Color.Black;
            this.clbPrivilegios.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbPrivilegios.ForeColor = System.Drawing.Color.White;
            this.clbPrivilegios.FormattingEnabled = true;
            this.clbPrivilegios.Items.AddRange(new object[] {
            "menuusuarios",
            "menuinventario",
            "menuventas",
            "menucompras",
            "menuclientes",
            "menuproveedores",
            "menureportes"});
            this.clbPrivilegios.Location = new System.Drawing.Point(40, 292);
            this.clbPrivilegios.Name = "clbPrivilegios";
            this.clbPrivilegios.Size = new System.Drawing.Size(239, 200);
            this.clbPrivilegios.TabIndex = 227;
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
            this.btneliminar.ForeColor = System.Drawing.Color.Black;
            this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btneliminar.IconColor = System.Drawing.Color.White;
            this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneliminar.IconSize = 50;
            this.btneliminar.Location = new System.Drawing.Point(169, 523);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(110, 110);
            this.btneliminar.TabIndex = 229;
            this.btneliminar.Text = "Limpiar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneliminar.UseVisualStyleBackColor = false;
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
            this.btnguardar.ForeColor = System.Drawing.Color.Black;
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnguardar.IconColor = System.Drawing.Color.White;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 50;
            this.btnguardar.Location = new System.Drawing.Point(37, 523);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(110, 110);
            this.btnguardar.TabIndex = 228;
            this.btnguardar.Text = "Crear";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // dgvdatarol
            // 
            this.dgvdatarol.AllowUserToAddRows = false;
            this.dgvdatarol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdatarol.BackgroundColor = System.Drawing.Color.Black;
            this.dgvdatarol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdatarol.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdatarol.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdatarol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatarol.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatarol.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdatarol.GridColor = System.Drawing.Color.Black;
            this.dgvdatarol.Location = new System.Drawing.Point(303, 69);
            this.dgvdatarol.MultiSelect = false;
            this.dgvdatarol.Name = "dgvdatarol";
            this.dgvdatarol.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdatarol.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatarol.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdatarol.RowTemplate.Height = 28;
            this.dgvdatarol.Size = new System.Drawing.Size(814, 519);
            this.dgvdatarol.TabIndex = 230;
            // 
            // formRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.dgvdatarol);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.clbPrivilegios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombredelrol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.iramodulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iramodulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatarol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox iramodulos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombredelrol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox clbPrivilegios;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private System.Windows.Forms.DataGridView dgvdatarol;
    }
}