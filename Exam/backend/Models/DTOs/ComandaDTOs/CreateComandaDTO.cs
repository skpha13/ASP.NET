namespace backend.Models.DTOs.ComandaDTOs;

public class CreateComandaDTO
{
    public bool? Favorita { get; set; }
    public Guid UtilizatorId { get; set; }
}