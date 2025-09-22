using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class Professor(string nome) : Pessoa(nome)
    {
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine("Olá sou o professor " + Nome);
        }
    }
}