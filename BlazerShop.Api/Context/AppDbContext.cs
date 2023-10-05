using BlazerShop.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazerShop.Api.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Carrinho>? Carrinhos { get; set; }
        public DbSet<CarrinhoItem>? CarrinhoItems { get; set; }
        public DbSet<Produto>? Produtos { get; set; }
        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Usuario>? Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasData(new Categoria
            {
                Id = 1,
                Nome = "Beleza",
                IconCss = "fas fa-spa"
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 1,
                Nome = "Beleza",
                Descricao = "Um kit fornecido pela Natura, contendo produtos para cuidados com a pele",
                ImagemUrl = "https://static.natura.com/cdn/ff/FOcvEZ2gkqvY_D2tq4hrKI1Mo12IHIVFbA3-T0p4B8Y/1663820690/public/styles/original/public/2021-03/limpeza-da-pele-5-motivos-essencial-rotina-mobile.jpg?itok=0b2C2R9f",
                Preco = 100,
                Quantidade = 100, 
                CategoriaId = 1
            });
            modelBuilder.Entity<Usuario>().HasData(new Usuario
            {
                Id = 1,
                NomeUsuario = "Pedrinho"
                
            });
        }
    }
}
