using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidad;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        public static Inicio Instance { get; private set; }

        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        // Constructor
        public Inicio(Usuario objusuario)
        {
            // Asegurarse de que el usuario no sea nulo
            if (objusuario == null)
            {
                MessageBox.Show("El usuario no es válido.");
                return;
            }

            usuarioActual = objusuario;

            InitializeComponent();
            menu.Renderer = new MenuRendererConImagenes(); // comportamiento del hover(pasar mouse encima del menustrip para q se vea la imagen
            menu2.Renderer = new MenuRendererConImagenes(); // para el segundo menustrip
            Instance = this;
        }

        // P/ Mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        // Cargar evento
        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new BL_Permiso().Listar(usuarioActual.IdUsuario);

            // Ocultar los elementos de menú según los permisos
            foreach (IconMenuItem iconMenu in menu.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconMenu.Name);
                iconMenu.Visible = encontrado;
            }

            // Ocultar elementos del segundo menú
            foreach (IconMenuItem iconMenu in menu2.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconMenu.Name);
                iconMenu.Visible = encontrado;
            }

            // Si no hay ítems visibles en el segundo menú, ocultar el menú completo
            menu2.Visible = menu2.Items.Cast<ToolStripItem>().Any(item => item.Visible);

            // Mostrar el nombre del usuario
            lblusuario.Text = usuarioActual.NombreCompleto;
        }

        // Abrir formularios
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

        // Métodos de clic para abrir los formularios

        private void menuproveedores_Click_2(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new formProveedores());
        }

        private void submenuUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuusuarios, new formUsuarios());
        }

        private void submenuregistrarcompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new formCompras(usuarioActual));
        }

        private void submenuverdetallecompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new formDetalleCompra());
        }

        private void submenucategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuinventario, new formCategoria());
        }

        private void submenuproducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuinventario, new formProducto());
        }

        private void submenunegocio_Click_2(object sender, EventArgs e)
        {
            AbrirFormulario(menuinventario, new formNegocio());
        }

        private void menuclientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new formClientes());
        }

        private void submenuregistrarventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new formVentas2(usuarioActual));
        }

        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new formDetalleVenta());
        }

        private void submenuhistorialdecompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new FormHistorialDeCompras());
        }

        private void submenuroles_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuusuarios, new formRoles());
        }
        // Minimizar ventana
        private void btnminimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Cerrar sesión
        private void botoncerrarsesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar sesión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login loginForm = new Login();
                loginForm.Show();
            }
        }




        // Mover ventana
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

       
    }
}