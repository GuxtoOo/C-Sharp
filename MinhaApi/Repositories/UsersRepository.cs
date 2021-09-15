using System.Collections.Generic;
using System.Threading.Tasks;

namespace MinhaApi.Repository
{
    public class UsersRepository : IUsersRepository
    {
        public UsersRepository()
        {
        }

        public Task AddAsync(dynamic user)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(int userId)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(long userId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<dynamic>> GetAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<dynamic> GetByIdAsync(long userId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<dynamic> GetUsers()
        {
            throw new System.NotImplementedException();
        }

        public dynamic GetUsersById(int userId)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(dynamic user)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(long userId, dynamic user)
        {
            throw new System.NotImplementedException();
        }
    }
}
