using System.Collections.Generic;
using System.Threading.Tasks;

namespace MinhaApi.Repository
{
    public interface IUsersRepository
    {
        Task<IEnumerable<dynamic>> GetAsync();
        Task<dynamic> GetByIdAsync(long userId);

        Task AddAsync(dynamic user);
        Task DeleteAsync(long userId);
        Task UpdateAsync(long userId, dynamic user);
    }
}
