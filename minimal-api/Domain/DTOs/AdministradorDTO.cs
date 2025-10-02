using MinimalApi.Dominio.Enums;

namespace MinimalApi.DTOs;

public class AdministradorDTO
{
    public required string Email { get; set; }
    public required string Senha { get; set; }
    public Perfil? Perfil { get; set; }
}
