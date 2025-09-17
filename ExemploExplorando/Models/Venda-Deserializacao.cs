using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExemploExplorando.Models
{
    public class VendaDeserializacao
    {
        public int Id { get; set; }

        // É um atributo que mapeia o nome da propriedade no JSON
        // para a propriedade da classe
        [JsonProperty("Produto_Venda")]
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}