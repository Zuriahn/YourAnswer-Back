using DAL.DataBase;
using DAL.DBModels;
using DAL.DTO.Commentary;
using Microsoft.IdentityModel.Tokens;

namespace DAL.Functions.Commentary
{
  public class UpdateCommentaryCS
  {
    public async Task UpdateCommentaryAsync(CommentaryDTO CommentaryDTO)
    {
      var Commentary = new CommentaryDM
      {
        Id = CommentaryDTO.Id,
        Description = CommentaryDTO.Description
      };
      using (var context = new DataBaseContext(DataBaseContext.ops.dbOptions))
      {
        context.Commentary.Attach(Commentary);
        context.Entry(Commentary).Property(d => d.Description).IsModified = CommentaryDTO.Description.IsNullOrEmpty() ? false : true;
        await context.SaveChangesAsync();
      }
    }
  }
}
