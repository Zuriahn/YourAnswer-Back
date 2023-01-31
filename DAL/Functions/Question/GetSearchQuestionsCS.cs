using DAL.DataBase;
using DAL.DBModels;
using Microsoft.EntityFrameworkCore;

namespace DAL.Functions.Question
{
  public class GetSearchQuestionsCS
  {
    public async Task<List<QuestionDM>> GetSearchQuestionsAsync(string Title, int CategoryId)
    {
      using (var context = new DataBaseContext(DataBaseContext.ops.dbOptions))
      {
        //EF.Functions.Like(q.Title,'%'+Title+'%')
        return await context.Question.Where(q => q.Title.Contains(Title) || q.CategoryId == CategoryId).Select(s => new QuestionDM
        {
          Id = s.Id,
          Title = s.Title,
          Description = s.Description,
          Image = s.Image,
          Date = s.Date,
          Status = s.Status,
          UserId = s.UserId,
          User = new UserDM
          {
            Username = s.User.Username
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
