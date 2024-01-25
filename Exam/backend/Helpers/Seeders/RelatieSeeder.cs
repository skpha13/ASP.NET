using backend.Data;
using backend.Models;

namespace backend.Helpers.Seeders;

public class RelatieSeeder
{
    private readonly DatabaseContext _dbContext;

    public RelatieSeeder(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void SeedInitialRelatii()
    {
        if (!_dbContext.ComandaProdusRelatii.Any())
        {
            var relatii = new List<ComandaProdusRelatie>
            {
                new ComandaProdusRelatie()
                {
                    Id = new Guid("c4a0ba6e-462e-47c8-b63d-f03d093ce472"),
                    DateCreated = DateTime.Now,
                    LastModified = DateTime.Now,
                    ComandaId = new Guid("b8d3a2b6-cbab-4527-9594-7945befb5182")
                },
                new ComandaProdusRelatie()
                {
                    Id = new Guid("ffbb346d-b382-4f03-887d-dd7695c93a05"),
                    DateCreated = DateTime.Now,
                    LastModified = DateTime.Now,
                    ComandaId = new Guid("c37b2add-19b7-4902-9602-8cce2dc70823"),
                    ProdusId = new Guid("c4a0ba6e-462e-47c8-b63d-f03d093ce472")
                },
                new ComandaProdusRelatie()
                {
                    Id = new Guid("2411c62b-c90b-4f3a-a1ac-c93df6d64285"),
                    DateCreated = DateTime.Now,
                    LastModified = DateTime.Now,
                    ComandaId = new Guid("c37b2add-19b7-4902-9602-8cce2dc70823"),
                    ProdusId = new Guid("ff90c0ba-c340-4177-9a62-9d8015343c68")
                }
            };
            
            _dbContext.ComandaProdusRelatii.AddRange(relatii);
            _dbContext.SaveChanges();
        }
    }
}