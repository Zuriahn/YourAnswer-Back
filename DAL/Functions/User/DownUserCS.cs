using DAL.DataBase;
using DAL.DBModels;

namespace DAL.Functions.User
{
  public class DownUserCS
  {
    public async Task DownUserAsync(int UserId)
    {
      var User = new UserDM
      {
        Id = UserId,
        Status = false
      };

      using (var context = new DataBaseContext(DataBaseContext.ops.dbOptions))
      {
        context.Update(User);
        await context.SaveChangesAsync();
      }

    }
  }
}
