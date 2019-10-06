using System;

namespace Core_Project.Domain
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int ProdutoDetalhesId { get; set; }
        public ProdutoDetalhe ProdutoDetalhe { get; set; }
    }
}
