namespace Usuarios.Entidades
{
    public class Persona
    {
       public int IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Edad { get; set; }
        public string NumeroDocumento { get; set; }
        public int IdTipoDocumento { get; set; }        
        public int IdCiudadResidencia { get; set; }    
        public decimal IdDepartamentoResidencia { get; set; }       
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string Ocupacion { get; set; }
        public bool Activo { get; set; }
    }
}
