using System.ComponentModel.DataAnnotations;

namespace DAL.DBModels
{
  public class AnswerDM
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

    public int QuestionId { get; set; }
    public QuestionDM Question { get; set; }

    public List<CommentaryDM> Comments { get; set; }

  }
}
