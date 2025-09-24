using Microsoft.EntityFrameworkCore;
using MinimalApi.Dominio.Entidades;

namespace MinimalApi.Infraestrutura.Db;

public class DbContexto : DbContext
{
    private readonly IConfiguration _configuracaoAppSettings;

    public DbContexto(IConfiguration configuracaoAppSettings)
    {
        _configuracaoAppSettings = configuracaoAppSettings;
    }

    public DbSet<Administrador> Administradores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var stringConxao = _configuracaoAppSettings.GetConnectionString("mysql")?.ToString();

            if (!string.IsNullOrEmpty(stringConxao))
            {
                optionsBuilder.UseMySql(
                    stringConxao,
                    ServerVersion.AutoDetect(stringConxao)
                );
            }
        }
    }
}