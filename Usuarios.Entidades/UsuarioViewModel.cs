namespace Usuarios.Entidades
{
    public class UsuarioViewModel
    {
        public int IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Edad { get; set; }
        public string NumeroDocumento { get; set; }       
        public string TipoDocumento { get; set; }       
        public string Municipio { get; set; }        
        public string Departamento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string Ocupacion { get; set; }
        public bool Activo { get; set; }
    }
}
