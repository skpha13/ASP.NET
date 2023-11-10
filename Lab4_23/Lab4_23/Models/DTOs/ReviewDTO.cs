namespace Lab4_23.Models.DTOs;

public class ReviewDTO
{
    public ReviewDTO(Review r)
    {
        Text = r.Text;
        NumberStars = r.NumberStars;
    }
    
    public string Text { get; set; }
    public int NumberStars { get; set; }
}