using BLL.ViewModel.User;
using DAL.DTO.User;
using DAL.Functions.User;

namespace BLL.Functions.User
{
  public class UpdateUserMapper
  {
    public async Task UpdateUser(UpdUserVM UserUpdVM)
    {
      await new UpdateUserCS().UpdateUserAsync(new UpdUserDTO
      {
        Id = UserUpdVM.id,
        Image = UserUpdVM.image,
        Name = UserUpdVM.name,
        Password = UserUpdVM.password
      });

    }

  }
}
