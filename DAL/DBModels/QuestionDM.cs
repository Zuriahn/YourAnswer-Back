using System.ComponentModel.DataAnnotations;

namespace DAL.DBModels
{
  public class QuestionDM
  {
    [Key]
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public string Image { get; set; }

    public string Date { get; set; }

    public bool Status { get; set; }

    //RELACIONES
    public int UserId { get; set; }
    public UserDM User { get; set; }

    public int CategoryId { get; set; }
    public CategoryDM Category { get; set; }

    public List<AnswerDM> Answers { get; set; }

  }
}
