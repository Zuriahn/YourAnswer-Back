using BLL.Mappers.Answer;
using BLL.ViewModel.Answer;
using Microsoft.AspNetCore.Mvc;

namespace API_YA.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnswerController : ControllerBase
  {
    [HttpPost]
    public async Task<IActionResult> AddAnswer([FromBody]AddAnswerVM AddAnswerVM)
    {
      var response = await new AddAnswerMapper().AddAnswer(AddAnswerVM);
      if (response == null)
      {
        return BadRequest();
      }
      return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateAnswer([FromBody]UpdAnswerVM UpdAnswerVM)
    {
      await new UpdateAnswerMapper().UpdateAnswer(UpdAnswerVM);
      return Ok();
    }

    [HttpDelete("{AnswerId}")]
    public async Task<IActionResult> DownAnswer([FromRoute]int AnswerId)
    {
      await new DownAnswerMapper().DownAnswer(AnswerId);
      return Ok();
    }

  }
}
