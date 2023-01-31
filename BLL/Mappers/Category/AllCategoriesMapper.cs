using BLL.ViewModel.Category;
using DAL.Functions.Category;

namespace BLL.Mappers.Category
{
  public class AllCategoriesMapper
  {
    public async Task<List<CategoryVM>> AllCategories()
    {
      var CategoriesDM = await new AllCategoriesCS().AllCategoriesAsync();
      var CategoriesVM = new List<CategoryVM>();

      foreach(var category in CategoriesDM)
      {
        var tempCategory = new CategoryVM
        {
          id = category.Id,
          name = category.Name,
        };
        CategoriesVM.Add(tempCategory);
      }

      return CategoriesVM;
    }
  }
}
