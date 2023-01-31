using BLL.Mappers.Category;
using BLL.ViewModel.Category;
using Microsoft.AspNetCore.Mvc;

namespace API_YA.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CategoryController : ControllerBase
  {
    [HttpGet()]
    public async Task<List<CategoryVM>> AllQuestions()
    {
      return await new AllCategoriesMapper().AllCategories();
    }
  }
}
