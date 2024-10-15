using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace StefanJativa_TALLER1_Progrmacion4.Models
{
    public class Jugador
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }
        [Required]
        [MaxLength (100)]
        public string Posicion { get; set; }
        [Required]
        [Range(0,110)]
        public int Edad {  get; set; }
        [NotNull]
        [MaxLength()]
        public string Equipo { get; set; }
    }
}
