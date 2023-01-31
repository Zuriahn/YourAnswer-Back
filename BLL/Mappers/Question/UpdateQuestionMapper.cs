using BLL.ViewModel.Question;
using DAL.Functions.Question;
using DAL.DTO.Question;

namespace BLL.Mappers.Question
{
  public class UpdateQuestionMapper
  {
    public async Task UpdateQuestion(UpdQuestionVM UpdQuestionVM)
    {
      await new UpdateQuestionCS().UpdateQuestionAsync(new UpdQuestionDTO
      {
        Id = UpdQuestionVM.id,
        Description = UpdQuestionVM.description,
        Image = UpdQuestionVM.image,
        CategoryId = UpdQuestionVM.categoryid
      });
    }
  }
}
