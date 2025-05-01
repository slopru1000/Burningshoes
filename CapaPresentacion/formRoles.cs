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

namespace CapaPresentacion
{
    public partial class formRoles : Form
    {
        private BL_Rol objNegocioRol = new BL_Rol();

        public formRoles()
        {
            InitializeComponent();
        }

        private void formRoles_Load(object sender, EventArgs e)
        {
            // Asegúrate de que las columnas estén configuradas antes de cargar los datos
            dgvdatarol.Columns.Add("IdRol", "Id Rol");
            dgvdatarol.Columns.Add("Descripcion", "Nombre del Rol");
            dgvdatarol.Columns.Add("Permisos", "Permisos");

            // Cargar los roles y permisos en el DataGridView
            CargarRolesEnDataGridView();
        }

        private void CargarRolesEnDataGridView()
        {
            try
            {
                // Obtener todos los roles desde la capa de negocio
                List<Rol> listaRoles = objNegocioRol.Listar();

                // Limpiar el DataGridView antes de llenarlo con nuevos datos
                dgvdatarol.Rows.Clear();

                // Recorrer la lista de roles y agregar cada uno con sus permisos
                foreach (Rol rol in listaRoles)
                {
                    // Verificamos si Permisos no es null antes de intentar acceder a sus valores
                    string permisosString = rol.Permisos != null && rol.Permisos.Any()
                        ? string.Join("\n", rol.Permisos.Select(p => p.NombreMenu))  // Aquí está el salto de línea
                        : "Sin permisos";

                    // Agregar los datos al DataGridView: IdRol, Descripcion y los Permisos
                    dgvdatarol.Rows.Add(rol.IdRol, rol.Descripcion, permisosString);
                }

                // Configurar el estilo de la columna de permisos para mostrar saltos de línea
                dgvdatarol.Columns["Permisos"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvdatarol.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los roles: " + ex.Message);
            }
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

        private void btncerrar_Click(object sender, EventArgs e)
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

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string descripcion = txtnombredelrol.Text.Trim();
            List<string> privilegiosSeleccionados = new List<string>();

            foreach (var item in clbPrivilegios.CheckedItems)
            {
                privilegiosSeleccionados.Add(item.ToString());
            }

            if (string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("Debes ingresar una descripción para el rol.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (privilegiosSeleccionados.Count == 0)
            {
                MessageBox.Show("Debes seleccionar al menos un privilegio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Rol nuevoRol = new Rol { Descripcion = descripcion };

            string mensaje = string.Empty;
            int idRolGenerado = objNegocioRol.Registrar(nuevoRol, privilegiosSeleccionados, out mensaje);

            if (idRolGenerado > 0)
            {
                MessageBox.Show("Rol registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar campos
                txtnombredelrol.Clear();
                for (int i = 0; i < clbPrivilegios.Items.Count; i++)
                {
                    clbPrivilegios.SetItemChecked(i, false);
                }

                // Recargar el DataGridView
                CargarRolesEnDataGridView();
            }
            else
            {
                MessageBox.Show("No se pudo registrar el rol.\n" + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

