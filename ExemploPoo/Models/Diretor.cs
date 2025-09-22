using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class Diretor(string nome) : Professor(nome)
    {
        public sealed override void Apresentar()
        {
            Console.WriteLine("Olá sou o Diretor");
        }
    }
}