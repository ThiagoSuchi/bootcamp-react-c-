using Microsoft.EntityFrameworkCore;
using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Services;
using MinimalApi.Infraestrutura.Db;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Domain.Services;

[TestClass]
public class VeiculoServiceTest
{
    private DbContexto _context = null!;
    private VeiculoService _service = null!;

    [TestInitialize]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<DbContexto>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        _context = new DbContexto(options);
        _service = new VeiculoService(_context);
    }

    [TestCleanup]
    public void Cleanup()
    {
        _context.Dispose();
    }

    [TestMethod]
    public void Incluir_AddsVeiculo()
    {
        // Arrange
        var veiculo = new Veiculo { Nome = "Civic", Marca = "Honda", Ano = 2020 };

        // Act
        _service.Incluir(veiculo);

        // Assert
        Assert.AreEqual(1, _context.Veiculos.Count());
    }

    [TestMethod]
    public void BuscaPorId_ExistingId_ReturnsVeiculo()
    {
        // Arrange
        var veiculo = new Veiculo { Nome = "Civic", Marca = "Honda", Ano = 2020 };
        _context.Veiculos.Add(veiculo);
        _context.SaveChanges();

        // Act
        var result = _service.BuscaPorId(veiculo.Id);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(veiculo.Id, result.Id);
    }

    [TestMethod]
    public void Atualizar_UpdatesVeiculo()
    {
        // Arrange
        var veiculo = new Veiculo { Nome = "Civic", Marca = "Honda", Ano = 2020 };
        _context.Veiculos.Add(veiculo);
        _context.SaveChanges();

        veiculo.Nome = "Accord";

        // Act
        _service.Atualizar(veiculo);

        // Assert
        var updated = _context.Veiculos.Find(veiculo.Id);
        Assert.AreEqual("Accord", updated?.Nome);
    }

    [TestMethod]
    public void Apagar_RemovesVeiculo()
    {
        // Arrange
        var veiculo = new Veiculo { Nome = "Civic", Marca = "Honda", Ano = 2020 };
        _context.Veiculos.Add(veiculo);
        _context.SaveChanges();

        // Act
        _service.Apagar(veiculo);

        // Assert
        Assert.AreEqual(0, _context.Veiculos.Count());
    }

    [TestMethod]
    public void Todos_ReturnsList()
    {
        // Arrange
        var veiculo1 = new Veiculo { Nome = "Civic", Marca = "Honda", Ano = 2020 };
        var veiculo2 = new Veiculo { Nome = "Corolla", Marca = "Toyota", Ano = 2021 };
        _context.Veiculos.AddRange(veiculo1, veiculo2);
        _context.SaveChanges();

        // Act
        var result = _service.Todos();

        // Assert
        Assert.AreEqual(2, result.Count);
    }
}