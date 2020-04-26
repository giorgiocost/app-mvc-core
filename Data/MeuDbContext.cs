using app_mvc_core.Models;
using Microsoft.EntityFrameworkCore;

namespace app_mvc_core.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options)
        :base(options)
        {
            
        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}