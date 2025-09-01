/* Acessando a class Pessoa */
using ExeFundamentos.Common.Models;

Console.WriteLine("\n---------------------------------------------\n");

// Target-typed new | Object initilazer
Pessoa p = new() { Nome = "Thiago", Idade = 22 };

p.Apresentar();

Console.WriteLine("\n---------------------------------------------\n");
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

string d = "20-";

int e = 0;

int.TryParse(d, out e);

Console.WriteLine(e);
Console.WriteLine("Conversão realizada com sucesso!");

Console.WriteLine("\n---------------------------------------------\n");

/* Acessando a class Pessoa */

Calculadora calc = new();

calc.Somar(20, 10);
calc.Subtrair(2, 20);
calc.Multiplicar(5, 3);
calc.Dividir(50, 10);
calc.Potencia(7, 3);
calc.Seno(62);
calc.Coseno(43);
calc.Tangente(50);
calc.RaizQuadrada(24);

Console.WriteLine("\n---------------------Exercício 1° - Apólices-----------------------\n");
Console.WriteLine("Insíra as apólices com os respectivos NomeCliente:NumeroApolice");

/*----------- Exercício 1° - Apólices -----------*/

// Lê a string de entrada que contém as apólices separadas por vírgulas  
string input = Console.ReadLine() ?? string.Empty;

// Divide a string em um array de apólices  
string[] apolices = input.Split(',');

// TODO: Ordene as apólices pelo nome do cliente (parte antes do ":")  
// R:
var apolicesOrdenadas = apolices.OrderBy(n => n.Split(':')[0].Trim()).ToArray();

// Junta as apólices ordenadas em uma única string, separadas por vírgulas  
string resultado = "Apólices criadas e ordenadas: " + string.Join(",", apolicesOrdenadas);

// Exibe o resultado final  
Console.WriteLine(resultado);