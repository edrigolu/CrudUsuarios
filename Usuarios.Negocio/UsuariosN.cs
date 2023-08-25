using System;
using System.Collections.Generic;
using System.Data;
using Usuarios.Datos.Data;
using Usuarios.Entidades;

namespace Usuarios.Negocio
{
    public class UsuariosN
    {
        private readonly Operaciones operaciones = new Operaciones();
        readonly Persona usuario = new Persona();        

        public List<Departamentos> ListarDepartamentos()
        {
           return operaciones.ListarDepartamentos();
        }

        public List<PersonaViewModel> ListarUsuarios()
        {
           return operaciones.ListarUsuarios();
        }

        public List<TiposDocumento> ListarTipoDocumento()
        {
           return operaciones.ListarTipoDocumento();
        }

        public bool CrearUsuario(Persona usuario)
        {            
           return operaciones.CrearUsuario(usuario);
        }

        public bool Modificar(Persona usuario)
        {            
           return operaciones.Modificar(usuario);
        }

        public void Eliminar(string idUsuario)
        {
            operaciones.Eliminar(Convert.ToInt32(idUsuario).ToString());
        }

        public DataTable FiltrarNombre(string nombre)
        {
            return operaciones.FiltrarNombre(nombre);
        }

       public DataTable FiltrarApellido(string apellido)
        {
            return operaciones.FiltrarApellido(apellido);
        }

        public DataTable FiltrarNumDocumento(string numerodocumento)
        {
            return operaciones.FiltrarNumDocumento(numerodocumento);
        }
    }
}
