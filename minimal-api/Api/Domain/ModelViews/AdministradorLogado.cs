using MinimalApi.Dominio.Enums;

namespace MinimalApi.Dominio.ModelViews;

public record AdministradorLogado
{
    public required string Email { get; set; }
    public string? Perfil { get; set; }
    public required string Token { get; set; }
}