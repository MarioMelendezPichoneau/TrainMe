using System.ComponentModel.DataAnnotations;

namespace APIsTrainME.Models.ModelService
{
    public class UserLoginService
    {
        [EmailAddress(ErrorMessage ="Debe ingresar un correo valido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "El campo password es requerido")]
        public string Password { get; set; }
    }
}
