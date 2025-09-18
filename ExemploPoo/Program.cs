using ExemploPoo.Models;

//------------ Herança e Polimorfismo ----------------
Aluno a1 = new()
{
    Nome = "Jõao",
    Idade = 24,
    Nota = 10
};

a1.Apresentar();

Professor p1 = new()
{
    Nome = "Adailton",
    Idade = 38,
    Salario = 3.500M
};

p1.Apresentar();


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