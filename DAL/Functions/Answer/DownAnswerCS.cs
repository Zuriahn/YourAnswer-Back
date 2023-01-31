using DAL.DataBase;
using DAL.DBModels;

namespace DAL.Functions.Answer
{
  public class DownAnswerCS
  {
    public async Task DownAnswerAsync(int AnswerId)
    {
      var Answer = new AnswerDM
      {
        Id = AnswerId,
        Status = false
      };

      using (var context = new DataBaseContext(DataBaseContext.ops.dbOptions))
      {
        context.Answer.Attach(Answer);
        context.Entry(Answer).Property(s => s.Status).IsModified = true;
        await context.SaveChangesAsync();
      }
    }
  }
}
