namespace Lab4_23.Models.DTOs;

public class PostReviewsDTO
{
    public PostReviewsDTO(Post p, Review r)
    {
        Title = p.Title;
        Description = p.Description;
        Text = r.Text;
        NumberStars = r.NumberStars;
    }
    
    // public Post Post { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    // public Review Review { get; set; }
    public string Text { get; set; }
    public int NumberStars { get; set; }
}