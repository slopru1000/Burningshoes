using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CapaEntidad;
using System.Linq;

namespace CapaDatos
{
    public class DA_Rol
    {
        // Método para listar roles con sus permisos asociados
        public List<Rol> Listar()
        {
            List<Rol> lista = new List<Rol>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT r.IdRol, r.Descripcion, p.NombreMenu ");
                    query.AppendLine("FROM ROL r ");
                    query.AppendLine("LEFT JOIN PERMISO p ON r.IdRol = p.IdRol");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            // Buscar si el rol ya está en la lista
                            Rol rol = lista.FirstOrDefault(r => r.IdRol == Convert.ToInt32(dr["IdRol"]));

                            if (rol == null)
                            {
                                rol = new Rol()
                                {
                                    IdRol = Convert.ToInt32(dr["IdRol"]),
                                    Descripcion = dr["Descripcion"].ToString(),
                                    Permisos = new List<Permiso>()
                                };
                                lista.Add(rol);
                            }

                            // Agregar el permiso al rol
                            if (dr["NombreMenu"] != DBNull.Value)
                            {
                                rol.Permisos.Add(new Permiso()
                                {
                                    NombreMenu = dr["NombreMenu"].ToString()
                                });
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<Rol>();
                }
            }

            return lista;
        }

        // Método para registrar un nuevo rol con permisos
        public int Registrar(Rol rol, List<string> privilegiosSeleccionados, out string mensaje)
        {
            int idRolGenerado = 0;
            mensaje = string.Empty;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARROL", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Descripción del rol
                    cmd.Parameters.AddWithValue("@Descripcion", rol.Descripcion);

                    // Crear tabla de permisos
                    DataTable dtPermisos = new DataTable();
                    dtPermisos.Columns.Add("NombreMenu", typeof(string));

                    foreach (string menu in privilegiosSeleccionados)
                    {
                        dtPermisos.Rows.Add(menu);
                    }

                    SqlParameter permisosParam = cmd.Parameters.AddWithValue("@Permisos", dtPermisos);
                    permisosParam.SqlDbType = SqlDbType.Structured;
                    permisosParam.TypeName = "dbo.PermisoType";

                    // Parámetros de salida
                    SqlParameter outputId = new SqlParameter("@IdRolResultado", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputId);

                    SqlParameter outputMsg = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputMsg);

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    idRolGenerado = Convert.ToInt32(cmd.Parameters["@IdRolResultado"].Value);
                    mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    idRolGenerado = 0;
                    mensaje = ex.Message;
                }
            }

            return idRolGenerado;
        }
    }
}
