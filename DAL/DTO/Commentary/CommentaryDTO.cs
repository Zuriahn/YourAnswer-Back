namespace DAL.DTO.Commentary
{
  public class CommentaryDTO
  {
    public int Id { get; set; }

    public string Description { get; set; }

    public string Date { get; set; }  

    public bool Status { get; set; }

    public int UserId { get; set; }

    public int AnswerId { get; set; }

  }
}
