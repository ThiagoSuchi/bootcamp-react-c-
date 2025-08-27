using bootcamp.Models;

DateTime dataAtual = DateTime.Now;

string a = "20";
int b = Convert.ToInt32(a);

// OU com parse, que diferente de Convert não trata valores null retornando error
int c = int.Parse(a);

Console.WriteLine("b => " + b);
Console.WriteLine("c => " + c);
Console.WriteLine(dataAtual);

string apresentacao = "Olá, seja bem vindo.";
int quantidade = 1;
double altura = 1.80;
decimal preco = 1.80m;
bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura);
Console.WriteLine("Valor da variável preco: " + preco);
Console.WriteLine("Valor da variável condicao: " + condicao);

Console.WriteLine("\n---------------------------------------------\n");

// Target-typed new | Object initilazer
Pessoa p = new() { Nome = "Thiago", Idade = 22 };

p.Apresentar();

