using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab4_23.Data;
using Lab4_23.Models;
using Lab4_23.Models.DTOs;
using Lab4_23.Repositories.PostRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab4_23.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly Lab4Context _lab4Context;
        private readonly IPostRepository _postRepository;

        // TODO: how to make this dependency injection
        public PostController(Lab4Context lab4Context)
        {
            _lab4Context = lab4Context;
            _postRepository = new PostRepository(lab4Context);
        }

        [HttpGet("Posts")]
        public async Task<List<Post>> GetPostsAsync()
        {
            return await _postRepository.GetAllAsync();
        }

        [HttpGet("PostsIncludeReviews")]
        public List<PostDTO> GetPostsIncludeReviews()
        {
            return  _postRepository.GetAllIncludeReviews();
        }
        
        [HttpGet("PostsWithJoin")]
        public List<PostReviewsDTO> GetAllWithJoin()
        {
            return  _lab4Context.Posts.Join(
                _lab4Context.Reviews, 
                post => post.Id, 
                review => review.PostId,
                (post, review) => new PostReviewsDTO(post, review)
                ).ToList();
        }
        
        [HttpPost("create")]
        public async Task CreatePostAsync(Post p)
        {
            await _postRepository.CreateAsync(p);
            await _postRepository.SaveAsync();
        }
    }
}
