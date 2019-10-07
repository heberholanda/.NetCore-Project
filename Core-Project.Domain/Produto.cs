using System;

namespace Core_Project.Domain
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string Tipo { get; set; }
        public int Quantidade { get; set; }
        public string Peso { get; set; }
    }
}
