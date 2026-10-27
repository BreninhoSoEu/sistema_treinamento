using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace sistema_treinamento.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
    public DbSet<sistema_treinamento.Models.Estoque> Estoque { get; set; } = default!;
    public DbSet<sistema_treinamento.Models.Produto> Produtos { get; set; } = default!;
    }
}
