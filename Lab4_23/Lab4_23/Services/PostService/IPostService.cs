using Lab4_23.Models;
using Lab4_23.Models.DTOs;

namespace Lab4_23.Services.PostService;

public interface IPostService
{
    public List<PostDTO> GetAllIncludeReviews();
    public List<PostDTO> OrderByTitle();
    public Task<List<Post>> GetPostsAsync();
    public List<PostReviewsDTO> GetAllWithJoin();
    public Task CreatePostAsync(Post p);

}