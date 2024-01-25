using backend.Data;
using backend.Models;

namespace backend.Helpers.Seeders;

public class UtilizatorSeeder
{
    private readonly DatabaseContext _dbContext;

    public UtilizatorSeeder(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void SeedInitialUsers()
    {
        if (!_dbContext.Utilizatori.Any())
        {
            var utilizatori = new List<Utilizator>
            {
                new Utilizator()
                {
                    Id = new Guid("07b44755-bf21-45fd-9d6a-a7c1ee117d81"),
                    DateCreated = DateTime.Now,
                    LastModified = DateTime.Now,
                    nume = "Andrei"
                },
                new Utilizator()
                {
                    Id = new Guid("f6bee605-d7ac-4ae9-b3c7-822c855e6b7a"),
                    DateCreated = DateTime.Now,
                    LastModified = DateTime.Now,
                    nume = "Marius"
                }
            };
            
            _dbContext.Utilizatori.AddRange(utilizatori);
            _dbContext.SaveChanges();
        }
    }
}