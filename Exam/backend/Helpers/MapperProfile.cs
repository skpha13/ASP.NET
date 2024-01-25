using backend.Models;
using backend.Models.DTOs.ComandaDTOs;
using backend.Models.DTOs.ProdusDTOs;
using backend.Models.DTOs.RelatieDTOs;
using backend.Models.DTOs.UserDTOs;

namespace backend.Helpers;

public class MapperProfile : AutoMapper.Profile
{
    public MapperProfile()
    {
        CreateMap<CreateUserDTO, Utilizator>()
            .ForMember(c => c.LastModified, opt =>
                opt.MapFrom(src => DateTime.Now))
            .ForMember(c => c.DateCreated, opt =>
                opt.MapFrom(src => DateTime.Now));

        CreateMap<Utilizator, UserDTO>();
        CreateMap<UpdateUserDTO, Utilizator>()
            .ForMember(c => c.LastModified, opt =>
                opt.MapFrom(src => DateTime.Now));
        
        
        
        CreateMap<CreateComandaDTO, Comanda>()
            .ForMember(c => c.LastModified, opt =>
                opt.MapFrom(src => DateTime.Now))
            .ForMember(c => c.DateCreated, opt =>
                opt.MapFrom(src => DateTime.Now));

        CreateMap<Comanda, ComandaDTO>();
        CreateMap<UpdateComandaDTO, Comanda>()
            .ForMember(c => c.LastModified, opt =>
                opt.MapFrom(src => DateTime.Now));
        
        
        
        CreateMap<CreateProdusDTO, Produs>()
            .ForMember(c => c.LastModified, opt =>
                opt.MapFrom(src => DateTime.Now))
            .ForMember(c => c.DateCreated, opt =>
                opt.MapFrom(src => DateTime.Now));

        CreateMap<Produs, ProdusDTO>();
        CreateMap<UpdateProdusDTO, Produs>()
            .ForMember(c => c.LastModified, opt =>
                opt.MapFrom(src => DateTime.Now));

        CreateMap<CreateRelatieDTO, ComandaProdusRelatie>()
            .ForMember(c => c.LastModified, opt =>
                opt.MapFrom(src => DateTime.Now))
            .ForMember(c => c.DateCreated, opt =>
                opt.MapFrom(src => DateTime.Now));
    }
}