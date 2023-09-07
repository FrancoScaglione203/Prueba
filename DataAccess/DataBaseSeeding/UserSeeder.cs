using Microsoft.EntityFrameworkCore;
using Prueba.Entities;

namespace Prueba.DataAccess.DataBaseSeeding
{
    public class UserSeeder : IEntitySeeder
    {
        public void SeedDataBase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "Franco",
                    LastName = "Scaglione",
                    Email = "fscaglione@gmail.com",
                    Password = "1234"
                });
        }
    }
}
