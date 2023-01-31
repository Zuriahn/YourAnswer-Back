using DAL.DataBase;
using DAL.DBModels;
using DAL.DTO.Answer;

namespace DAL.Functions.Answer
{
  public class AddAnswerCS
  {
    public async Task<int> AddAnswerAsync(AnswerDTO AnswerDTO)
    {
      var Answer = new AnswerDM
      {
        Description= AnswerDTO.Description,
        UserId = AnswerDTO.UserId,
        QuestionId = AnswerDTO.QuestionId,
        Date = DateTime.Now.ToString(),
        Status = true
      };

      using (var context = new DataBaseContext(DataBaseContext.ops.dbOptions))
      {
        context.Add(Answer);
        await context.SaveChangesAsync();
      }
      return Answer.Id;

    }
  }
}
