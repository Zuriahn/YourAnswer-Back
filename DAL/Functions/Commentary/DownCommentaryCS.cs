using DAL.DataBase;
using DAL.DBModels;

namespace DAL.Functions.Commentary
{
  public class DownCommentaryCS
  {
    public async Task DownCommentaryAsync(int CommentaryId)
    {
      var Commentary = new CommentaryDM
      {
        Id = CommentaryId,
        Status = false
      };

      using (var context = new DataBaseContext(DataBaseContext.ops.dbOptions))
      {
        context.Commentary.Attach(Commentary);
        context.Entry(Commentary).Property(s => s.Status).IsModified = true;
        await context.SaveChangesAsync();
      }
    }
  }
}
