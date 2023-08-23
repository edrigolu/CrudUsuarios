using System.Data.SqlClient;
using System.Data;

namespace Usuarios.Datos
{
    public class ConfiguracionD
    {
        private readonly SqlConnection Conexion = new SqlConnection("Server=localhost;DataBase= PruebaUsuarios;Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion;
        }
    }
}
