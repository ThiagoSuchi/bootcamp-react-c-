using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;

//----------------------------- Serialização --------------------------------

List<Venda> listVendas = new();

Venda v1 = new(1, "Material de escritório", 25.0M);
Venda v2 = new(2, "Licença de Software", 150.0M);
Venda v3 = new(3, "Peças de carro", 1500.0M);
Venda v4 = new(4, "Material de estudo - Lápis e borracha", 10.0M);

listVendas.Add(v1);
listVendas.Add(v2);
listVendas.Add(v3);
listVendas.Add(v4);

// Serializa um objeto em uma string JSON
string serializado = JsonConvert.SerializeObject(listVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);
Console.WriteLine(serializado);

// //----------------------------- If Ternário ------------------------------

// // Convencional
// int num = 1;
// bool ePar = false;

// ePar = num % 2 == 0;
// Console.WriteLine($"O número {num} é " + (ePar ? "par" : "ímpar"));


// //-------------------------- Deconstruct -----------------------------

// Pessoa pessoa = new("Leonidas", 56);

// (string nome, int idade) = pessoa;

// Console.WriteLine($"Nome: {nome}, Idade: {idade}");

// //------------------------ Tupla ---------------------------

// (int Id, string nome, string sobrenome, decimal saldo) tupla = (1, "Luíza", "Melo Dantas", 1530.10M);

// // Outra sintaxe de tupla:
// ValueTuple<int, string, string, decimal> outraTupla = (2, "Sérgio", "Ramos", 2.500M);
// var outroExemploTuplaCreate = Tuple.Create(3, "Leticía", "Vasquez", 2.350M);

// Console.WriteLine($"ID: {tupla.Id}");
// Console.WriteLine($"Nome: {tupla.nome}");
// Console.WriteLine($"Sobrenome: {tupla.sobrenome}");
// Console.WriteLine($"Saldo: {tupla.saldo:C} \n");

// Console.WriteLine($"ID: {outraTupla.Item1}");
// Console.WriteLine($"Nome: {outraTupla.Item2}");
// Console.WriteLine($"Sobrenome: {outraTupla.Item3}");
// Console.WriteLine($"Saldo: {outraTupla.Item4:C} \n");

// Console.WriteLine($"ID: {outroExemploTuplaCreate.Item1}");
// Console.WriteLine($"Nome: {outroExemploTuplaCreate.Item2}");
// Console.WriteLine($"Sobrenome: {outroExemploTuplaCreate.Item3}");
// Console.WriteLine($"Saldo: {outroExemploTuplaCreate.Item4:C}");

// LeituraArquivo arquivo = new();

// var (sucesso, linhas, _) = arquivo.LerArquivo("Arquivos/arquivo.txt");
// // Para descartar um parâmetro usa-se o descart "_" 

// if (sucesso)
// {
//     // Console.WriteLine("\nQuantidade de linhas do arquivo: " + quantidadeLinhas);
//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("\nNão foi possível ler o arquivo.");
// }


// // ------------------------ Dictionary ------------------------------------

// Dictionary<string, string> estados = [];
// // OBS: o Dictionary garante que todo elemento adicionado seja único

// estados.Add("RO", "Rondônia");
// estados.Add("MT", "Mato Grosso");
// estados.Add("SP", "São Paulo");
// estados.Add("RS", "Rio Grande do Sul");
// estados.Add("MG", "Minas Gerais");

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key} --> Valor: {item.Value}");
// }

// Console.WriteLine("\nRemovendo o elemento: RS");
// estados.Remove("RS");
// Console.WriteLine("Alterando o valor da chave: SP");
// estados["SP"] = "São Paulo valor alterado.";

// // Só é possível alterar um elemento do dictionary pelo valor, a chave não é alterável

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key} --> Valor: {item.Value}");
// }

// if (estados.ContainsKey("RO"))
// {
//     Console.WriteLine("RO está no dicionário.");
// }


// //----------------------------- Pilhas(Stack) - LIFO -----------------------------
// Stack<int> pilha = new();

// pilha.Push(10);
// pilha.Push(15);
// pilha.Push(20);
// pilha.Push(25);
// pilha.Push(30);
// pilha.Push(35);
// pilha.Push(40);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"\nRemovendo um elemento do topo(padrão) da pilha: {pilha.Pop()} \n");
// Console.WriteLine("Adicionando um elemento no topo(padrão) da pilha: 50 \n");
// pilha.Push(50);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }


// //----------------------------- Filas(Queue) - FIFO -----------------------------
// Queue<int> fila = new();

// fila.Enqueue(2);
// fila.Enqueue(19);
// fila.Enqueue(20); 
// fila.Enqueue(35);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"\nRemovendo o elemento no ínicio da fila(ordem padrão): {fila.Dequeue()} \n");
// Console.WriteLine("Adicionando o elemento no final da fila(ordem padrão): 10 \n");
// fila.Enqueue(10);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }


// //----------------------------- Leitura de arquivo -----------------------------
// new ExemploException().Metodo1();

// try 
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivo.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro de leitura. Arquivo não encontrado {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }
// OBS: É possível ter mais de um catch para tratar o erro específicamente.


// // --------------------------- Poo -------------------------------
// Classes instânciadas sem construtor
// Pessoa p1 = new() { Nome = "Thiago", Idade = 23 };
// Pessoa p2 = new() { Nome = "Larissa", Idade = 25 };

// // Classes instânciadas com construtor
// Pessoa p3 = new("Amanda", 30);
// Pessoa p4 = new("Kauan", 23);

// Curso cursoDeMatematica = new() { Nome = "Matemática", Alunos = [] };

// Console.WriteLine("------------------Adicionando alunos------------------");
// cursoDeMatematica.AdicionarAluno(p1);
// cursoDeMatematica.AdicionarAluno(p2);
// cursoDeMatematica.AdicionarAluno(p3);
// cursoDeMatematica.AdicionarAluno(p4);

// cursoDeMatematica.ListarAlunos();
// int countAluno = cursoDeMatematica.ObterQuantidadeDeAlunosMatriculados();
// Console.WriteLine("Quantidade de alunos mátriculados: \n" + countAluno);

// Console.WriteLine("------------------Após remover um aluno------------------");
// cursoDeMatematica.RemoverAluno(p1);
// cursoDeMatematica.ListarAlunos();
// countAluno = cursoDeMatematica.ObterQuantidadeDeAlunosMatriculados();
// Console.WriteLine("Quantidade de alunos mátriculados: \n" + countAluno);