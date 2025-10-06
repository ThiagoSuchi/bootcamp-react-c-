using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entity;

[TestClass]
public class AdministradorEntidadeTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        // Arrange
        var adm = new Administrador
        {
            // Act
            Id = 1,
            Email = "teste@teste.com",
            Senha = "test",
            Perfil = "Adm"
        };

        // Assert
        Assert.AreEqual(1, adm.Id);
        Assert.AreEqual("teste@teste.com", adm.Email);
        Assert.AreEqual("test", adm.Senha);
        Assert.AreEqual("Adm", adm.Perfil);
    }
}