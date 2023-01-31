using DAL.DataBase;
using DAL.DBModels;

namespace DAL.Functions.User
{
  public class UpdateUserPassCS
  {
    public async Task UpdateUserPassAsync(string Password, int UserId)
    {
      var User = new UserDM
      {
        Id = UserId,
        Password = Password
      };

      using (var context = new DataBaseContext(DataBaseContext.ops.dbOptions))
      {
        context.Update(User);
        await context.SaveChangesAsync();
      }

    }
  }
}
