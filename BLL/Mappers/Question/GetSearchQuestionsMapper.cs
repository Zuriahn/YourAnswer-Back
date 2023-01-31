using BLL.ViewModel.Category;
using BLL.ViewModel.Question;
using BLL.ViewModel.User;
using DAL.Functions.Question;

namespace BLL.Mappers.Question
{
  public class GetSearchQuestionsMapper
  {
    public async Task<List<QuestionVM>> GetSearchQuestions(string Title, int CategoryId)
    {
      var QuestionsDM = await new GetSearchQuestionsCS().GetSearchQuestionsAsync(Title, CategoryId);
      if (QuestionsDM == null)
      {
        return null;
      }
      var QuestionsVM = new List<QuestionVM>();

      foreach (var Quest in QuestionsDM)
      {

        var tempQuestionVM = new QuestionVM
        {
          id = Quest.Id,
          title = Quest.Title,
          description = Quest.Description,
          image = Quest.Image,
          date = Quest.Date,
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
