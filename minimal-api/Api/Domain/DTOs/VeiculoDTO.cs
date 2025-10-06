namespace MinimalApi.DTOs;

public record class VeiculoDTO
{

    public required string Nome { get; set; }

    public required string Marca { get; set; }

    public required int Ano { get; set; }
}