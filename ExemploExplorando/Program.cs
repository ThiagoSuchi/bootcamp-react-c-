using ExemploExplorando.Models;

// Classes instânciadas sem construtor
Pessoa p1 = new() { Nome = "Thiago", Idade = 23 };
Pessoa p2 = new() { Nome = "Larissa", Idade = 25 };

// Classes instânciadas com construtor
Pessoa p3 = new("Amanda", 30);
Pessoa p4 = new("Kauan", 23);

Curso cursoDeMatematica = new() { Nome = "Matemática", Alunos = [] };

Console.WriteLine("------------------Adicionando alunos------------------");
cursoDeMatematica.AdicionarAluno(p1);
cursoDeMatematica.AdicionarAluno(p2);
cursoDeMatematica.AdicionarAluno(p3);
cursoDeMatematica.AdicionarAluno(p4);

cursoDeMatematica.ListarAlunos();
int countAluno = cursoDeMatematica.ObterQuantidadeDeAlunosMatriculados();
Console.WriteLine("Quantidade de alunos mátriculados: \n" + countAluno);

Console.WriteLine("------------------Após remover um aluno------------------");
cursoDeMatematica.RemoverAluno(p1);
cursoDeMatematica.ListarAlunos();
countAluno = cursoDeMatematica.ObterQuantidadeDeAlunosMatriculados();
Console.WriteLine("Quantidade de alunos mátriculados: \n" + countAluno);