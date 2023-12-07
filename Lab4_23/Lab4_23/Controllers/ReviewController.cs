using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab4_23.Data;
using Lab4_23.Models;
using Lab4_23.Repositories.ReviewRepository;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab4_23.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class ReviewController : ControllerBase
    {
        private readonly Lab4Context _lab4Context;
        private readonly IReviewRepository _reviewRepository;

        public ReviewController(Lab4Context lab4Context)
        {
            _lab4Context = lab4Context;
            _reviewRepository = new ReviewRepository(lab4Context);
        }
        
        [HttpGet("Review")]
        public async Task<List<Review>> GetPosts()
        {
            return await _reviewRepository.GetAllAsync();
        }

        // TODO: make a DTO to create object without all attributes
        [HttpPost("create")]
        public async Task CreatePost(Review r)
        {
            await _reviewRepository.CreateAsync(r);
            await _reviewRepository.SaveAsync();
        }
    }
}
