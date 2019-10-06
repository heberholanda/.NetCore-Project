using System;
using Core_Project.Domain;
using Microsoft.EntityFrameworkCore;

namespace Core_Project.Repository
{
    public class Core_ProjectContext : DbContext
    {
        public Core_ProjectContext(DbContextOptions<Core_ProjectContext> options) : base (options) {}        

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoDetalhe> ProdutoDetalhes { get; set; }
    }
}

