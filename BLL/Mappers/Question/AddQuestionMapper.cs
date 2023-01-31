using BLL.ViewModel.Question;
using DAL.DTO.Question;
using DAL.Functions.Question;

namespace BLL.Mappers.Question
{
  public class AddQuestionMapper
  {
    public async Task<int> AddQuestion(AddQuestionVM QuestionVM)
    {
      return await new AddQuestionCS().AddQuestionAsync(new QuestionDTO
      {
        Title = QuestionVM.title,
        Description = QuestionVM.description,
        Image = QuestionVM.image,
        CategoryId = QuestionVM.categoryid,
        UserId = QuestionVM.userid,
      });
    }
  }
}
