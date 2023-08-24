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

        public  DataTable FiltrarNombre(string nombre)
        {
            using (SqlConnection oConexion = new SqlConnection(Configuracion.Conexion))
            {
                SqlCommand comando = new SqlCommand("PA_FiltrarPorNombre", oConexion)
                {
                    CommandType = CommandType.StoredProcedure
                };               
                comando.Parameters.AddWithValue("@Nombre", nombre);
                oConexion.Open();
                comando.ExecuteNonQuery();                
                DataTable dt = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comando);
                sqlDataAdapter.Fill(dt);
                comando.Parameters.Clear();
                return dt;
            }
        }


        public DataTable FiltrarApellido(string apellido)
        {
            using (SqlConnection oConexion = new SqlConnection(Configuracion.Conexion))
            {
                SqlCommand comando = new SqlCommand("PA_FiltrarPorApellido", oConexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@Apellidos", apellido);
                oConexion.Open();
                comando.ExecuteNonQuery();               
                DataTable dt = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comando);
                sqlDataAdapter.Fill(dt);
                comando.Parameters.Clear();
                return dt;
            }
        }

        public DataTable FiltrarNumDocumento(string numerodocumento)
        {
            using (SqlConnection oConexion = new SqlConnection(Configuracion.Conexion))
            {
                SqlCommand comando = new SqlCommand("PA_FiltrarPorNumeroDocumento", oConexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@NumDoc", numerodocumento);
                oConexion.Open();
                comando.ExecuteNonQuery();
                
                DataTable dt = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comando);
                sqlDataAdapter.Fill(dt);
                comando.Parameters.Clear();
                return dt;
            }
        }

        public bool CrearUsuario(Persona usuario)
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

        public List<PersonaViewModel> ObtenerUsuarios()
        {
            List<PersonaViewModel> oListarUsuarios = new List<PersonaViewModel>();
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
                    oListarUsuarios.Add(new PersonaViewModel
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

        public bool Modificar(Entidades.Persona usuario)
        {
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(Configuracion.Conexion))
            {
                try
                {
                    SqlCommand comando = new SqlCommand("PA_ModificarUsuario", oConexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    comando.Parameters.AddWithValue("IdUsuario", usuario.IdUsuario);
                    comando.Parameters.AddWithValue("Nombres", usuario.Nombres);
                    comando.Parameters.AddWithValue("Apellidos", usuario.Apellidos);
                    comando.Parameters.AddWithValue("Edad", usuario.Edad);
                    comando.Parameters.AddWithValue("NumeroDocumento", usuario.NumeroDocumento);
                    comando.Parameters.AddWithValue("IdTipoDocumento", Convert.ToInt32(usuario.IdTipoDocumento));
                    comando.Parameters.AddWithValue("IdCiudadResidencia", Convert.ToInt32(usuario.IdCiudadResidencia));
                    comando.Parameters.AddWithValue("IdDepartamentoResidencia", Convert.ToInt32(usuario.IdDepartamentoResidencia));
                    comando.Parameters.AddWithValue("Direccion", usuario.Direccion);
                    comando.Parameters.AddWithValue("Telefono", usuario.Telefono);
                    comando.Parameters.AddWithValue("Celular", usuario.Celular);
                    comando.Parameters.AddWithValue("Correo", usuario.Correo);
                    comando.Parameters.AddWithValue("Ocupacion", usuario.Ocupacion);
                    comando.Parameters.AddWithValue("Activo", 1);
                    comando.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    oConexion.Open();
                    comando.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(comando.Parameters["Resultado"].Value);
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }
    }
}
