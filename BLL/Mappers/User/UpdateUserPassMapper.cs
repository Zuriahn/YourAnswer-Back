using DAL.Functions.User;

namespace BLL.Mappers.User
{
  public class UpdateUserPassMapper
  {
    public async Task UpdateUserPass(string Password, int UserId)
    {
      await new UpdateUserPassCS().UpdateUserPassAsync(Password, UserId);
    }
  }
}
