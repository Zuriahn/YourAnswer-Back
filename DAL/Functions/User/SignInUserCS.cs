using DAL.DataBase;
using DAL.DBModels;
using DAL.DTO.User;
using Microsoft.EntityFrameworkCore;

namespace DAL.Functions.User
{
  public class SignInUserCS
  {
    public async Task<UserDM> SignInUserAsync(SignUpDTO SignUpDTO)
    {
      using(var context = new DataBaseContext(DataBaseContext.ops.dbOptions))
      {
        return await context.User.Where(x => x.Email == SignUpDTO.Email && x.Password == SignUpDTO.Password).Select(x => new UserDM
        {
          Id = x.Id,
          Username = x.Username,
          Name = x.Name,
          Email = x.Email,
          Image = x.Image,
          Status = x.Status
        }).FirstOrDefaultAsync();
      }

    }
  }
}
