using DAL.DataBase;
using DAL.DBModels;
using DAL.DTO.User;

namespace DAL.Functions.User
{
    public class SignUpUserCS
  {
    public async Task<UserDM> SignUpUserAsync(SignUpDTO UserDTO)
    {

      var User = new UserDM()
      {
        Username = UserDTO.Username,
        Name = UserDTO.Name,
        Email = UserDTO.Email,
        Password = UserDTO.Password,
        Image = UserDTO.Image,
        Date = DateTime.Now.ToString(),
        Status = true
      };

      using(var context = new DataBaseContext(DataBaseContext.ops.dbOptions))
      {
        context.Add(User);
        await context.SaveChangesAsync();
      }
      return User;
    }

  }
}
