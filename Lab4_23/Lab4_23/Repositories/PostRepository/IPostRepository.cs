using Lab4_23.Models;
using Lab4_23.Models.DTOs;
using Lab4_23.Repositories.GenericRepository;

namespace Lab4_23.Repositories.PostRepository;

public interface IPostRepository: IGenericRepository<Post>
{
    List<PostDTO> OrderByTitle();
    List<PostDTO> GetAllIncludeReviews();
    public List<PostReviewsDTO> GetAllWithJoin();
}