using BLL.ViewModel.Question;

namespace BLL.ViewModel.Category
{
    public class CategoryVM
    {
        public int id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public List<QuestionVM> questions { get; set; }
    }
}
