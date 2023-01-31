using BLL.ViewModel.Answer;
using DAL.DTO.Answer;
using DAL.Functions.Answer;

namespace BLL.Mappers.Answer
{
  public class UpdateAnswerMapper
  {
    public async Task UpdateAnswer(UpdAnswerVM UpdAnswerVM)
    {
      await new UpdateAnswerCS().UpdateAnswerAsync(new AnswerDTO
      {
        Id= UpdAnswerVM.id,
        Description = UpdAnswerVM.description
      });

    }
  }
}
