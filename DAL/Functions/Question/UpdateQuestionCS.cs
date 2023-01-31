using DAL.DataBase;
using DAL.DBModels;
using DAL.DTO.Question;
using Microsoft.IdentityModel.Tokens;

namespace DAL.Functions.Question
{
  public class UpdateQuestionCS
  {
    public async Task UpdateQuestionAsync(UpdQuestionDTO UpdQuestionDTO)
    {
      var Question = new QuestionDM
      {
        Id = UpdQuestionDTO.Id,
        Description = UpdQuestionDTO.Description,
        Image = UpdQuestionDTO.Image,
        CategoryId= UpdQuestionDTO.CategoryId,
      };

      using (var context = new DataBaseContext(DataBaseContext.ops.dbOptions))
      {
        context.Question.Attach(Question);
        context.Entry(Question).Property(d => d.Description).IsModified = UpdQuestionDTO.Description.IsNullOrEmpty() ? false : true;
        context.Entry(Question).Property(i => i.Image).IsModified = UpdQuestionDTO.Image.IsNullOrEmpty() ? false : true;
        context.Entry(Question).Property(c => c.CategoryId).IsModified = UpdQuestionDTO.CategoryId.ToString().IsNullOrEmpty() ? false : true;
        await context.SaveChangesAsync();
      }

    }
  }
}
