using BLL.ViewModel.Question;
using BLL.ViewModel.Category;
using DAL.Functions.Question;
using BLL.ViewModel.User;

namespace BLL.Mappers.Question
{
  public class AllQuestionsMapper
  {
    public async Task<List<QuestionVM>> AllQuestions()
    {
      var QuestionsDM = await new AllQuestionsCS().AllQuestionsAsync();
      var QuestionsVM = new List<QuestionVM>();

      foreach (var Quest in QuestionsDM) {

        var tempQuestionVM = new QuestionVM
        {
          id = Quest.Id,
          title = Quest.Title,
          description = Quest.Description,
          image = Quest.Image,
          date= Quest.Date,
          status = Quest.Status,
          userid = Quest.UserId,
          user = new UserVM
          {
            username = Quest.User.Username
          },
          categoryid = Quest.CategoryId,
          category = new CategoryVM
          {
            name = Quest.Category.Name,
          }
        };
        QuestionsVM.Add(tempQuestionVM);
      }

      return QuestionsVM;

    }
  }
}
