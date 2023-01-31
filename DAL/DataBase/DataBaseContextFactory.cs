using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataBase
{
  public class DataBaseContextFactory : IDesignTimeDbContextFactory<DataBaseContext>
  {
    public DataBaseContext CreateDbContext(string[] arg)
    {
      AppConfiguration appConfig = new AppConfiguration();
      var opsBuilder = new DbContextOptionsBuilder<DataBaseContext>();
      opsBuilder.UseSqlServer(appConfig.sqlConnectionStr);
      return new DataBaseContext(opsBuilder.Options);
    }
  }
}
