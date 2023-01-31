namespace DAL.DTO.Question
{
  public class UpdQuestionDTO
  {
    public int Id { get; set; }  

    public string Description { get; set; }

    public string Image { get; set; }

    public int CategoryId { get; set; }
  }
}
