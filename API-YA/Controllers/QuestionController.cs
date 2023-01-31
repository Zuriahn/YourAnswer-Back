using Microsoft.AspNetCore.Mvc;
using BLL.ViewModel.Question;
using BLL.Mappers.Question;

namespace API_YA.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class QuestionController : ControllerBase
  {
    [HttpPost]
    public async Task<IActionResult> AddQuestion([FromBody]AddQuestionVM QuestionVM)
    {
      var response = await new AddQuestionMapper().AddQuestion(QuestionVM);
      if (response == null)
      {
        return BadRequest();
      }
      return Ok(response);
    }

    [HttpGet("{QuestionId}")]
    public async Task<IActionResult> GetQuestion([FromRoute]int QuestionId)
    {
      var response = await new GetQuestionMapper().GetQuestion(QuestionId);
      if (response == null)
      {
        return NotFound();
      }
      return Ok(response);
    }

    [HttpGet("Search/{Title}/{CategoryId}")]
    public async Task<List<QuestionVM>> GetSearchQuestions([FromRoute]string Title, [FromRoute]int CategoryId)
    {
      return await new GetSearchQuestionsMapper().GetSearchQuestions(Title, CategoryId);
    }

    [HttpGet()]
    public async Task<List<QuestionVM>> AllQuestions()
    {
      return await new AllQuestionsMapper().AllQuestions();
    }

    [HttpPut()]
    public async Task<IActionResult> UpdateQuestion([FromBody]UpdQuestionVM UpdQuestionVM)
    {
      await new UpdateQuestionMapper().UpdateQuestion(UpdQuestionVM);
      return Ok();
    }

    [HttpDelete("{QuestionId}")]
    public async Task<IActionResult> DownQuestion([FromRoute]int QuestionId)
    {
      await new DownQuestionMapper().DownQuestion(QuestionId);
      return Ok();
    }

  }
}
