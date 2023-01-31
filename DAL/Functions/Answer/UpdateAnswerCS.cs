using DAL.DataBase;
using DAL.DBModels;
using DAL.DTO.Answer;
using Microsoft.IdentityModel.Tokens;

namespace DAL.Functions.Answer
{
  public class UpdateAnswerCS
  {
    public async Task UpdateAnswerAsync(AnswerDTO AnswerDTO)
    {
      var Answer = new AnswerDM
      {
        Id = AnswerDTO.Id,
        Description = AnswerDTO.Description,
      };

      using (var context = new DataBaseContext(DataBaseContext.ops.dbOptions))
      {
        context.Answer.Attach(Answer);
        context.Entry(Answer).Property(d => d.Description).IsModified = AnswerDTO.Description.IsNullOrEmpty() ? false : true;
        await context.SaveChangesAsync();
      }
    }
  }
}
