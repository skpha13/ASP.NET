using AutoMapper;
using Lab4_23.Models;
using Lab4_23.Models.DTOs;

namespace Lab4_23.Helpers;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Post, PostDTO>();
        CreateMap<PostDTO, Post>();
    }
}