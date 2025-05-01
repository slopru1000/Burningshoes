using CapaEntidad;
using CapaNegocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
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
    public partial class formDetalleCompra : Form
    {
        private string _numeroDocumentoAutoCargar = null;

        public formDetalleCompra()
        {
            InitializeComponent();
            iramodulos.Click += new EventHandler(iramodulos_Click);
            this.Load += formDetalleCompra_Load;
        }

        public formDetalleCompra(string numeroDocumento)
        {
            InitializeComponent();
            iramodulos.Click += new EventHandler(iramodulos_Click);
            this.Load += formDetalleCompra_Load;

            _numeroDocumentoAutoCargar = numeroDocumento;
        }

        private void formDetalleCompra_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_numeroDocumentoAutoCargar))
            {
                txtbusqueda.Text = _numeroDocumentoAutoCargar;
                btnbuscar.PerformClick();
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Compra oCompra = new BL_Compra().ObtenerCompra(txtbusqueda.Text);

            if (oCompra.IdCompra != 0)
            {
                txtnumerodocumento.Text = oCompra.NumeroDocumento;
                txtfecha.Text = oCompra.FechaRegistro;
                txttipodocumento.Text = oCompra.TipoDocumento;
                txtusuario.Text = oCompra.oUsuario.NombreCompleto;
                txtdocproveedor.Text = oCompra.oProveedor.Documento;
                txtnombreproveedor.Text = oCompra.oProveedor.RazonSocial;

                dgvdata.Rows.Clear();
                foreach (Detalle_Compra dc in oCompra.oDetalleCompra)
                {
                    dgvdata.Rows.Add(new object[] { dc.oProducto.Nombre, dc.PrecioCompra, dc.Cantidad, dc.MontoTotal });
                }

                txtmontototal.Text = oCompra.MontoTotal.ToString("0.00");
            }
            else
            {
                MessageBox.Show("El documento que busca no existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtfecha.Text = "";
            txttipodocumento.Text = "";
            txtusuario.Text = "";
            txtdocproveedor.Text = "";
            txtnombreproveedor.Text = "";
            dgvdata.Rows.Clear();
            txtmontototal.Text = "0.00";
        }

        private void btnexporterexcel_Click(object sender, EventArgs e)
        {
            if (txttipodocumento.Text == "")
            {
                MessageBox.Show("No se encontraron resultados para mostrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string Texto_Html = Properties.Resources.PlantillaCompra.ToString();
            Negocio odatos = new BL_Negocio().ObtenerDatos();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.Nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", odatos.NIT);
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion);
            Texto_Html = Texto_Html.Replace("@tipodocumento", txttipodocumento.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", txtnumerodocumento.Text);
            Texto_Html = Texto_Html.Replace("@docproveedor", txtdocproveedor.Text);
            Texto_Html = Texto_Html.Replace("@nombreproveedor", txtnombreproveedor.Text);
            Texto_Html = Texto_Html.Replace("@fecharegistro", txtfecha.Text);
            Texto_Html = Texto_Html.Replace("@usuarioregistro", txtusuario.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioCompra"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }

            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", txtmontototal.Text);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Compra_{0}.pdf", txtnumerodocumento.Text);
            savefile.Filter = "Pdf Files|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    bool obtenido = true;
                    byte[] byteImage = new BL_Negocio().ObtenerLogo(out obtenido);

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
                        img.ScaleToFit(80, 80);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));
                        pdfDoc.Add(img);
                    }

                    using (StringReader sr = new StringReader(Texto_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("El documento ha sido generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void frmDetalleCompra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
