using backend.Models.Base;

namespace backend.Models;

public class Utilizator : BaseEntity
{
    public string? nume { get; set; }
    public ICollection<Comanda>? Comenzi { get; set; }
}