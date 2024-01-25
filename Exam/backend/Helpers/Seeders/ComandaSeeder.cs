using backend.Data;
using backend.Models;

namespace backend.Helpers.Seeders;

public class ComandaSeeder
{
    private readonly DatabaseContext _dbContext;

    public ComandaSeeder(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void SeedInitialComenzi()
    {
        if (!_dbContext.Comenzi.Any())
        {
            var comenzi = new List<Comanda>
            {
                new Comanda()
                {
                    Id = new Guid("b8d3a2b6-cbab-4527-9594-7945befb5182"),
                    DateCreated = DateTime.Now,
                    LastModified = DateTime.Now,
                    Favorita = false,
                    UtilizatorId =  new Guid("07b44755-bf21-45fd-9d6a-a7c1ee117d81")
                },
                new Comanda()
                {
                    Id = new Guid("c37b2add-19b7-4902-9602-8cce2dc70823"),
                    DateCreated = DateTime.Now,
                    LastModified = DateTime.Now,
                    Favorita = true,
                    UtilizatorId =  new Guid("f6bee605-d7ac-4ae9-b3c7-822c855e6b7a")
                },
            };
            
            _dbContext.Comenzi.AddRange(comenzi);
            _dbContext.SaveChanges();
        }
    }
}