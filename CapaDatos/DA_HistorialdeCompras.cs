using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DA_HistorialdeCompras
    {
        public List<Compra> Listar()
        {
            List<Compra> lista = new List<Compra>();

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    string query = @"SELECT C.IdCompra, C.NumeroDocumento, C.IdUsuario, U.NombreCompleto AS NombreUsuario,
                                    C.FechaRegistro, C.MontoTotal
                             FROM COMPRA C
                             INNER JOIN USUARIO U ON U.IdUsuario = C.IdUsuario";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Compra()
                            {
                                IdCompra = Convert.ToInt32(dr["IdCompra"]),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                oUsuario = new Usuario()
                                {
                                    IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                    NombreCompleto = dr["NombreUsuario"].ToString()
                                },
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"])
                            });
                        }
                    }
                }
            }
            catch
            {
                lista = new List<Compra>();
            }

            return lista;
        }

    }
}