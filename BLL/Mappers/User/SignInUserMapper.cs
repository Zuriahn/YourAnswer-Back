using BLL.ViewModel.User;
using DAL.DTO.User;
using DAL.Functions.User;

namespace BLL.Functions.User
{
  public class SignInUserMapper
  {
    public async Task<UserVM> SignInUser(SignInVM SignInVM)
    {
      var userDM = await new SignInUserCS().SignInUserAsync(new SignUpDTO
      {
        Email = SignInVM.email,
        Password = SignInVM.password
      });

      if (userDM == null)
      {
        return null;
      }

      return new UserVM
      {
        id = userDM.Id,
        username = userDM.Username,
        status = userDM.Status,
      };

    }

  }
}
