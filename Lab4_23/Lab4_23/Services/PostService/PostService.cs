using AutoMapper;
using Lab4_23.Models;
using Lab4_23.Models.DTOs;
using Lab4_23.Repositories.PostRepository;
using Microsoft.CodeAnalysis.Elfie.Serialization;

namespace Lab4_23.Services.PostService;

public class PostService: IPostService
{
    private readonly IMapper _mapper;
    private readonly IPostRepository _postRepository;

    public PostService(IPostRepository postRepository, IMapper mapper)
    {
        _postRepository = postRepository;
        _mapper = mapper;
    }
    
    public List<PostDTO> GetAllIncludeReviews()
    { 
        return _postRepository.GetAllIncludeReviews();
    }

    public List<PostDTO> OrderByTitle()
    {
        return _postRepository.OrderByTitle();
    }

    public async Task<List<Post>> GetPostsAsync()
    {
        return await _postRepository.GetAllAsync();
    }
    
    public List<PostReviewsDTO> GetAllWithJoin()
    {
        return _postRepository.GetAllWithJoin();
    }
    
    public async Task CreatePostAsync(PostDTO p)
    {
        await _postRepository.CreateAsync(_mapper.Map<Post>(p));
        await _postRepository.SaveAsync();
    }
}