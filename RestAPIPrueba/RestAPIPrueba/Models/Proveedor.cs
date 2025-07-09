using System.ComponentModel.DataAnnotations;

namespace RestAPIPrueba.Models
{
    public class Proveedor
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "El nombre del proveedor debe tener al menos 3 caracteres.")]
        public string NombreProveedor { get; set; } = null!;

        [Phone(ErrorMessage = "El teléfono no tiene un formato válido.")]
        public string Telefono { get; set; } = null!;

        [EmailAddress(ErrorMessage = "El correo no tiene un formato válido.")]
        public string Correo { get; set; } = null!;
    }
}