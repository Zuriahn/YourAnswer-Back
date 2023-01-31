using BLL.ViewModel.Answer;
using BLL.ViewModel.Question;

namespace BLL.ViewModel.User
{
  public class UserVM
    {
        public int id { get; set; }

        public string username { get; set; }

        public string name { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public string image { get; set; }

        public string date { get; set; }

        public bool status { get; set; }

        public List<QuestionVM> questions { get; set; }

        public List<AnswerVM> answers { get; set; }

  }
}
