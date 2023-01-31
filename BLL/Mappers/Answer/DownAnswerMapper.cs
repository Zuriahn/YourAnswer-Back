using DAL.Functions.Answer;

namespace BLL.Mappers.Answer
{
  public class DownAnswerMapper
  {
    public async Task DownAnswer(int AnswerId)
    {
      await new DownAnswerCS().DownAnswerAsync(AnswerId);
    }
  }
}
