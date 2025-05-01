using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormHistorialDeCompras : Form
    {
        private Dictionary<string, formDetalleCompra> formulariosAbiertos = new Dictionary<string, formDetalleCompra>();

        public FormHistorialDeCompras()
        {
            InitializeComponent();
            this.Load += FormHistorialDeCompras_Load;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
        }

        private void FormHistorialDeCompras_Load(object sender, EventArgs e)
        {
            // Limpiar columnas por si se recarga
            dgvdata.Columns.Clear();

            // Añadir columnas manualmente
            dgvdata.Columns.Add("IdCompra", "ID de Compra");
            dgvdata.Columns.Add("NumeroDocumento", "N° Factura");
            dgvdata.Columns.Add("UsuarioRegistro", "Encargado de compra");
            dgvdata.Columns.Add("FechaRegistro", "Fecha");
            dgvdata.Columns.Add("MontoTotal", "Monto Total");

            // Añadir botón
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btnVerDetalle";
            btn.HeaderText = "Acción";
            btn.Text = "Ver Detalle";
            btn.UseColumnTextForButtonValue = true;
            dgvdata.Columns.Add(btn);

            // Obtener datos
            List<Compra> lista = new BL_HistorialdeCompras().Listar();

            foreach (Compra item in lista)
            {
                dgvdata.Rows.Add(new object[]
                {
                    item.IdCompra,
                    item.NumeroDocumento,
                    item.oUsuario.NombreCompleto,
                    Convert.ToDateTime(item.FechaRegistro).ToString("dd/MM/yyyy"),
                    item.MontoTotal.ToString("0.00")
                });
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnVerDetalle" && e.RowIndex >= 0)
            {
                string numeroDocumento = dgvdata.Rows[e.RowIndex].Cells["NumeroDocumento"].Value.ToString();

                // Si ya está abierto, traelo al frente
                if (formulariosAbiertos.ContainsKey(numeroDocumento))
                {
                    if (formulariosAbiertos[numeroDocumento] != null && !formulariosAbiertos[numeroDocumento].IsDisposed)
                    {
                        formulariosAbiertos[numeroDocumento].BringToFront();
                        formulariosAbiertos[numeroDocumento].Focus();
                        return;
                    }
                    else
                    {
                        formulariosAbiertos.Remove(numeroDocumento); // Limpiar referencia si fue cerrado
                    }
                }

                // Crear nuevo formulario y registrar su cierre
                formDetalleCompra detalleCompra = new formDetalleCompra(numeroDocumento);
                detalleCompra.FormClosed += (s, args) =>
                {
                    if (formulariosAbiertos.ContainsKey(numeroDocumento))
                        formulariosAbiertos.Remove(numeroDocumento);
                };

                formulariosAbiertos[numeroDocumento] = detalleCompra;
                detalleCompra.Show();
            }
        }



        private void iramodulos_Click(object sender, EventArgs e)
        {
            if (Inicio.Instance != null)
            {
                this.Close();
                Inicio.Instance.AbrirFormulario(null, Inicio.Instance);
            }
            else
            {
                MessageBox.Show("No se pudo encontrar la instancia del formulario de inicio.");
            }
        }
    }
}
