using DAL.DataBase;
using DAL.DBModels;
using Microsoft.EntityFrameworkCore;

namespace DAL.Functions.User
{
  public class GetUserCS
  {
    public async Task<UserDM> GetUserAsync(int UserId)
    {
      using (var context = new DataBaseContext(DataBaseContext.ops.dbOptions))
      {
        return await context.User.Where(u => u.Id == UserId).Select(u => new UserDM
        {
          Username = u.Username,
          Name = u.Name,
          Email = u.Email,
          Image = u.Image,
          Date = u.Date,
          Status = u.Status,
          Questions = context.Question.Where(q => q.UserId == UserId).Select(qs => new QuestionDM
          {
            Id = qs.Id,
            Title = qs.Title,
            Description = qs.Description,
            Image = qs.Image,
            Date = qs.Date,
            Status = qs.Status,
            Category = new CategoryDM
            {
              Name = qs.Category.Name
            }
          }).ToList(),
          Answers = context.Answer.Where(a => a.UserId == UserId).Select(ans => new AnswerDM
          {
            Id = ans.Id,
            Description= ans.Description,
            Date = ans.Date,
            Status= ans.Status,
            QuestionId= ans.QuestionId,
            Question = new QuestionDM
            {
              Title = ans.Question.Title,
              Image = ans.Question.Image
            }
          }).ToList()
        }).FirstOrDefaultAsync();
      }

    }
  }
}
