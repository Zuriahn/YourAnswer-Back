using BLL.Mappers.Commentary;
using BLL.ViewModel.Commentary;
using Microsoft.AspNetCore.Mvc;

namespace API_YA.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CommentaryController : ControllerBase
  {
    [HttpPost]
    public async Task<IActionResult> AddCommentary([FromBody]AddCommentaryVM AddCommentaryVM)
    {
      var response = await new AddCommentaryMapper().AddCommentary(AddCommentaryVM);
      if (response == null)
      {
        return BadRequest();
      }
      return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateCommentary([FromBody]UpdCommentaryVM UpdCommentaryVM)
    {
      await new UpdateCommentaryMapper().UpdateCommentary(UpdCommentaryVM);
      return Ok();
    }

    [HttpDelete("{CommentaryId}")]
    public async Task<IActionResult> DownCommentary([FromRoute]int CommentaryId)
    {
      await new DownCommentaryMapper().DownCommentary(CommentaryId);
      return Ok();
    }

  }
}
