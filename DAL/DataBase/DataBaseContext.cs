using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DBModels;
using Microsoft.EntityFrameworkCore;

namespace DAL.DataBase
{
  public class DataBaseContext : DbContext
  {
    public class optionsBuild
    {
      public optionsBuild()
      {
        settings = new AppConfiguration();
        opsBuilder = new DbContextOptionsBuilder<DataBaseContext>();
        opsBuilder.UseSqlServer(settings.sqlConnectionStr);
        dbOptions = opsBuilder.Options;
      }
      public DbContextOptionsBuilder<DataBaseContext> opsBuilder { get; set; }
      public DbContextOptions<DataBaseContext> dbOptions { get; set; }

      private AppConfiguration settings { get; set; }
    }

    public static optionsBuild ops = new optionsBuild();

    public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

    //private DataBaseContext() { }

    //private static DataBaseContext context;

    //public static DataBaseContext getInstance()
    //{
    //  if (context == null)
    //  {
    //    context = new DataBaseContext();
    //  }
    //  return context;
    //}

    public DbSet<UserDM> User { get; set; }

    public DbSet<QuestionDM> Question { get; set; }

    public DbSet<CategoryDM> Category { get; set; }  

    public DbSet<AnswerDM> Answer { get; set; }

    public DbSet<CommentaryDM> Commentary { get; set; }

  }
}
