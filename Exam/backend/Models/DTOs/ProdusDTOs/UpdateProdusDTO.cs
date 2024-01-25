namespace backend.Models.DTOs.ProdusDTOs;

public class UpdateProdusDTO
{
    public Guid Id { get; set; }
    public string? nume { get; set; }
    public int? pret { get; set; }
}