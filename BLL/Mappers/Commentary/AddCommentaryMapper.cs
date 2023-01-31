using BLL.ViewModel.Commentary;
using DAL.DTO.Commentary;
using DAL.Functions.Commentary;

namespace BLL.Mappers.Commentary
{
  public class AddCommentaryMapper
  {
    public async Task<int> AddCommentary(AddCommentaryVM AddCommentaryVM)
    {
      return await new AddCommentaryCS().AddCommentaryAsync(new CommentaryDTO
      {
        Description = AddCommentaryVM.description,
        UserId = AddCommentaryVM.userid,
        AnswerId = AddCommentaryVM.answerid
      });

    }
  }
}
