using backend.Models;
using backend.Models.DTOs.UserDTOs;

namespace backend.Helpers;

public class MapperProfile : AutoMapper.Profile
{
    public MapperProfile()
    {
        CreateMap<CreateUserDTO, Utilizator>()
            .ForMember(u => u.Id, 
                opt => opt.MapFrom(src => new Guid()))
            .ForMember(c => c.LastModified, opt =>
                opt.MapFrom(src => DateTime.Now))
            .ForMember(c => c.DateCreated, opt =>
                opt.MapFrom(src => DateTime.Now));

        CreateMap<Utilizator, UserDTO>();
        CreateMap<UpdateUserDTO, Utilizator>()
            .ForMember(c => c.LastModified, opt =>
                opt.MapFrom(src => DateTime.Now));
        
    }
}