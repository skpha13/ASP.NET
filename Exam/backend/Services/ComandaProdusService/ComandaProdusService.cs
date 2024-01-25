using AutoMapper;
using backend.Models;
using backend.Models.DTOs.RelatieDTOs;
using backend.Repositories.ComandaProdusRepository;

namespace backend.Services.ComandaProdusService;

public class ComandaProdusService : IComandaProdusService
{
    private readonly IComandaProdusRepository _comandaProdusRepository;
    private readonly IMapper _mapper;

    public ComandaProdusService(IComandaProdusRepository comandaProdusRepository, IMapper mapper)
    {
        _comandaProdusRepository = comandaProdusRepository;
        _mapper = mapper;
    }

    public async Task Create(CreateRelatieDTO test)
    {
        await _comandaProdusRepository.CreateAsync(_mapper.Map<ComandaProdusRelatie>(test));
        await _comandaProdusRepository.SaveAsync();
    }

    public void Delete(Guid id)
    {
        _comandaProdusRepository.DeleteById(id);
        _comandaProdusRepository.SaveAsync();
    }
}