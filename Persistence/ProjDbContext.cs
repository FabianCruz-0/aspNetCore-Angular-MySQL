using Microsoft.EntityFrameworkCore;
namespace vsc_net_ang__github_.Persistence
{
    public class ProjDbContext : DbContext //Importar el using correspondiente
    {
        public ProjDbContext(DbContextOptions<ProjDbContext> options)
        : base(options)
        {
        }
    }
}