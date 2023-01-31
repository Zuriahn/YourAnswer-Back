using BLL.ViewModel.Commentary;
using BLL.ViewModel.Question;
using BLL.ViewModel.User;

namespace BLL.ViewModel.Answer
{
  public class AnswerVM
  {
    public int id { get; set; }

    public string description { get; set; }

    public string date { get; set; }

    public bool status { get; set; }

    public int userid { get; set; }
    public UserVM user { get; set; }

    public int questionid { get; set; }
    public QuestionVM question { get; set; }

    public List<CommentaryVM> comments { get; set; }
  }
}
