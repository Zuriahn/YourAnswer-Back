using BLL.ViewModel.Question;
using BLL.ViewModel.User;
using BLL.ViewModel.Category;
using DAL.Functions.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DBModels;
using BLL.ViewModel.Answer;

namespace BLL.Mappers.User
{
  public class GetUserMapper
  {
    public async Task<UserVM> GetUser(int UserId)
    {
      var UserDM = await new GetUserCS().GetUserAsync(UserId);

      if(UserDM == null)
      {
        return null;
      }

      var UserVM = new UserVM
      {
        username = UserDM.Username,
        name = UserDM.Name,
        email = UserDM.Email,
        image = UserDM.Image,
        date = UserDM.Date,
        status = UserDM.Status,
        questions = new List<QuestionVM>(),
        answers = new List<AnswerVM>()
      };

      foreach (var Question in UserDM.Questions)
      {
        var tempQuestion = new QuestionVM
        {
          id = Question.Id,
          title = Question.Title,
          description = Question.Description,
          image = Question.Image,
          date = Question.Date,
          status = Question.Status,
          category = new CategoryVM
          {
            name = Question.Category.Name
          }
        };
        UserVM.questions.Add(tempQuestion);
      }

      foreach(var Answer in UserDM.Answers)
      {
        var tempAnswer = new AnswerVM
        {
          id = Answer.Id,
          description = Answer.Description,
          date = Answer.Date,
          status = Answer.Status,
          questionid = Answer.QuestionId,
          question = new QuestionVM
          {
            title = Answer.Question.Title,
            image = Answer.Question.Image
          }
        };
        UserVM.answers.Add(tempAnswer);
      }

      return UserVM;
    }
  }
}
