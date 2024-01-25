using backend.Data;
using backend.Models;
using backend.Repositories.GenericRepository;

namespace backend.Repositories.ComandaProdusRepository;

public class ComandaProdusRepository : GenericRepository<ComandaProdusRelatie>, IComandaProdusRepository
{
    public ComandaProdusRepository(DatabaseContext dbContext) : base(dbContext) {}
}