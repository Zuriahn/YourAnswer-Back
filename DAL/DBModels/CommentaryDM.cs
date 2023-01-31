using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DBModels
{
  public class CommentaryDM
  {
    [Key]
    public int Id { get; set; }

    [Required]
    public string Description { get; set; }

    public string Date { get; set; }  

    public bool Status { get; set; }

    //Relaciones
    public int UserId { get; set; }
    public UserDM User { get; set; }

    public int AnswerId { get; set; }
    public AnswerDM Answer { get; set; }
  }
}
