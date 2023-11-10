using Lab4_23.Models;
using Lab4_23.Repositories.GenericRepository;

namespace Lab4_23.Repositories.PostRepository;

public interface IPostRepository: IGenericRepository<Post>
{
    List<Post> OrderByTitle(string title);
    List<Post> GetAllIncludeReviews();
}