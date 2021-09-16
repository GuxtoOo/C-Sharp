using MinhaApi.Domain.AggregatesModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MinhaApi.Repository
{
    public interface IUsersRepository
    {
        Task<IEnumerable<dynamic>> GetAsync();
        Task<User> GetByIdAsync(long userId);
        Task<long> AddAsync(User user);
        Task DeleteAsync(long userId);
        Task UpdateAsync(long userId, dynamic user);
    }
}
