using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCClinica.Models
{
    [Table("Medico")]
    public class Medico
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Apellido { get; set; }
        [RegularExpression("[a-zA-Z]{2}[1-9]{4}$")]
        public string Matricula { get; }

    }
}
