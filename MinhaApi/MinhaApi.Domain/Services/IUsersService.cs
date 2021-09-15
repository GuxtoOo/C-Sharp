using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaApi.Domain.Services
{
    public interface IUsersService
    {
        Task<IEnumerable<dynamic>> GetAsync();
        Task<dynamic> GetByIdAsync(long userId);

        Task AddAsync(dynamic user);
        Task DeleteAsync(long userId);
        Task UpdateAsync(long userId, dynamic user);
    }
}
