using AutoMapper;
using backend.Models;
using backend.Models.DTOs.UserDTOs;
using backend.Repositories.UtilizatorRepository;

namespace backend.Services.TestService;

public class UtilizatorService : IUtilizatorService
{
    private readonly IUtilizatorRepository _utilizatorRepository;
    private readonly IMapper _mapper;

    public UtilizatorService(IUtilizatorRepository utilizatorRepository, IMapper mapper)
    {
        _utilizatorRepository = utilizatorRepository;
        _mapper = mapper;
    }
    
    public async Task<List<UserDTO>> GetAll()
    {
        var users = await _utilizatorRepository.GetAllAsync();
        return _mapper.Map<List<UserDTO>>(users);
    }

    public async Task Create(CreateUserDTO test)
    {
        await _utilizatorRepository.CreateAsync(_mapper.Map<Utilizator>(test));
        await _utilizatorRepository.SaveAsync();
    }

    public void Delete(Guid id)
    {
        _utilizatorRepository.DeleteById(id);
        _utilizatorRepository.SaveAsync();
    }

    public async Task Update(UpdateUserDTO test)
    {
        _utilizatorRepository.Update(_mapper.Map<Utilizator>(test));
        await _utilizatorRepository.SaveAsync();
    }
}