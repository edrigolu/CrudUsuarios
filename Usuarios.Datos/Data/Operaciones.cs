using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Usuarios.Entidades;

namespace Usuarios.Datos.Data
{
    public class Operaciones
    {
        public void Eliminar(int v)
        {
            throw new NotImplementedException();
        }


        public List<Municipios> ObtenerMunicipios(int CodigoDepartamento)
        {
            List<Municipios> oListarMunicipios = new List<Municipios>();
            using (SqlConnection oConexion = new SqlConnection(Configuracion.conexion))
            {
                SqlCommand cmd = new SqlCommand("PA_ObtenerCiudadesPorDepartamento", oConexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("CodigoDepartamento", CodigoDepartamento);
                cmd.CommandTimeout = 600;
                oConexion.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    oListarMunicipios.Add(new Municipios
                    {
                        IdMunicipio = Convert.ToInt32(dr["IdMunicipio"]),
                        Municipio = Convert.ToString(dr["Municipio"].ToString())
                    });

                }
                dr.Close();
            }
            return oListarMunicipios;
        }

        public List<Departamentos> ObtenerDepartamentos()
        {
            List<Departamentos> oListarDepartamentos = new List<Departamentos>();
            using (SqlConnection oConexion = new SqlConnection(Configuracion.conexion))
            {
                SqlCommand cmd = new SqlCommand("PA_ObtenerDepartamentos", oConexion)
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = 600
                };
                oConexion.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    oListarDepartamentos.Add(new Departamentos
                    {
                        CodigoDane = Convert.ToInt32(dr["CodigoDane"]),
                        Departamento = Convert.ToString(dr["Departamento"].ToString())
                    });
                }
                dr.Close();
            }
            return oListarDepartamentos;
        }


        public List<TiposDocumento> ObtenerTipoDocumento()
        {
            List<TiposDocumento> oListarTipoDocumento = new List<TiposDocumento>();
            using (SqlConnection oConexion = new SqlConnection(Configuracion.conexion))
            {
                SqlCommand cmd = new SqlCommand("PA_ListarTipoDocumento", oConexion)
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = 600
                };
                oConexion.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    oListarTipoDocumento.Add(new TiposDocumento
                    {
                        IdTipoDocumento = Convert.ToInt32(dr["IdTipoDocumento"]),
                        TipoDocumento = Convert.ToString(dr["TipoDocumento"].ToString())
                    });
                }
                dr.Close();
            }
            return oListarTipoDocumento;
        }
    }
}
