using System.ComponentModel.DataAnnotations;

namespace BLL.ViewModel.User
{
  public class SignInVM
    {
        [Required]
        public string email { get; set; }

        [Required]
        public string password { get; set; }
    }
}
