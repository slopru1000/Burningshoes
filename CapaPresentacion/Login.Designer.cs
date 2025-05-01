namespace CapaPresentacion
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnacceder = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Impact", 40F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(179, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 66);
            this.label2.TabIndex = 1;
            this.label2.Text = "LOGIN ";
            // 
            // txtclave
            // 
            this.txtclave.BackColor = System.Drawing.Color.Black;
            this.txtclave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtclave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave.ForeColor = System.Drawing.Color.DimGray;
            this.txtclave.Location = new System.Drawing.Point(144, 195);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(214, 20);
            this.txtclave.TabIndex = 3;
            this.txtclave.TabStop = false;
            this.txtclave.Text = "CONTRASEÑA";
            this.txtclave.Enter += new System.EventHandler(this.txtclave_Enter);
            this.txtclave.Leave += new System.EventHandler(this.txtclave_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.BS__1_;
            this.pictureBox1.Location = new System.Drawing.Point(25, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 307);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnminimizar);
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 453);
            this.panel1.TabIndex = 14;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = global::CapaPresentacion.Properties.Resources.signo_menos_de_una_linea_en_posicion_horizontal;
            this.btnminimizar.Location = new System.Drawing.Point(298, 3);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(20, 20);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnminimizar.TabIndex = 11;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = global::CapaPresentacion.Properties.Resources.x;
            this.btncerrar.Location = new System.Drawing.Point(324, 3);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(20, 20);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btncerrar.TabIndex = 10;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // txtdocumento
            // 
            this.txtdocumento.BackColor = System.Drawing.Color.Black;
            this.txtdocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdocumento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocumento.ForeColor = System.Drawing.Color.DimGray;
            this.txtdocumento.Location = new System.Drawing.Point(484, 162);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(214, 20);
            this.txtdocumento.TabIndex = 2;
            this.txtdocumento.TabStop = false;
            this.txtdocumento.Text = "NUMERO DE DOCUMENTO";
            this.txtdocumento.Enter += new System.EventHandler(this.txtdocumento_Enter);
            this.txtdocumento.Leave += new System.EventHandler(this.txtdocumento_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.menos;
            this.pictureBox2.Location = new System.Drawing.Point(484, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(246, 10);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.menos;
            this.pictureBox3.Location = new System.Drawing.Point(484, 216);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(246, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnacceder);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtclave);
            this.panel2.Location = new System.Drawing.Point(340, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 453);
            this.panel2.TabIndex = 17;
            // 
            // btnacceder
            // 
            this.btnacceder.BackColor = System.Drawing.Color.White;
            this.btnacceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnacceder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnacceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnacceder.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Italic);
            this.btnacceder.ForeColor = System.Drawing.Color.Black;
            this.btnacceder.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnacceder.IconColor = System.Drawing.Color.Black;
            this.btnacceder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnacceder.IconSize = 60;
            this.btnacceder.Location = new System.Drawing.Point(144, 288);
            this.btnacceder.Name = "btnacceder";
            this.btnacceder.Size = new System.Drawing.Size(246, 64);
            this.btnacceder.TabIndex = 130;
            this.btnacceder.Text = "INGRESAR";
            this.btnacceder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnacceder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnacceder.UseVisualStyleBackColor = false;
            this.btnacceder.Click += new System.EventHandler(this.btnacceder_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(841, 460);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtdocumento);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtdocumento;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnacceder;
    }
}