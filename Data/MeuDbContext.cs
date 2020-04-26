using Microsoft.EntityFrameworkCore;

namespace app_mvc_core.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options)
        :base(options)
        {
            
        }
    }
}