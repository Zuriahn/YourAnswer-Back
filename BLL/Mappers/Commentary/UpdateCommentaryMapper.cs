using BLL.ViewModel.Commentary;
using DAL.DTO.Commentary;
using DAL.Functions.Commentary;

namespace BLL.Mappers.Commentary
{
  public class UpdateCommentaryMapper
  {
    public async Task UpdateCommentary(UpdCommentaryVM UpdCommentaryVM)
    {
      await new UpdateCommentaryCS().UpdateCommentaryAsync(new CommentaryDTO
      {
        Id = UpdCommentaryVM.id,
        Description = UpdCommentaryVM.description
      });

    }
  }
}
