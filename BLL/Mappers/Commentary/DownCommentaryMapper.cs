using DAL.Functions.Commentary;

namespace BLL.Mappers.Commentary
{
  public class DownCommentaryMapper
  {
    public async Task DownCommentary(int CommentaryId)
    {
      await new DownCommentaryCS().DownCommentaryAsync(CommentaryId);
    }
  }
}
