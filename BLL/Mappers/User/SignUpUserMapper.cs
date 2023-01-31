using BLL.ViewModel.User;
using DAL.DTO.User;
using DAL.Functions.User;

namespace BLL.Functions.User
{
  public class SignUpUserMapper 
  {
    public async Task<UserVM> SignUpUser(SignUpVM SignUpVM)
    {
      var UserDM = await new SignUpUserCS().SignUpUserAsync(new SignUpDTO
      {
        Username = SignUpVM.username,
        Name = SignUpVM.name,
        Email = SignUpVM.email,
        Password = SignUpVM.password,
        Image = SignUpVM.image
      });

      if (UserDM == null)
      {
        return null;
      }

      return new UserVM
      {
        id = UserDM.Id,
        username = UserDM.Username
      };

    }
  }
}
