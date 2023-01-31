namespace DAL.DTO.Answer
{
  public class AnswerDTO
  {
    public int Id { get; set; }

    public string Description { get; set; }

    public string Date { get; set; }

    public bool Status { get; set; }

    public int UserId { get; set; }

    public int QuestionId { get; set; }

  }
}
