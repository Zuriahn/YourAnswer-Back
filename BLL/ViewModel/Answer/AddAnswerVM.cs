using BLL.ViewModel.Question;
using BLL.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ViewModel.Answer
{
  public class AddAnswerVM
  {
    public int id { get; set; }

    public string description { get; set; }

    public bool status { get; set; }

    public int userid { get; set; }

    public int questionid { get; set; }
  }
}
