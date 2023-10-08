using System.ComponentModel.DataAnnotations;

namespace PersonData.DAL.Entities
{
    public class NaturalPerson : Entity
    {
        [Display(Name = "Nombre Completo")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        [Required(ErrorMessage = "¡El campo {0} es requerido!")]
        public string FullName { get; set; }

        [Display(Name = "Email")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        [Required(ErrorMessage = "¡El campo {0} es requerido!")]
        public string Email { get; set; }

        [Display(Name = "Año de nacimiento")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        [Required(ErrorMessage = "¡El campo {0} es requerido!")]
        public string BirthYear { get; set; }

        [Display(Name = "Edad")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")] 
        [Required(ErrorMessage = "¡El campo {0} es requerido!")]
        public string Age { get; set; }
    }
}
