using backend.Data;
using backend.Models;
using backend.Repositories.GenericRepository;

namespace backend.Repositories.ProdusRepository;

public class ProdusRepository : GenericRepository<Produs>, IProdusRepository
{
    public ProdusRepository(DatabaseContext dbContext) : base(dbContext) {}
}