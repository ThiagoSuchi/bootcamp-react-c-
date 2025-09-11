using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa() { }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        /*
          *   JS → desestruturação é nativa, serve tanto para arrays quanto para objetos.
          *   C# → desconstrução funciona por padrão em tuplas e pode ser habilitada em classes/structs via método Deconstruct.
          *   A ideia é a mesma: quebrar um objeto/estrutura em variáveis individuais.
          *   Diferença: em C# você precisa preparar a classe (com Deconstruct), enquanto no JS é     automático.
        */

        public void Deconstruct(out string nome, out int idade)
        {
            nome = Nome;
            idade = Idade;
        }

        // Encapsular uma variável no C# é torná-la privada 
        // e controlá-la por meio de métodos ou propriedades (get e set),
        // permitindo aplicar regras de acesso e validação. Em resumo
        // serve para proteger os dados, controlar acesso e manter 
        // a integridade e consistência da aplicação.

        private string _nome; // variável encapsulada
        public string Nome
        {
            get => _nome.ToUpper();// Body expression

            set
            {
                if (value == "")
                {
                    // Exceção
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }

        private int _idade;
        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 18)
                {
                    throw new ArgumentException("Não pode ser menor de idade.");
                }

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}