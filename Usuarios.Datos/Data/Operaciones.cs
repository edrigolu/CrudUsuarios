using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Usuarios.Entidades;

namespace Usuarios.Datos.Data
{
    public class Operaciones
    {
        public void Eliminar(string idUsuario)
        {
            using (SqlConnection oConexion = new SqlConnection(Configuracion.Conexion))
            {
                SqlCommand comando = new SqlCommand("PA_EliminarUsuario", oConexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("IdUsuario", Convert.ToInt32(idUsuario).ToString());
                oConexion.Open();
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
        }

        public bool CrearUsuario(Usuario usuario)
        {
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(Configuracion.Conexion))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PA_CrearUsuario", oConexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("Nombres", usuario.Nombres);
                    cmd.Parameters.AddWithValue("Apellidos", usuario.Apellidos);
                    cmd.Parameters.AddWithValue("Edad", usuario.Edad);
                    cmd.Parameters.AddWithValue("NumeroDocumento", usuario.NumeroDocumento);
                    cmd.Parameters.AddWithValue("IdTipoDocumento", Convert.ToInt32(usuario.IdTipoDocumento));
                    cmd.Parameters.AddWithValue("IdCiudadResidencia", Convert.ToInt32(usuario.IdCiudadResidencia));
                    cmd.Parameters.AddWithValue("IdDepartamentoResidencia", Convert.ToInt32(usuario.IdDepartamentoResidencia));
                    cmd.Parameters.AddWithValue("Direccion", usuario.Direccion);
                    cmd.Parameters.AddWithValue("Telefono", usuario.Telefono);
                    cmd.Parameters.AddWithValue("Celular", usuario.Celular);
                    cmd.Parameters.AddWithValue("Correo", usuario.Correo);
                    cmd.Parameters.AddWithValue("Ocupacion", usuario.Ocupacion);
                    cmd.Parameters.AddWithValue("Activo", 1);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;

                    oConexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }


        public List<Municipios> ObtenerMunicipios(int CodigoDepartamento)
        {
            List<Municipios> oListarMunicipios = new List<Municipios>();
            using (SqlConnection oConexion = new SqlConnection(Configuracion.Conexion))
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
            using (SqlConnection oConexion = new SqlConnection(Configuracion.Conexion))
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
            List<TiposDocumento> oListarTiposDocumento = new List<TiposDocumento>();
            using (SqlConnection oConexion = new SqlConnection(Configuracion.Conexion))
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
                    oListarTiposDocumento.Add(new TiposDocumento
                    {
                        IdTipoDocumento = Convert.ToInt32(dr["IdTipoDocumento"]),
                        TipoDocumento = Convert.ToString(dr["TipoDocumento"].ToString())
                    });
                }
                dr.Close();
            }
            return oListarTiposDocumento;
        }


        public List<UsuarioViewModel> ObtenerUsuarios()
        {
            List<UsuarioViewModel> oListarUsuarios = new List<UsuarioViewModel>();
            using (SqlConnection oConexion = new SqlConnection(Configuracion.Conexion))
            {
                SqlCommand cmd = new SqlCommand("PA_ListarUsuarios", oConexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                oConexion.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    oListarUsuarios.Add(new UsuarioViewModel
                    {
                        IdUsuario = int.Parse(dr["IdUsuario"].ToString()),
                        Nombres = dr["Nombre"].ToString(),
                        Apellidos = dr["Apellidos"].ToString(),
                        Edad = dr["Edad"].ToString(),
                        NumeroDocumento = dr["NumeroDocumento"].ToString(),
                        TipoDocumento = Convert.ToString(dr["TipoDocumento"]).ToString(),
                        Departamento = dr["Departamento"].ToString(),
                        Municipio = dr["Municipio"].ToString(),
                        Direccion = dr["Direccion"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Celular = dr["Celular"].ToString(),
                        Correo = dr["Correo"].ToString(),
                        Ocupacion = dr["Ocupacion"].ToString(),
                        Activo = dr["Activo"].Equals("1"),
                    });
                }
                dr.Close();
            }
            return oListarUsuarios;
        }


        public bool Editar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(Usuario oPersona)
        {
            throw new NotImplementedException();
        }
    }
}
