﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class BL_Categoria
    {
        private DA_Categoria objcd_Categoria = new DA_Categoria();

        public List<Categoria> Listar()
        {
            return objcd_Categoria.Listar();
        }

        public int Registrar(Categoria obj, out string Mensaje)
        {
            Mensaje = String.Empty;

          

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario la Descripcion de la Categoria\n";
            }

            if (Mensaje != String.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Categoria.Registrar(obj, out Mensaje);
            }

        }

        public bool Editar(Categoria obj, out string Mensaje)
        {
            Mensaje = String.Empty;



            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario la Descripcion de la Categoria\n";
            }

            if (Mensaje != String.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Categoria.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Categoria obj, out string Mensaje)
        {
            return objcd_Categoria.Eliminar(obj, out Mensaje);
        }

    }
}


