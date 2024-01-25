using backend.Models.Base;

namespace backend.Models;

public class Comanda : BaseEntity
{
    public bool? Favorita { get; set; }
    public ICollection<ComandaProdusRelatie>? Produse { get; set; }
    
    public Guid UtilizatorId { get; set; }
    public Utilizator Utilizator { get; set; }
}