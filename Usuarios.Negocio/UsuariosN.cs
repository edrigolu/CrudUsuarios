using System.Data;
using System;
using Usuarios.Datos;

namespace Usuarios.Negocio
{
    public class UsuariosN
    {
        private readonly UsuarioD usuarioD = new UsuarioD();

        public DataTable MostrarUsuarios()
        {
            DataTable tabla = new DataTable();
            tabla = usuarioD.Mostrar();
            return tabla;
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
            usuarioD.Insertar(nombre,
                            apellido,
                            Convert.ToInt32(edad),
                            Convert.ToInt32(numeroDocumento),
                           Convert.ToInt32(idTipoDocumento),
                            Convert.ToInt32(idCiudadResidencia),
                            Convert.ToInt32(idDepartamentoResidencia),
                            direccion,
                            Convert.ToInt32(telefono),
                            Convert.ToInt32(celular),
                            correo,
                            ocupacion);
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
            usuarioD.Editar(nombre,
                            apellido,
                            Convert.ToInt32(edad),
                            Convert.ToInt32(numeroDocumento),
                            Convert.ToInt32(idTipoDocumento),
                            Convert.ToInt32(idCiudadResidencia),
                            Convert.ToInt32(idDepartamentoResidencia),
                            direccion,
                            Convert.ToInt32(telefono),
                            Convert.ToInt32(celular),
                            correo,
                            ocupacion,
                           Convert.ToInt32(idUsuario));
        }

        public void Eliminar(string idUsuario)
        {
            usuarioD.Eliminar(Convert.ToInt32(idUsuario));
        }
    }
}
