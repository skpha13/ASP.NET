using Lab4_23.Data;
using Lab4_23.Models;
using Lab4_23.Models.DTOs;
using Lab4_23.Repositories.PostRepository;
using Lab4_23.Services.PostService;
using Microsoft.AspNetCore.Mvc;

namespace Lab4_23.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly Lab4Context _lab4Context;
        private readonly IPostService _postService;

        // TODO: how to make this dependency injection
        public PostController(Lab4Context lab4Context)
        {
            _lab4Context = lab4Context;
            // TODO: ask here if its ok 
            _postService = new PostService(new PostRepository(lab4Context));
        }

        [HttpGet("Posts")]
        public async Task<List<Post>> GetPostsAsync()
        {
            return await _postService.GetPostsAsync();
        }

        [HttpGet("PostsIncludeReviews")]
        public List<PostDTO> GetPostsIncludeReviews()
        {
            return  _postService.GetAllIncludeReviews();
        }
        
        [HttpGet("PostsWithJoin")]
        public List<PostReviewsDTO> GetAllWithJoin()
        {
            return _postService.GetAllWithJoin();
        }
        
        [HttpPost("create")]
        public async Task CreatePostAsync(Post p)
        {
            await _postService.CreatePostAsync(p);
        }

        [HttpGet("orderedByTitle")]
        public List<PostDTO> OrderByTitle()
        {
            return _postService.OrderByTitle();
        }
    }
}
