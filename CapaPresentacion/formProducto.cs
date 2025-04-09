using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
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
    public partial class formProducto : Form
    {
        public formProducto()
        {
            InitializeComponent();
            InitializePlaceholders();
            iramodulos.Click += new EventHandler(iramodulos_Click);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void frmProducto_Load(object sender, EventArgs e)
        {
 
            List<Categoria> listacategoria = new BL_Categoria().Listar();

            foreach (Categoria item in listacategoria)
            {
                cbocategoria.Items.Add(new OpcionCombo() { Valor = item.IdCategoria, Texto = item.Descripcion });
            }
            cbocategoria.DisplayMember = "Texto";
            cbocategoria.ValueMember = "Valor";
            cbocategoria.SelectedIndex = 0;


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



            //MOSTRAR TODOS LOS PRODUCTOS
            List<Producto> lista = new BL_Producto().Listar();

            foreach (Producto item in lista)
            {

                dgvdatos.Rows.Add(new object[] {
                    "",
                    item.IdProducto,
                    item.Codigo,
                    item.Nombre,
                    item.Descripcion,
                    item.Talla,
                    item.oCategoria.IdCategoria,
                    item.oCategoria.Descripcion,
                    item.Stock,
                    item.PrecioCompra,
                    item.PrecioVenta,
                   
                });
            }

        }

        private void InitializePlaceholders()
        {
            SetPlaceholder(txtpcodigo, "CODIGO");
            SetPlaceholder(txtpnombre, "NOMBRE");
            SetPlaceholder(txtpdescripcion, "DESCRIPCION");
            SetPlaceholder(txtptalla, "TALLA");


            txtpcodigo.Enter += (s, e) => RemovePlaceholder(txtpcodigo, "CODIGO");
            txtpcodigo.Leave += (s, e) => SetPlaceholder(txtpcodigo, "CODIGO");

            txtpnombre.Enter += (s, e) => RemovePlaceholder(txtpnombre, "NOMBRE");
            txtpnombre.Leave += (s, e) => SetPlaceholder(txtpnombre, "NOMBRE");

            txtpdescripcion.Enter += (s, e) => RemovePlaceholder(txtpdescripcion, "DESCRIPCION");
            txtpdescripcion.Leave += (s, e) => SetPlaceholder(txtpdescripcion, "DESCRIPCION");

            txtptalla.Enter += (s, e) => RemovePlaceholder(txtptalla, "TALLA");
            txtptalla.Leave += (s, e) => SetPlaceholder(txtptalla, "TALLA");


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

            Producto obj = new Producto()
            {
                IdProducto = Convert.ToInt32(txtid.Text),
                Codigo = txtpcodigo.Text,
                Nombre = txtpnombre.Text,
                Descripcion = txtpdescripcion.Text,
                Talla = txtptalla.Text,
                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)cbocategoria.SelectedItem).Valor) },
               
            };

            if (obj.IdProducto == 0)
            {
                int idgenerado = new BL_Producto().Registrar(obj, out mensaje);

                if (idgenerado != 0)
                {

                    dgvdatos.Rows.Add(new object[] {
                        "",
                       idgenerado,
                       txtpcodigo.Text,
                       txtpnombre.Text,
                       txtpdescripcion.Text,
                       txtptalla.Text,
                       ((OpcionCombo)cbocategoria.SelectedItem).Valor.ToString(),
                       ((OpcionCombo)cbocategoria.SelectedItem).Texto.ToString(),
                       "0",
                       "0.00",
                       "0.00",
                       
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
                bool resultado = new BL_Producto().Modificar(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvdatos.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["Codigo"].Value = txtpcodigo.Text;
                    row.Cells["Nombre"].Value = txtpnombre.Text;
                    row.Cells["Descripcion"].Value = txtpdescripcion.Text;
                    row.Cells["Talla"].Value = txtptalla.Text;
                    row.Cells["IdCategoria"].Value = ((OpcionCombo)cbocategoria.SelectedItem).Valor.ToString();
                    row.Cells["Categoria"].Value = ((OpcionCombo)cbocategoria.SelectedItem).Texto.ToString();
                    

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
            txtpcodigo.Text = "";
            txtpnombre.Text = "";
            txtpdescripcion.Text = "";
            txtptalla.Text = "";
            cbocategoria.SelectedIndex = 0;

            SetPlaceholder(txtpcodigo, "CODIGO");
            SetPlaceholder(txtpnombre, "NOMBRE");
            SetPlaceholder(txtpdescripcion, "DESCRIPCION");
            SetPlaceholder(txtptalla, "TALLA");
            

            txtpcodigo.Select();

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

                    txtpcodigo.Text = dgvdatos.Rows[indice].Cells["Codigo"].Value.ToString();
                    txtpnombre.Text = dgvdatos.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtpdescripcion.Text = dgvdatos.Rows[indice].Cells["Descripcion"].Value.ToString();
                    txtptalla.Text = dgvdatos.Rows[indice].Cells["Talla"].Value.ToString();


                    foreach (OpcionCombo oc in cbocategoria.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdatos.Rows[indice].Cells["IdCategoria"].Value))
                        {
                            int indice_combo = cbocategoria.Items.IndexOf(oc);
                            cbocategoria.SelectedIndex = indice_combo;
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
                if (MessageBox.Show("¿Desea eliminar el producto", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;
                    Producto obj = new Producto()
                    {
                        IdProducto = Convert.ToInt32(txtid.Text)
                    };

                    bool respuesta = new BL_Producto().Eliminar(obj, out mensaje);

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

        private void btnLimpiarDatos_Click_1(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void btnexporterexcel_Click_1(object sender, EventArgs e)
        {
            if (dgvdatos.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn columna in dgvdatos.Columns)
                {
                    if (columna.HeaderText != "" && columna.Visible)
                        dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                foreach (DataGridViewRow row in dgvdatos.Rows)
                {
                    if (row.Visible)
                        dt.Rows.Add(new object[] {
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[10].Value.ToString(),

                        });
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReportedeProducto_{0}.xlsx", DateTime.Now.ToString("ddMMyyy"));
                savefile.Filter = "Excel Files | *.xlsx";

                if (savefile.ShowDialog() == DialogResult.OK)
                {

                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("El Reporte ha sido Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }

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

        private void frmProducto_MouseDown(object sender, MouseEventArgs e)
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
