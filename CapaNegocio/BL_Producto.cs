﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class BL_Producto
    {


        private DA_Producto objcd_Producto = new DA_Producto();


        public List<Producto> Listar()
        {
            return objcd_Producto.Listar();
        }

        public int Registrar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Codigo == "")
            {
                Mensaje += "Es necesario registrar el codigo del Producto\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario registrar el nombre del Producto\n";
            }

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario registrar la Descripcion del Producto\n";
            }

            if (obj.Talla == "")
            {
                Mensaje += "Es necesario registrar la Talla del Producto\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Producto.Registrar(obj, out Mensaje);
            }


        }


        public bool Modificar(Producto obj, out string Mensaje)
        {

            Mensaje = string.Empty;


            if (obj.Codigo == "")
            {
                Mensaje += "Es necesario registrar el codigo del Producto\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario registrar el nombre del Producto\n";
            }

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario registrar la Descripcion del Producto\n";
            }

            if (obj.Talla == "")
            {
                Mensaje += "Es necesario registrar la Talla del Producto\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Producto.Modificar(obj, out Mensaje);
            }
        }


        public bool Eliminar(Producto obj, out string Mensaje)
        {
            return objcd_Producto.Eliminar(obj, out Mensaje);
        }
    }
}