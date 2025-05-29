using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SistemaAtlasAPI.Data
{
    public class EscolaContextFactory : IDesignTimeDbContextFactory<EscolaContext>
    {
        public EscolaContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EscolaContext>();
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-MDQ2TD4;Initial Catalog=SistemaEscolaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

            return new EscolaContext(optionsBuilder.Options);
        }
    }
}
