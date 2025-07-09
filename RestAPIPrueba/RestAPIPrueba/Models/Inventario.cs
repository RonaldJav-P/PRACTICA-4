using System;
using System.ComponentModel.DataAnnotations;

namespace RestAPIPrueba.Models
{
    public class Inventario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "ProductoId es obligatorio")]
        public int ProductoId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor que 0")]
        public int Cantidad { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(Inventario), nameof(ValidarFechaEntrada))]
        public DateTime FechaEntrada { get; set; }

        public static ValidationResult? ValidarFechaEntrada(DateTime fecha, ValidationContext context)
        {
            if (fecha > DateTime.Now)
                return new ValidationResult("La fecha de entrada no puede ser futura.");
            return ValidationResult.Success;
        }
    }
}
