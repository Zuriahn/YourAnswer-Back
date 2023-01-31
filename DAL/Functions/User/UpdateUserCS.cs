using DAL.DataBase;
using DAL.DBModels;
using DAL.DTO.User;
using Microsoft.IdentityModel.Tokens;

namespace DAL.Functions.User
{
  public class UpdateUserCS
  {
    public async Task UpdateUserAsync(UpdUserDTO UserUpdDTO)
    {
      var User = new UserDM
      {
        Id= UserUpdDTO.Id,
        Image = UserUpdDTO.Image,
        Name = UserUpdDTO.Name,
        Password = UserUpdDTO.Password,
      };

      using (var context = new DataBaseContext(DataBaseContext.ops.dbOptions))
      {
        context.User.Attach(User);
        context.Entry(User).Property(n => n.Name).IsModified = UserUpdDTO.Name.IsNullOrEmpty() ? false: true;
        context.Entry(User).Property(i => i.Image).IsModified = UserUpdDTO.Image.IsNullOrEmpty() ? false : true;
        context.Entry(User).Property(p => p.Password).IsModified = UserUpdDTO.Password.IsNullOrEmpty() ? false : true;
        await context.SaveChangesAsync();
      }

    }
  }
}
