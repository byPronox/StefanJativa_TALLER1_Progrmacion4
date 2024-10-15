using System.ComponentModel.DataAnnotations;

namespace StefanJativa_TALLER1_Progrmacion4.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }
        [MaxLength(100)]
        public string Ciudad { get; set; }
        [MaxLength(100)]
        public string TitulosExtrangeros { get; set; }
        [MaxLength(100)]
        public bool AceptaExtrangeros { get; set; }
    }
}
