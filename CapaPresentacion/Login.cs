using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidad;
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        

        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnacceder_Click(object sender, EventArgs e)
        {
            List<Usuario> TEST = new BL_Usuario().Listar();

            Usuario ousuario = new BL_Usuario().Listar().Where(u => u.Documento == txtdocumento.Text && u.Clave == txtclave.Text).FirstOrDefault();

            if (ousuario != null)
            {
                this.Hide();
                Inicio form = new Inicio(ousuario);
                form.FormClosing += frm_closing;
                form.Show();

            }
            else
            {
                MessageBox.Show("No se encontro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtdocumento.Text = "";
            txtclave.Text = "";
            this.Show();
        }

        

        private void txtdocumento_Enter(object sender, EventArgs e)
        {
            if (txtdocumento.Text == "NUMERO DE DOCUMENTO")
            {
                txtdocumento.Text = "";
                txtdocumento.ForeColor = Color.White;
            }
        }

        private void txtdocumento_Leave(object sender, EventArgs e)
        {
            if (txtdocumento.Text == "")
            {
                txtdocumento.Text = "NUMERO DE DOCUMENTO";
                txtdocumento.ForeColor = Color.DimGray;
            }
        }

        private void txtclave_Enter(object sender, EventArgs e)
        {
            if (txtclave.Text == "CONTRASEÑA")
            {
                txtclave.Text = "";
                txtclave.ForeColor = Color.White;
                txtclave.UseSystemPasswordChar = true;
            }
        }

        private void txtclave_Leave(object sender, EventArgs e)
        {
            if (txtclave.Text == "")
            {
                txtclave.Text = "CONTRASEÑA";
                txtclave.ForeColor = Color.DimGray;
                txtclave.UseSystemPasswordChar = false;
            }
        }

        private void btncancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir del programa?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir del programa?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}
