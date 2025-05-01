using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class BL_HistorialdeCompras
    {
        private DA_HistorialdeCompras objcd_Historial = new DA_HistorialdeCompras();

        public List<Compra> Listar()
        {
            return objcd_Historial.Listar();
        }
    }
}
