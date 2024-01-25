using backend.Models.Base;

namespace backend.Models;

public class Produs : BaseEntity
{
    public string? nume { get; set; }
    public int pret { get; set; }
    public ICollection<ComandaProdusRelatie>? Comenzi { get; set; }
}