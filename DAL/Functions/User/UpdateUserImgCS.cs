using DAL.DataBase;
using DAL.DBModels;

namespace DAL.Functions.User
{
  public class UpdateUserImgCS
  {
    public async Task UpdateUserImgAsync(string Img, int UserId)
    {
      var User = new UserDM
      {
        Id = UserId,
        Image = Img
      };

      using (var context = new DataBaseContext(DataBaseContext.ops.dbOptions))
      {
        context.Update(User);
        await context.SaveChangesAsync();
      }

    }
  }
}
