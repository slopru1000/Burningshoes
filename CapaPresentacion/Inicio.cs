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
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {

        public static Inicio Instance { get; private set; }

        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;


        public Inicio(Usuario objusuario)
        {
           
                usuarioActual = objusuario;
            

            InitializeComponent();
            Instance = this;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new BL_Permiso().Listar(usuarioActual.IdUsuario);

            foreach (IconMenuItem iconMenu in menu.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconMenu.Name);
                if (encontrado == false)
                {
                    iconMenu.Visible = false;
                }
            }


            lblusuario.Text = usuarioActual.NombreCompleto;
        }

        public void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.Transparent;
            }

            
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
                FormularioActivo.Dispose(); // Liberar los recursos del formulario anterior
            }
            Visible = false;
            formulario.Show();
        }

        

        private void submenunegocio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuinventario, new formNegocio());
        }

        private void menuusuarios_Click_1(object sender, EventArgs e)
        {

            AbrirFormulario((IconMenuItem)sender, new formUsuarios());
            
        }

        private void menuproveedores_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new formProveedores());
        }

        private void submenuregistrarcompra_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new formCompras(usuarioActual));
        }

        private void submenuverdetallecompra_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new formDetalleCompra());
        }

        private void submenucategoria_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(menuinventario, new formCategoria());
        }

        private void submenuproducto_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(menuinventario, new formProducto());
        }

        private void submenunegocio_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(menuinventario, new formNegocio());
        }

        private void submenuregistrarventa_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new formVentas2(usuarioActual));
        }

        private void submenuverdetalleventa_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new formDetalleVenta());
        }

        private void menuclientes_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new formClientes());
        }

        private void menureportes_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new formReportes());
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("¿Desea cerrar sesión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                this.Hide();
                Login loginForm = new Login();
                loginForm.Show();
            }
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Inicio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        
    }
}
