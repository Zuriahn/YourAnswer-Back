using DAL.DataBase;
using DAL.DBModels;
using DAL.DTO.Commentary;

namespace DAL.Functions.Commentary
{
  public class AddCommentaryCS
  {
    public async Task<int> AddCommentaryAsync(CommentaryDTO CommentaryDTO)
    {
      var Commentary = new CommentaryDM
      {
        Description = CommentaryDTO.Description,
        UserId = CommentaryDTO.UserId,
        AnswerId = CommentaryDTO.AnswerId,
        Date = DateTime.Now.ToString(),
        Status = true
      };

      using (var context = new DataBaseContext(DataBaseContext.ops.dbOptions))
      {
        context.Add(Commentary);
        await context.SaveChangesAsync();
      }
      return Commentary.Id;
    }
  }
}
