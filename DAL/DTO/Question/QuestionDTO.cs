namespace DAL.DTO.Question
{
  public class QuestionDTO
  {
    public int Id { get; set; }
    public string Title { get; set; }

    public string Description { get; set; }

    public string Image { get; set; }

    public string Date { get; set; }

    public bool Status { get; set; }

    public int UserId { get; set; }

    public int CategoryId { get; set; }

  }
}
