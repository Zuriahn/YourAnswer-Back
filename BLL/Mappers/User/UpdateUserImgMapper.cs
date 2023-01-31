using DAL.Functions.User;

namespace BLL.Mappers.User
{
  public class UpdateUserImgMapper
  {
    public async Task UpdateUserImg(string Img, int UserId)
    {
      await new UpdateUserImgCS().UpdateUserImgAsync(Img, UserId);
    }
  }
}
