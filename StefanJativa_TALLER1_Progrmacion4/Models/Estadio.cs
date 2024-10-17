using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace StefanJativa_TALLER1_Progrmacion4.Models
{
    public class Estadio
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Direccion { get; set; }
        [AllowNull]
        [MaxLength (100)]
        public string Ciudad { get; set; }

        [Required]
        [Range (0,80000)]
        public int? Capacidad { get; set; }

        [ForeignKey]

    }
}
