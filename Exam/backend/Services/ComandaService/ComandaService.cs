using AutoMapper;
using backend.Models;
using backend.Models.DTOs.ComandaDTOs;
using backend.Models.DTOs.UserDTOs;
using backend.Repositories.ComandaRepository;

namespace backend.Services.ComandaService;

public class ComandaService : IComandaService
{
    private readonly IComandaRepository _comandaRepository;
    private readonly IMapper _mapper;

    public ComandaService(IComandaRepository comandaRepository, IMapper mapper)
    {
        _comandaRepository = comandaRepository;
        _mapper = mapper;
    }
    
    public async Task<List<ComandaDTO>> GetAll()
    {
        var users = await _comandaRepository.GetAllAsync();
        return _mapper.Map<List<ComandaDTO>>(users);
    }

    public async Task Create(CreateComandaDTO test)
    {
        await _comandaRepository.CreateAsync(_mapper.Map<Comanda>(test));
        await _comandaRepository.SaveAsync();
    }

    public async Task Delete(Guid id)
    {
        _comandaRepository.DeleteById(id);
        await _comandaRepository.SaveAsync();
    }

    public async Task Update(UpdateComandaDTO test)
    {
        _comandaRepository.Update(_mapper.Map<Comanda>(test));
        await _comandaRepository.SaveAsync();
    }
}