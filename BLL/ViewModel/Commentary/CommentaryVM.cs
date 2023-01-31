using BLL.ViewModel.Answer;
using BLL.ViewModel.User;

namespace BLL.ViewModel.Commentary
{
  public class CommentaryVM
  {
    public int id { get; set; }
    public string description { get; set; }

    public string date { get; set; }  

    public bool status { get; set; }

    public int userid { get; set; }
    public UserVM user { get; set; }

    public int answerid { get; set; }
    public AnswerVM answer { get; set; }

  }
}
