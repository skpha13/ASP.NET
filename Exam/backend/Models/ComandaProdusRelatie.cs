using backend.Models.Base;

namespace backend.Models;

public class ComandaProdusRelatie : BaseEntity
{
    public Guid ComandaId { get; set; }
    public Comanda Comanda { get; set; }
    
    public Guid? ProdusId { get; set; }
    public Produs? Produs { get; set; }
}