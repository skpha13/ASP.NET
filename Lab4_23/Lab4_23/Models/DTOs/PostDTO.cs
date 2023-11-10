namespace Lab4_23.Models.DTOs;

public class PostDTO
{
    public string Title { get; set; }
    public string Description { get; set; }
    public List<ReviewDTO> Reviews { get; set; }
}