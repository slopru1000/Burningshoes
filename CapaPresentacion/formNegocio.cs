using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class formNegocio : Form
    {
        public formNegocio()
        {
            InitializeComponent();
            InitializePlaceholders();
            iramodulos.Click += new EventHandler(iramodulos_Click);
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void InitializePlaceholders()
        {
            SetPlaceholder(txtnombre, "NOMBRE");
            SetPlaceholder(txtnit, "NIT");
            SetPlaceholder(txtdireccion, "DIRECCION");



            txtnombre.Enter += (s, e) => RemovePlaceholder(txtnombre, "NOMBRE");
            txtnombre.Leave += (s, e) => SetPlaceholder(txtnombre, "NOMBRE");

            txtnit.Enter += (s, e) => RemovePlaceholder(txtnit, "NIT");
            txtnit.Leave += (s, e) => SetPlaceholder(txtnit, "NIT");

            txtdireccion.Enter += (s, e) => RemovePlaceholder(txtdireccion, "DIRECCION");
            txtdireccion.Leave += (s, e) => SetPlaceholder(txtdireccion, "DIRECCION");

           
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Khaki;

            }
        }

        private void RemovePlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Yellow;

            }
        }

        public Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);

            return image;
        }


        private void frmNegocio_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] byteimage = new BL_Negocio().ObtenerLogo(out obtenido);

            if (obtenido)
                picLogo.Image = ByteToImage(byteimage);

            Negocio datos = new BL_Negocio().ObtenerDatos();

            txtnombre.Text = datos.Nombre;
            txtnit.Text = datos.NIT;
            txtdireccion.Text = datos.Direccion;
        }

        private void btnsubir_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.FileName = "Files|*.jpg;*.jpeg;*.png";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {

                byte[] byteimage = File.ReadAllBytes(oOpenFileDialog.FileName);
                bool respuesta = new BL_Negocio().ActualizarLogo(byteimage, out mensaje);

                if (respuesta)
                    picLogo.Image = ByteToImage(byteimage);
                else
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void btnguardarcambios_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Negocio obj = new Negocio()
            {
                Nombre = txtnombre.Text,
                NIT = txtnit.Text,
                Direccion = txtdireccion.Text
            };

            bool respuesta = new BL_Negocio().GuardarDatos(obj, out mensaje);

            if (respuesta)
                
            MessageBox.Show("Los cambios fueron guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

            
            else
                
            MessageBox.Show("No se pudo guardar los cambios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void iramodulos_Click(object sender, EventArgs e)
        {

            if (Inicio.Instance != null)
            {
                this.Close(); // Cierra el formulario actual
                Inicio.Instance.AbrirFormulario(null, Inicio.Instance); // Llama al método AbrirFormulario del formulario Inicio
            }
            else
            {
                MessageBox.Show("No se pudo encontrar la instancia del formulario de inicio.");
            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmNegocio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
    
}
