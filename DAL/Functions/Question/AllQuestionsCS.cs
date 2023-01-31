using DAL.DataBase;
using DAL.DBModels;
using Microsoft.EntityFrameworkCore;

namespace DAL.Functions.Question
{
  public class AllQuestionsCS
  {
    public async Task<List<QuestionDM>> AllQuestionsAsync()
    {
      using (var context = new DataBaseContext(DataBaseContext.ops.dbOptions))
      {

        return await context.Question.Select(s => new QuestionDM
        {
          Id = s.Id,
          Title = s.Title,
          Description = s.Description,
          Image = s.Image,
          Date= s.Date,
          Status = s.Status,
          UserId = s.UserId,
          User = new UserDM
          {
            Username = s.User.Username,
            Email = s.User.Email
          },
          CategoryId = s.CategoryId,
          Category = new CategoryDM
          {
            Name = s.Category.Name
          }
        }).ToListAsync();

      }
    }
  }
}
