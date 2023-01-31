using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO.User
{
  public class UpdUserDTO
  {
    public int Id { get; set; }

    public string Name { get; set; }  

    public string Image { get; set; }

    public string Password { get; set; }

  }
}
