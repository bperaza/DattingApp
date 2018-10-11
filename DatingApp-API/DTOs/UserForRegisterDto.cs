using System.ComponentModel.DataAnnotations;

namespace DatingApp_API.DTOs
{
    public class UserForRegisterDto
    {

        // Agregar DataAnnotation para Validar Campos
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength=4, ErrorMessage="Debes Especificar Password Mayor a 4 caracteres ")]
        public string Password { get; set; }
    }
}