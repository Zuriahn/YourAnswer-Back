using DAL.DataBase;
using DAL.DBModels;
using Microsoft.EntityFrameworkCore;

namespace DAL.Functions.Question
{
  public class GetQuestionCS
  {
    public async Task<QuestionDM> GetQuestionAsync(int QuestionId)
    {
      using (var context = new DataBaseContext(DataBaseContext.ops.dbOptions))
      {
        
        return await context.Question.Where(q => q.Id == QuestionId).Select(s => new QuestionDM
        {
          Id = s.Id,
          Title= s.Title,
          Description= s.Description,
          Image = s.Image,
          Date = s.Date,
          Status = s.Status,
          UserId = s.UserId,
          User = new UserDM {
                  Username = s.User.Username,
                  Image = s.User.Image
                             },
          CategoryId = s.CategoryId,
          Category = new CategoryDM { 
                  Name = s.Category.Name
                             },
          Answers = context.Answer.Where(a => a.QuestionId == QuestionId).Select( ans => new AnswerDM
          {
            Id= ans.Id,
            Description= ans.Description,
            Date = ans.Date,
            Status= ans.Status,
            UserId = ans.UserId,
            User = new UserDM {
              Username = ans.User.Username,
              Image = ans.User.Image
            },
            Comments = context.Commentary.Where(c => c.AnswerId == ans.Id).Select(cm => new CommentaryDM
            {
              Id = cm.Id,
              Description = cm.Description,
              Date = cm.Date,
              Status = cm.Status,
              UserId = cm.UserId,
              User = new UserDM
              {
                Username = cm.User.Username
              }
            }
            ).ToList()
          }).ToList()
        }).FirstOrDefaultAsync();

      }
    }
  }
}
