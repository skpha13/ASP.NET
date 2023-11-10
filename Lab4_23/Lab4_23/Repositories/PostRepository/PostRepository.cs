using Lab4_23.Data;
using Lab4_23.Models;
using Lab4_23.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Lab4_23.Repositories.PostRepository;

public class PostRepository: GenericRepository<Post>, IPostRepository
{
    public PostRepository(Lab4Context lab4Context): base(lab4Context) { }

    public List<Post> OrderByTitle(string title)
    {
        return _table.OrderBy(x => x.Title).ToList();
    }

    public List<Post> GetAllIncludeReviews()
    {
        return _table.Include(x => x.Reviews).ToList();
    }
}