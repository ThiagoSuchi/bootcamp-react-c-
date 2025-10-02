using MinimalApi.Dominio.Enums;

namespace MinimalApi.Dominio.ModelViews;

public record AdministradorModelView
{
    public required int Id { get; set; }
    public required string Email { get; set; }
    public string? Perfil { get; set; }
}