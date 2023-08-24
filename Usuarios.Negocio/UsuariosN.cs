using System;
using Usuarios.Datos.Data;
using Usuarios.Entidades;

namespace Usuarios.Negocio
{
    public class UsuariosN
    {
        private readonly Operaciones operaciones = new Operaciones();
        readonly Persona usuario = new Persona();

        public void MostrarDepartamentos()
        {
            operaciones.ObtenerDepartamentos();
        }

        public void MostrarUsuarios()
        {
            operaciones.ObtenerUsuarios();
        }

        public void ObtenerTipoDocumento()
        {
            operaciones.ObtenerTipoDocumento();
        }

        public void Crear()
        {            
            operaciones.CrearUsuario(usuario);
        }

        public void Modificar()
        {            
            operaciones.Modificar(usuario);
        }

        public void Eliminar(string idUsuario)
        {
            operaciones.Eliminar(Convert.ToInt32(idUsuario).ToString());
        }
    }
}
