using Microsoft.EntityFrameworkCore;

namespace mundo_veg.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<UsuarioPf> UsuarioPfs { get; set; }
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<UsuarioPj> UsuarioPjs { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
