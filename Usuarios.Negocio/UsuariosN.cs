using System;
using Usuarios.Datos.Data;
using Usuarios.Entidades;

namespace Usuarios.Negocio
{
    public class UsuariosN
    {
        private readonly Operaciones operaciones = new Operaciones();

        
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
            Usuario usuario = new Usuario();
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
