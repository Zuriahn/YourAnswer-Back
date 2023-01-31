using System.ComponentModel.DataAnnotations;

namespace DAL.DBModels
{
  public class UserDM
  {
    [Key]
    public int Id { get; set; }

    [Required]
    public string Username { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }

    [Required]
    public string Image { get; set; }

    public string Date { get; set; }

    public bool Status { get; set; }

    //RELACIONES
    public List<QuestionDM> Questions { get; set; }

    public List<AnswerDM> Answers { get; set; }

    public List<CommentaryDM> Comments { get; set; }

  }
}
