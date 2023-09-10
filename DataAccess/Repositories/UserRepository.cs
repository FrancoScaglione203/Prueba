using Prueba.DataAccess.Repositories.Interfaces;
using Prueba.Entities;

namespace Prueba.DataAccess.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {

        public UserRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
