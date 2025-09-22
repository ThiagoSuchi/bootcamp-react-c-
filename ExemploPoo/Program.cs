using ExemploPoo.interfaces;
using ExemploPoo.Models;

//-------------------------- Interfaces ---------------------------
ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(2, 3));


// //------------------------- Class Object ---------------------------
// Computador c = new();
// Console.WriteLine(c.ToString());


// //---------------------- Construtor por Herança -----------------
// Pessoa p1 = new("Letícia") { Idade = 28 };
// Aluno a1 = new("Carlos") { Idade = 15, Nota = 7.6 };

// p1.Apresentar();
// a1.Apresentar();


// //---------------- Classe Abstrata --------------------
// Corrente c = new();

// c.Creditar(1250);
// c.ExibirSaldo();

// //------------ Herança e Polimorfismo ----------------
// Aluno a1 = new()
// {
//     Nome = "Jõao",
//     Idade = 24,
//     Nota = 10
// };

// a1.Apresentar();

// Professor p1 = new()
// {
//     Nome = "Adailton",
//     Idade = 38,
//     Salario = 3.500M
// };

// p1.Apresentar();


// //--------- Encapsulamento -------------
// ContaCorrente c1 = new(222, 1500);

// c1.ExibirSaldo();
// c1.Sacar(150);
// c1.ExibirSaldo();
// c1.Sacar(1400);
// c1.ExibirSaldo();


//--------- Abstração ---------------
// Pessoa p1 = new()
// {
//     Nome = "Dalila",
//     Idade = 34
// };

// p1.Apresentar();