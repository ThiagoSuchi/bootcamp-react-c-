using DesafioPOO.Models;

Console.WriteLine("=== TESTES DO DESAFIO POO ===\n");

// Teste com Nokia
Console.WriteLine("=== TESTANDO NOKIA ===");
Nokia nokia = new Nokia("11999887766", "Nokia 3310", "123456789012345", 64);

Console.WriteLine($"Número: {nokia.Numero}");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
nokia.InstalarAplicativo("Snake");

Console.WriteLine();

// Teste com iPhone
Console.WriteLine("=== TESTANDO IPHONE ===");
Iphone iphone = new Iphone("11888776655", "iPhone 14", "987654321098765", 256);

Console.WriteLine($"Número: {iphone.Numero}");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
iphone.InstalarAplicativo("Telegram");

Console.WriteLine();

// Teste de polimorfismo
Console.WriteLine("=== TESTE DE POLIMORFISMO ===");
List<Smartphone> smartphones = new()
{
    new Nokia("11777665544", "Nokia XR20", "111222333444555", 128),
    new Iphone("11666554433", "iPhone 15 Pro", "555444333222111", 512)
};

foreach (Smartphone smartphone in smartphones)
{
    Console.WriteLine($"Testando smartphone: {smartphone.GetType().Name}");
    smartphone.Ligar();
    smartphone.InstalarAplicativo("YouTube");
    Console.WriteLine();
}