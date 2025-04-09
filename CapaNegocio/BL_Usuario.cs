using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;


namespace CapaNegocio
{
    public class BL_Usuario
    {
        private DA_Usuario objcd_usuario = new DA_Usuario();

        public List<Usuario> Listar()
        {
            return objcd_usuario.Listar();
        }

        public int Registrar(Usuario obj, out string Mensaje)
        {
            Mensaje = String.Empty; 

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario registrar el documento del Usuario\n";
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario registrar el nombre completo del Usuario\n";
            }

            if (obj.Clave == "")
            {
                Mensaje += "Es necesario registrar el clave del Usuario\n";
            }

            if (Mensaje != String.Empty)
            {
                return 0;
            }
            else
            {
                  return objcd_usuario.Registrar(obj, out Mensaje);
            }

        }

        public bool Editar(Usuario obj, out string Mensaje)
        {
            Mensaje = String.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario registrar el documento del Usuario\n";
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario registrar el nombre completo del Usuario\n";
            }

            if (obj.Clave == "")
            {
                Mensaje += "Es necesario registrar el clave del Usuario\n";
            }

            if (Mensaje != String.Empty)
            {
                return false;
            }
            else
            {
                return objcd_usuario.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            return objcd_usuario.Eliminar(obj, out Mensaje);
        }

    }
}
