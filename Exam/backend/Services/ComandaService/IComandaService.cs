using backend.Models.DTOs.ComandaDTOs;

namespace backend.Services.ComandaService;

public interface IComandaService
{
    Task<List<ComandaDTO>> GetAll();
    Task Create(CreateComandaDTO test);
    void Delete(Guid id);
    Task Update(UpdateComandaDTO test);
}