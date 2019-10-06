using System;
using System.Collections.Generic;

namespace Core_Project.Domain
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Documento { get; set; }
        public DateTime? DataCadastro { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
