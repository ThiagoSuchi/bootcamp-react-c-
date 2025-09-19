using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class Aluno(string nome) : Pessoa(nome)
    {
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá me chamo {Nome} tenho {Idade} anos, e minha nota deste semestre foi {Nota}");
        }
    }

}