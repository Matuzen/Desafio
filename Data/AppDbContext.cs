using Desafio.Model;
using Microsoft.EntityFrameworkCore;

namespace Desafio.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<DesafioModel> DesafioModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=Zuk;Database=Consulta;Integrated Security=SSPI;TrustServerCertificate=True");

        
    }
}