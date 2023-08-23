using System.Data.SqlClient;
using System.Data;

namespace Usuarios.Datos
{
    public class UsuarioD
    {
        private readonly ConfiguracionD conexion = new ConfiguracionD();

        SqlDataReader sqlDataReader;
        readonly DataTable dataTable = new DataTable();
        readonly SqlCommand sqlCommand = new SqlCommand();

        public DataTable Mostrar()
        {
            sqlCommand.Connection = conexion.AbrirConexion();
            sqlCommand.CommandText = "MostrarUsuarios";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);
            conexion.CerrarConexion();
            return dataTable;
        }

        public void Insertar(string nombre,
                             string apellido,
                             int edad,
                             int numeroDocumento,
                             int idTipoDocumento,
                             int idCiudadResidencia,
                             int idDepartamentoResidencia,
                             string direccion,
                             int telefono,
                             int celular,
                             string correo,
                             string ocupacion)
        {
            //Procedimiento
            sqlCommand.Connection = conexion.AbrirConexion();
            sqlCommand.CommandText = "PA_CrearUsuario";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Nombre", nombre);
            sqlCommand.Parameters.AddWithValue("@Apellido", apellido);
            sqlCommand.Parameters.AddWithValue("@Edad", edad);
            sqlCommand.Parameters.AddWithValue("@NumeroDocumento", numeroDocumento);
            sqlCommand.Parameters.AddWithValue("@IdTipoDocumento", idTipoDocumento);
            sqlCommand.Parameters.AddWithValue("@IdCiudadResidencia", idCiudadResidencia);
            sqlCommand.Parameters.AddWithValue("@IdDepartamentoResidencia", idDepartamentoResidencia);
            sqlCommand.Parameters.AddWithValue("@Direccion", direccion);
            sqlCommand.Parameters.AddWithValue("@Telefono", telefono);
            sqlCommand.Parameters.AddWithValue("@Celular", celular);
            sqlCommand.Parameters.AddWithValue("@Correo", correo);
            sqlCommand.Parameters.AddWithValue("@Ocupacion", ocupacion);
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Parameters.Clear();
        }

        public void Editar(string nombre,
                           string apellido,
                           int edad,
                           int numeroDocumento,
                           int idTipoDocumento,
                           int idCiudadResidencia,
                           int idDepartamentoResidencia,
                           string direccion,
                           int telefono,
                           int celular,
                           string correo,
                           string ocupacion,
                           int idUsuario)
        {
            sqlCommand.Connection = conexion.AbrirConexion();
            sqlCommand.CommandText = "PA_EditarUsuario";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Nombre", nombre);
            sqlCommand.Parameters.AddWithValue("@Apellido", apellido);
            sqlCommand.Parameters.AddWithValue("@Edad", edad);
            sqlCommand.Parameters.AddWithValue("@NumeroDocumento", numeroDocumento);
            sqlCommand.Parameters.AddWithValue("@IdTipoDocumento", idTipoDocumento);
            sqlCommand.Parameters.AddWithValue("@IdCiudadResidencia", idCiudadResidencia);
            sqlCommand.Parameters.AddWithValue("@IdDepartamentoResidencia", idDepartamentoResidencia);
            sqlCommand.Parameters.AddWithValue("@Direccion", direccion);
            sqlCommand.Parameters.AddWithValue("@Telefono", telefono);
            sqlCommand.Parameters.AddWithValue("@Celular", celular);
            sqlCommand.Parameters.AddWithValue("@Correo", correo);
            sqlCommand.Parameters.AddWithValue("@Ocupacion", ocupacion);
            sqlCommand.Parameters.AddWithValue("@id", idUsuario);
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Parameters.Clear();
        }

        public void Eliminar(int idUsuario)
        {
            sqlCommand.Connection = conexion.AbrirConexion();
            sqlCommand.CommandText = "PA_EliminarUsuario";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@IdUsuario", idUsuario);
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Parameters.Clear();
        }
    }
}
