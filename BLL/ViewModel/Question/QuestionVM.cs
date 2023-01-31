using BLL.ViewModel.Answer;
using BLL.ViewModel.Category;
using BLL.ViewModel.User;

namespace BLL.ViewModel.Question
{
  public class QuestionVM
  {
    public int id { get; set; }

    public string title { get; set; }

    public string description { get; set; }

    public string image { get; set; }

    public string date { get; set; }

    public bool status { get; set; }

    public int userid { get; set; }
    public UserVM user { get; set; }

    public int categoryid { get; set; }
    public CategoryVM category { get; set; }

    public List<AnswerVM> answers { get; set; }
  }
}
