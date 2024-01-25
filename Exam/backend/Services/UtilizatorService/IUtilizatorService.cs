using backend.Models;
using backend.Models.DTOs.UserDTOs;

namespace backend.Services.TestService;

public interface IUtilizatorService
{
    Task<List<UserDTO>> GetAll();
    Task Create(CreateUserDTO test);
    Task Delete(Guid id);
    Task Update(UpdateUserDTO test);
}