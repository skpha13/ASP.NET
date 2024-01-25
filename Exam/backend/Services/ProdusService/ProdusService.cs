using AutoMapper;
using backend.Models;
using backend.Models.DTOs.ComandaDTOs;
using backend.Models.DTOs.ProdusDTOs;
using backend.Models.DTOs.UserDTOs;
using backend.Repositories.ComandaRepository;
using backend.Repositories.ProdusRepository;
using backend.Services.ProdusService;

namespace backend.Services.ComandaService;

public class ProdusService : IProdusService
{
    private readonly IProdusRepository _produsRepository;
    private readonly IMapper _mapper;

    public ProdusService(IProdusRepository produsRepository, IMapper mapper)
    {
        _produsRepository = produsRepository;
        _mapper = mapper;
    }
    
    public async Task<List<ProdusDTO>> GetAll()
    {
        var users = await _produsRepository.GetAllAsync();
        return _mapper.Map<List<ProdusDTO>>(users);
    }

    public async Task Create(CreateProdusDTO test)
    {
        await _produsRepository.CreateAsync(_mapper.Map<Produs>(test));
        await _produsRepository.SaveAsync();
    }

    public void Delete(Guid id)
    {
        _produsRepository.DeleteById(id);
        _produsRepository.SaveAsync();
    }

    public async Task Update(UpdateProdusDTO test)
    {
        _produsRepository.Update(_mapper.Map<Produs>(test));
        await _produsRepository.SaveAsync();
    }
}