namespace Usuarios.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public int NumDocumento { get; set; }
        public int IdTipoDocumento { get; set; }
        public int IdCiudadResidencia { get; set; }
        public int IdDepartamentoResidencia { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public int Celular { get; set; }
        public string Correo { get; set; }
        public string Ocupacion { get; set; }
        public bool Activo { get; set; }
    }
}
