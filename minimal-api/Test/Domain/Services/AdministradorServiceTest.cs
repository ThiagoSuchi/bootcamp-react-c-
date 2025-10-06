using Microsoft.EntityFrameworkCore;
using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Services;
using MinimalApi.DTOs;
using MinimalApi.Infraestrutura.Db;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Domain.Services;

[TestClass]
public class AdministradorServiceTest
{
    private DbContexto _context = null!;
    private AdministradorService _service = null!;

    [TestInitialize]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<DbContexto>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        _context = new DbContexto(options);
        _service = new AdministradorService(_context);
    }

    [TestCleanup]
    public void Cleanup()
    {
        _context.Dispose();
    }

    [TestMethod]
    public void Login_ValidCredentials_ReturnsAdministrador()
    {
        // Arrange
        var admin = new Administrador { Email = "test@test.com", Senha = "123", Perfil = "Adm" };
        _context.Administradores.Add(admin);
        _context.SaveChanges();

        var loginDTO = new LoginDTO { Email = "test@test.com", Senha = "123" };

        // Act
        var result = _service.Login(loginDTO);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual("test@test.com", result.Email);
    }

    [TestMethod]
    public void Login_InvalidCredentials_ReturnsNull()
    {
        // Arrange
        var loginDTO = new LoginDTO { Email = "invalid@test.com", Senha = "wrong" };

        // Act
        var result = _service.Login(loginDTO);

        // Assert
        Assert.IsNull(result);
    }

    [TestMethod]
    public void Incluir_AddsAdministrador()
    {
        // Arrange
        var admin = new Administrador { Email = "new@test.com", Senha = "123", Perfil = "Editor" };

        // Act
        var result = _service.Incluir(admin);

        // Assert
        Assert.AreEqual(admin, result);
        Assert.AreEqual(1, _context.Administradores.Count());
    }

    [TestMethod]
    public void BuscarPorId_ExistingId_ReturnsAdministrador()
    {
        // Arrange
        var admin = new Administrador { Email = "test@test.com", Senha = "123", Perfil = "Adm" };
        _context.Administradores.Add(admin);
        _context.SaveChanges();

        // Act
        var result = _service.BuscarPorId(admin.Id);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(admin.Id, result.Id);
    }

    [TestMethod]
    public void Todos_ReturnsList()
    {
        // Arrange
        var admin1 = new Administrador { Email = "test1@test.com", Senha = "123", Perfil = "Adm" };
        var admin2 = new Administrador { Email = "test2@test.com", Senha = "123", Perfil = "Editor" };
        _context.Administradores.AddRange(admin1, admin2);
        _context.SaveChanges();

        // Act
        var result = _service.Todos(null);

        // Assert
        Assert.AreEqual(2, result.Count);
    }
}