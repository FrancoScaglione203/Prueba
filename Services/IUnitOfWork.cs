using Prueba.DataAccess.Repositories;

namespace Prueba.Services
{
    public interface IUnitOfWork
    {
        public UserRepository UserRepository { get; }
    }
}
