using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class formCategoria : Form
    {
        public formCategoria()
        {
            InitializeComponent();
            InitializePlaceholders();
            iramodulo.Click += new EventHandler(iramodulo_Click);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void frmCategoria_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;
            

            foreach (DataGridViewColumn columna in dgvdatos.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;


            //Mostrar todos los usuarios

            List<Categoria> lista = new BL_Categoria().Listar();


            foreach (Categoria item in lista)
            {

            dgvdatos.Rows.Add(new object[] {"",item.IdCategoria,
            item.Descripcion,
            item.Estado == true ? 1 : 0,
            item.Estado == true ? "Activo" : "No Activo"

            });
             
            }
        }

        private void InitializePlaceholders()
        {
            SetPlaceholder(txtdescripcion, "DESCRIPCION");


            txtdescripcion.Enter += (s, e) => RemovePlaceholder(txtdescripcion, "DESCRIPCION");
            txtdescripcion.Leave += (s, e) => SetPlaceholder(txtdescripcion, "DESCRIPCION");

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

        private void btnguardar_Click(object sender, EventArgs e)
        {

            string mensaje = string.Empty;

            Categoria obj = new Categoria()

            {
                IdCategoria = Convert.ToInt32(txtid.Text),
                Descripcion = txtdescripcion.Text,
                Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false
            };

            if (obj.IdCategoria == 0)
            {


                int idgenerado = new BL_Categoria().Registrar(obj, out mensaje);

                if (idgenerado != 0)
                {

                    dgvdatos.Rows.Add(new object[] {"",idgenerado,txtdescripcion.Text,
                       ((OpcionCombo)cboestado.SelectedItem).Valor.ToString(),
                       ((OpcionCombo)cboestado.SelectedItem).Texto.ToString()
                       });

                    Limpiar();

                }
                else

                {
                    MessageBox.Show(mensaje);
                }

            }
            else
            {
                bool resultado = new BL_Categoria().Editar(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvdatos.Rows[Convert.ToInt32(textindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["Descripcion"].Value = txtdescripcion.Text;
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboestado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cboestado.SelectedItem).Texto.ToString();

                    Limpiar();

                }
                else

                {
                    MessageBox.Show(mensaje);
                }
            }
        }



        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtdescripcion.Text = "";
            cboestado.SelectedIndex = 0;

            txtdescripcion.Select();
        }

        private void dgvdatos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.Check.Width;
                var h = Properties.Resources.Check.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.Check, new Rectangle(x, y, w, h));
                e.Handled = true;

            }
        }

        private void dgvdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdatos.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {

                    textindice.Text = indice.ToString();
                    txtid.Text = dgvdatos.Rows[indice].Cells["Id"].Value.ToString();
                    txtdescripcion.Text = dgvdatos.Rows[indice].Cells["Descripcion"].Value.ToString();

                    foreach (OpcionCombo oc in cboestado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdatos.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cboestado.Items.IndexOf(oc);
                            cboestado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Esta seguro?, La Categoria se eliminara", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Categoria obj = new Categoria()

                    {
                        IdCategoria = Convert.ToInt32(txtid.Text),
                    };

                    bool respuesta = new BL_Categoria().Eliminar(obj, out mensaje);

                    if (respuesta)
                    {
                        dgvdatos.Rows.RemoveAt(Convert.ToInt32(textindice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

        }

        private void btnLimpiarDatos_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            if (dgvdatos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdatos.Rows)
                {

                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))

                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }

        }


        private void btnlimpiarbuscador_Click_1(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdatos.Rows)
            {
                row.Visible = true;
            }
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

        private void iramodulo_Click(object sender, EventArgs e)
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


        private void frmCategoria_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        
    }
}
