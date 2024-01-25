using backend.Data;
using backend.Models;
using backend.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore.Storage;

namespace backend.Repositories.ComandaRepository;

public class ComandaRepository : GenericRepository<Comanda>, IComandaRepository
{
    public ComandaRepository(DatabaseContext dbContext) : base(dbContext) {}
}