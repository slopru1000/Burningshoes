﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class BL_Rol
    {
        private DA_Rol objcd_rol = new DA_Rol();

        public List<Rol> Listar()
        {
            return objcd_rol.Listar();
        }

        public int Registrar(Rol rol, List<string> privilegiosSeleccionados, out string mensaje)
        {
            return objcd_rol.Registrar(rol, privilegiosSeleccionados, out mensaje);
        }
    }
}
