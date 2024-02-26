using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProject.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Şifre alanı boş geçilemez")]
        public string? Password { get; set; }
    }
}
