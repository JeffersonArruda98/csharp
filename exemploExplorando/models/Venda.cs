using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploExplorando.models
{
    public class Venda
    {
        public int Venda (int id, string produto, decimal preco)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
        }
    
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
    }
}