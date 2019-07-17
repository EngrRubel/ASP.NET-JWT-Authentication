/* Author : Rubel talukder */
/* mobile : 01748892601 */
/* email  : rubel.jkkniu@gmail.com */
using System.ComponentModel.DataAnnotations;

namespace JWTApi.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
