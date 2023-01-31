using DAL.DataBase;
using DAL.DBModels;
using DAL.DTO.Question;

namespace DAL.Functions.Question
{
  public class DownQuestionCS
  {
    public async Task DownQuestionAsync(int QuestionId)
    {
      var Question = new QuestionDM
      {
        Id = QuestionId,
        Status = false
      };

      using (var context = new DataBaseContext(DataBaseContext.ops.dbOptions))
      {
        context.Question.Attach(Question);
        context.Entry(Question).Property(s => s.Status).IsModified = true;
        await context.SaveChangesAsync();
      }
    }
  }
}
