using MinhaApi.Domain.Services;
using MinhaApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaApi.Infrastructure.Services
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _usersRepository;

        public UsersService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public async Task AddAsync(dynamic user)
        {
           await _usersRepository.AddAsync(user);
        }

        public async Task DeleteAsync(long userId)
        {
            await _usersRepository.DeleteAsync(userId);
        }

        public async Task<IEnumerable<dynamic>> GetAsync()
        {
            await _usersRepository.GetAsync();
            return null;
        }

        public async Task<dynamic> GetByIdAsync(long userId)
        {
            await _usersRepository.GetByIdAsync(userId);
            return null;
        }

        public async Task UpdateAsync(long userId, dynamic user)
        {
            await _usersRepository.UpdateAsync(userId, user);
        }
    }
}
