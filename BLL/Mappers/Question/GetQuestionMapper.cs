using BLL.ViewModel.Answer;
using BLL.ViewModel.Category;
using BLL.ViewModel.Commentary;
using BLL.ViewModel.Question;
using BLL.ViewModel.User;
using DAL.Functions.Question;

namespace BLL.Mappers.Question
{
  public class GetQuestionMapper
  {
    public async Task<QuestionVM> GetQuestion(int QuestionId)
    {
      var QuestionDM = await new GetQuestionCS().GetQuestionAsync(QuestionId);

      if (QuestionDM == null)
      {
        return null;
      }

      var Question = new QuestionVM
      {
        id = QuestionDM.Id,
        title = QuestionDM.Title,
        description = QuestionDM.Description,
        image = QuestionDM.Image,
        date = QuestionDM.Date,
        status = QuestionDM.Status,
        userid = QuestionDM.UserId,
        user = new UserVM
        {
          username = QuestionDM.User.Username,
          image = QuestionDM.User.Image
        },
        categoryid = QuestionDM.CategoryId,
        category = new CategoryVM
        {
          name = QuestionDM.Category.Name
        },
        answers = new List<AnswerVM>()
       };

      foreach (var answer in QuestionDM.Answers) 
      {
        var tempAnswer = new AnswerVM
        {
          id = answer.Id,
          description = answer.Description,
          date = answer.Date,
          status = answer.Status,
          userid = answer.UserId,
          user = new UserVM
          {
            username = answer.User.Username,
            image = answer.User.Image
          },
          comments = new List<CommentaryVM>()
        };
        foreach(var comment in answer.Comments)
        {
          var tempComment = new CommentaryVM
          {
            id = comment.Id,
            description = comment.Description,
            date = comment.Date,
            status = comment.Status,
            userid = comment.UserId,
            user = new UserVM
            {
              username = comment.User.Username
            }
          };
          tempAnswer.comments.Add(tempComment);
        }
        Question.answers.Add(tempAnswer); 
      }

      return Question;
    }
  }
}
