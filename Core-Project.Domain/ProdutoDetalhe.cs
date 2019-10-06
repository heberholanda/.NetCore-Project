using System;

namespace Core_Project.Domain
{
    public class ProdutoDetalhe
    {
        public int Id { get; set; }
        public int? ProdutoId { get; set; }
        public Produto Produto { get; }
        public string Tipo { get; set; }
        public int Quantidade { get; set; }
        public int Peso { get; set; }
    }
}
