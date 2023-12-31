using Lab4_23.Data;
using Lab4_23.Models;
using Lab4_23.Models.DTOs;
using Lab4_23.Repositories.PostRepository;
using Lab4_23.Services.PostService;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Lab4_23.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
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
        public async Task CreatePostAsync(PostDTO p)
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
