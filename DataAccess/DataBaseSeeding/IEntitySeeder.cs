using Microsoft.EntityFrameworkCore;

namespace Prueba.DataAccess.DataBaseSeeding
{
    public interface IEntitySeeder
    {
        void SeedDataBase(ModelBuilder modelBuilder);
    }
}
