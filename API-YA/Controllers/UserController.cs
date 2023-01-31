using BLL.Functions.User;
using BLL.Mappers.User;
using BLL.ViewModel.User;
using Microsoft.AspNetCore.Mvc;

namespace API_YA.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UserController : ControllerBase
  {

    [HttpPost("SignUp")]
    public async Task<IActionResult> SignUpUser([FromBody]SignUpVM SignUpVM)
    {
      var response = await new SignUpUserMapper().SignUpUser(SignUpVM);
      if (response == null)
      {
        return BadRequest();
      }
      return Ok(response);
    }

    [HttpPost("SignIn")]
    public async Task<IActionResult> SignInUser([FromBody]SignInVM SignInVM)
    {
      var response = await new SignInUserMapper().SignInUser(SignInVM);
      if(response == null)
      {
        return NotFound();
      }
       return Ok(response);
    }

    [HttpGet("{UserId}")]
    public async Task<IActionResult> GetUser([FromRoute]int UserId)
    {
      var response = await new GetUserMapper().GetUser(UserId);
      if (response == null)
      {
        return NotFound();
      }
      return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateUser([FromBody]UpdUserVM UserUpdVM)
    {
      await new UpdateUserMapper().UpdateUser(UserUpdVM);
      return Ok();
    }

    [HttpPut("image/{UserId}")]
    public async Task<IActionResult> UpdateUserImage([FromBody] string Img,[FromRoute]int UserId)
    {
      await new UpdateUserImgMapper().UpdateUserImg(Img, UserId);
      return Ok();
    }

    [HttpPut("Password/{UserId}")]
    public async Task<IActionResult> UpdateUserPassword([FromBody] string Password,[FromRoute]int UserId)
    {
      await new UpdateUserPassMapper().UpdateUserPass(Password, UserId);
      return Ok();
    }

    [HttpPut("Down")]
    public async Task<IActionResult> DownUser([FromBody] int UserId)
    {
      await new DownUserMapper().DownUser(UserId);
      return Ok();
    }

  }
}
