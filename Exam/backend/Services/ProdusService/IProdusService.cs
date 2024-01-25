using backend.Models.DTOs.ComandaDTOs;
using backend.Models.DTOs.ProdusDTOs;

namespace backend.Services.ProdusService;

public interface IProdusService
{
    Task<List<ProdusDTO>> GetAll();
    Task Create(CreateProdusDTO test);
    void Delete(Guid id);
    Task Update(UpdateProdusDTO test);
}