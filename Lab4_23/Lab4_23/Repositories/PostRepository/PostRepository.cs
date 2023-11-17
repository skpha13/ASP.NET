using Lab4_23.Data;
using Lab4_23.Models;
using Lab4_23.Models.DTOs;
using Lab4_23.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Lab4_23.Repositories.PostRepository;

public class PostRepository: GenericRepository<Post>, IPostRepository
{
    public PostRepository(Lab4Context lab4Context): base(lab4Context) { }

    public List<PostDTO> OrderByTitle()
    {
        List<PostDTO> posts = GetAllIncludeReviews().OrderBy(x => x.Title).ToList();
   
        return posts;
    }

    public List<PostDTO> GetAllIncludeReviews()
    {
        // TODO: DTO with constructor of class
        return _table.Include(x => x.Reviews)
            .Select(post => new PostDTO
            {
                Title = post.Title,
                Description = post.Description,
                Reviews = post.Reviews.Select(review => new ReviewDTO(review)).ToList()
            })
            .ToList();
    }
    
    public List<PostReviewsDTO> GetAllWithJoin()
    {
        return  _lab4Context.Posts.Join(
            _lab4Context.Reviews, 
            post => post.Id, 
            review => review.PostId,
            (post, review) => new PostReviewsDTO(post, review)
        ).ToList();
    }
}