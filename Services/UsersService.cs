using MinhaApi.Domain.AggregatesModel;
using MinhaApi.Domain.Services;
using MinhaApi.Repository;
using System.Collections.Generic;
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

        public async Task AddAsync(dynamic model)
        {
            User user = new(model.Name, model.Document); 

           await _usersRepository.AddAsync(user);
        }

        public async Task DeleteAsync(long userId)
        {
            User user = new User(userId);

            await _usersRepository.DeleteAsync(userId);
        }

        public async Task<IEnumerable<dynamic>> GetAsync()
        {
            var query = await _usersRepository.GetAsync();
            return query;
        }

        public async Task<dynamic> GetByIdAsync(long userId)
        {
            var usuario = await _usersRepository.GetByIdAsync(userId);
            return usuario;
        }

        public async Task UpdateAsync(long userId, dynamic user)
        {
            await _usersRepository.UpdateAsync(userId, user);
        }
    }
}
