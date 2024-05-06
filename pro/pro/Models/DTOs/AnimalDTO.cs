namespace pro.Models.DTOs;

public class AnimalDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public DateTime AdmissionDate { get; set; }
    public OwnerDto Owner { get; set; } = null!;
    public List<ProcedureDto> Procedures { get; set; } = null!;
}