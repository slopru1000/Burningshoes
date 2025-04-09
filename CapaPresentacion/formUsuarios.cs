using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;
using CapaEntidad;
using CapaNegocio;
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class formUsuarios : Form
    {
        public formUsuarios()
        {
            InitializeComponent();
            InitializePlaceholders();
            iramodulos.Click += new EventHandler(iramodulos_Click);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;

            List<Rol> listaRol = new BL_Rol().Listar();
            foreach (Rol item in listaRol)
            {
                cborol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });
            }
            cborol.DisplayMember = "Texto";
            cborol.ValueMember = "Valor";
            cborol.SelectedIndex = 0;

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

            List<Usuario> listaUsuario = new BL_Usuario().Listar();
            foreach (Usuario item in listaUsuario)
            {
                dgvdatos.Rows.Add(new object[] { "", item.IdUsuario, item.Documento, item.NombreCompleto, item.Correo, item.Clave,
                    item.oRol.IdRol, item.oRol.Descripcion, item.Estado == true ? 1 : 0, item.Estado == true ? "Activo" : "No Activo" });
            }
        }

        private void InitializePlaceholders()
        {
            SetPlaceholder(txtdocumento, "DOCUMENTO");
            SetPlaceholder(txtnombrecompleto, "NOMBRE COMPLETO");
            SetPlaceholder(txtcorreo, "CORREO");
            SetPlaceholder(txtclave, "CONTRASEÑA");
            SetPlaceholder(txtconfirmarclave, "CONFIRMAR CONTRASEÑA");

            txtdocumento.Enter += (s, e) => RemovePlaceholder(txtdocumento, "DOCUMENTO");
            txtdocumento.Leave += (s, e) => SetPlaceholder(txtdocumento, "DOCUMENTO");

            txtnombrecompleto.Enter += (s, e) => RemovePlaceholder(txtnombrecompleto, "NOMBRE COMPLETO");
            txtnombrecompleto.Leave += (s, e) => SetPlaceholder(txtnombrecompleto, "NOMBRE COMPLETO");

            txtcorreo.Enter += (s, e) => RemovePlaceholder(txtcorreo, "CORREO");
            txtcorreo.Leave += (s, e) => SetPlaceholder(txtcorreo, "CORREO");

            txtclave.Enter += (s, e) => RemovePlaceholder(txtclave, "CONTRASEÑA");
            txtclave.Leave += (s, e) => SetPlaceholder(txtclave, "CONTRASEÑA");

            txtconfirmarclave.Enter += (s, e) => RemovePlaceholder(txtconfirmarclave, "CONFIRMAR CONTRASEÑA");
            txtconfirmarclave.Leave += (s, e) => SetPlaceholder(txtconfirmarclave, "CONFIRMAR CONTRASEÑA");
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Khaki;
                if (textBox.Name == "txtclave" || textBox.Name == "txtconfirmarclave")
                {
                    textBox.UseSystemPasswordChar = false;
                }
            }
        }

        private void RemovePlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Yellow;
                if (textBox.Name == "txtclave" || textBox.Name == "txtconfirmarclave")
                {
                    textBox.UseSystemPasswordChar = true;
                }
            }
        }

        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtdocumento.Text = "";
            txtnombrecompleto.Text = "";
            txtcorreo.Text = "";
            txtclave.Text = "";
            txtconfirmarclave.Text = "";
            cborol.SelectedIndex = 0;
            cboestado.SelectedIndex = 0;

            SetPlaceholder(txtdocumento, "DOCUMENTO");
            SetPlaceholder(txtnombrecompleto, "NOMBRE COMPLETO");
            SetPlaceholder(txtcorreo, "CORREO");
            SetPlaceholder(txtclave, "CONTRASEÑA");
            SetPlaceholder(txtconfirmarclave, "CONFIRMAR CONTRASEÑA");

            txtdocumento.Select();
        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Usuario objusuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(txtid.Text),
                Documento = txtdocumento.Text,
                NombreCompleto = txtnombrecompleto.Text,
                Correo = txtcorreo.Text,
                Clave = txtclave.Text,
                oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo)cborol.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false
            };

            if (objusuario.IdUsuario == 0)
            {
                int idusuariogenerado = new BL_Usuario().Registrar(objusuario, out mensaje);

                if (idusuariogenerado != 0)
                {
                    dgvdatos.Rows.Add(new object[] { "", idusuariogenerado, txtdocumento.Text, txtnombrecompleto.Text, txtcorreo.Text, txtclave.Text,
                       ((OpcionCombo)cborol.SelectedItem).Valor.ToString(), ((OpcionCombo)cborol.SelectedItem).Texto.ToString(),
                       ((OpcionCombo)cboestado.SelectedItem).Valor.ToString(), ((OpcionCombo)cboestado.SelectedItem).Texto.ToString() });

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new BL_Usuario().Editar(objusuario, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvdatos.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["Documento"].Value = txtdocumento.Text;
                    row.Cells["NombreCompleto"].Value = txtnombrecompleto.Text;
                    row.Cells["Correo"].Value = txtcorreo.Text;
                    row.Cells["Clave"].Value = txtclave.Text;
                    row.Cells["IdRol"].Value = ((OpcionCombo)cborol.SelectedItem).Valor.ToString();
                    row.Cells["Rol"].Value = ((OpcionCombo)cborol.SelectedItem).Texto.ToString();
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
                    txtindice.Text = indice.ToString();
                    txtid.Text = dgvdatos.Rows[indice].Cells["Id"].Value.ToString();
                    txtdocumento.Text = dgvdatos.Rows[indice].Cells["Documento"].Value.ToString();
                    txtnombrecompleto.Text = dgvdatos.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtcorreo.Text = dgvdatos.Rows[indice].Cells["Correo"].Value.ToString();
                    txtclave.Text = dgvdatos.Rows[indice].Cells["Clave"].Value.ToString();
                    txtconfirmarclave.Text = dgvdatos.Rows[indice].Cells["Clave"].Value.ToString();

                    foreach (OpcionCombo oc in cborol.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdatos.Rows[indice].Cells["IdRol"].Value))
                        {
                            int indice_combo = cborol.Items.IndexOf(oc);
                            cborol.SelectedIndex = indice_combo;
                            break;
                        }
                    }

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

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Está seguro? El usuario se eliminará", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Usuario objusuario = new Usuario()
                    {
                        IdUsuario = Convert.ToInt32(txtid.Text),
                    };

                    bool respuesta = new BL_Usuario().Eliminar(objusuario, out mensaje);

                    if (respuesta)
                    {
                        dgvdatos.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
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

        private void btnbuscar_Click(object sender, EventArgs e)
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

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
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

        private void frmUsuarios_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtdocumento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

