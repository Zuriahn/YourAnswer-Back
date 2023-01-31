using DAL.Functions.User;

namespace BLL.Mappers.User
{
  public class DownUserMapper
  {
    public async Task DownUser(int UserId)
    {
      await new DownUserCS().DownUserAsync(UserId);
    }
  }
}
