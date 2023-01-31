using DAL.DataBase;
using DAL.DBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Functions.Category
{
  public class AllCategoriesCS
  {
    public async Task<List<CategoryDM>> AllCategoriesAsync()
    {
      using (var context = new DataBaseContext(DataBaseContext.ops.dbOptions))
      {

        return await context.Category.Select(s => new CategoryDM
        {
          Id = s.Id,
          Name = s.Name
        }).ToListAsync();
      }
    }
  }
}
