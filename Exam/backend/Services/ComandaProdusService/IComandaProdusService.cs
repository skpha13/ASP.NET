using backend.Models.DTOs.ComandaDTOs;
using backend.Models.DTOs.RelatieDTOs;

namespace backend.Services.ComandaProdusService;

public interface IComandaProdusService
{
    Task Create(CreateRelatieDTO test);
    Task Delete(Guid id);
}