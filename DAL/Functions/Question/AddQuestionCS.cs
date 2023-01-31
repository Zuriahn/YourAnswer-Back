using DAL.DataBase;
using DAL.DBModels;
using DAL.DTO.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Functions.Question
{
  public class AddQuestionCS
  {
    public async Task<int> AddQuestionAsync(QuestionDTO QuestionDTO)
    {
      var Question = new QuestionDM
      {
        Title = QuestionDTO.Title,
        Description = QuestionDTO.Description,
        Image = QuestionDTO.Image,
        CategoryId = QuestionDTO.CategoryId,
        UserId = QuestionDTO.UserId,
        Date = DateTime.Now.ToString(),
        Status = true
      };

      using (var context = new DataBaseContext(DataBaseContext.ops.dbOptions))
      {
        context.Add(Question);
        await context.SaveChangesAsync();
      }
      return Question.Id;


    }
  }
}
