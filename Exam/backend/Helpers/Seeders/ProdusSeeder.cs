using backend.Data;
using backend.Models;

namespace backend.Helpers.Seeders;

public class ProdusSeeder
{
    private readonly DatabaseContext _dbContext;

    public ProdusSeeder(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void SeedInitialProduse()
    {
        if (!_dbContext.Produse.Any())
        {
            var comenzi = new List<Produs>
            {
                new Produs()
                {
                    Id = new Guid("c4a0ba6e-462e-47c8-b63d-f03d093ce472"),
                    DateCreated = DateTime.Now,
                    LastModified = DateTime.Now,
                    nume = "Microfon",
                    pret = 100
                },
                new Produs()
                {
                    Id = new Guid("2411c62b-c90b-4f3a-a1ac-c93df6d64285"),
                    DateCreated = DateTime.Now,
                    LastModified = DateTime.Now,
                    nume = "Tastatura",
                    pret = 200
                },
                new Produs()
                {
                    Id = new Guid("ff90c0ba-c340-4177-9a62-9d8015343c68"),
                    DateCreated = DateTime.Now,
                    LastModified = DateTime.Now,
                    nume = "Masa",
                    pret = 500
                }
            };
            
            _dbContext.Produse.AddRange(comenzi);
            _dbContext.SaveChanges();
        }
    }
}