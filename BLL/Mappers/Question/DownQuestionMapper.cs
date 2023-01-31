using DAL.Functions.Question;

namespace BLL.Mappers.Question
{
  public class DownQuestionMapper
  {
    public async Task DownQuestion(int QuestionId)
    {
      await new DownQuestionCS().DownQuestionAsync(QuestionId);
    }
  }
}
