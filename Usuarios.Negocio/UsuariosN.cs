using System;
using System.Data;
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

        public void Insertar()
        {            
            operaciones.CrearUsuario(usuario);
        }
        
        //public void Editar()
        //{
        //    Usuario usuario = new Usuario();
        //    operaciones.Editar();
        //}

        public void Eliminar(string idUsuario)
        {
            operaciones.Eliminar(Convert.ToInt32(idUsuario).ToString());
        }
    }
}
