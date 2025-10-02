using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Interfaces;
using MinimalApi.DTOs;
using MinimalApi.Infraestrutura.Db;

namespace MinimalApi.Dominio.Services;

public class AdministradorService : IAdministradorService
{
    private readonly DbContexto _contexto;

    public AdministradorService(DbContexto contexto)
    {
        _contexto = contexto;
    }

    public Administrador? BuscarPorId(int id)
    {
        return _contexto.Administradores.Where(v => v.Id == id).FirstOrDefault();
    }

    public Administrador? Incluir(Administrador administrador)
    {
        _contexto.Administradores.Add(administrador);
        _contexto.SaveChanges();

        return administrador;
    }

    public Administrador? Login(LoginDTO loginDTO)
    {
        var adm = _contexto.Administradores.Where(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha).FirstOrDefault();
        return adm;
    }

    public List<Administrador> Todos(int? page)
    {
        var query = _contexto.Administradores.AsQueryable();

        int itemPerPage = 10;

        if (page != null)
        {
            query = query.Skip(((int)page - 1) * itemPerPage).Take(itemPerPage);
        }

        return query.ToList();
    }
}