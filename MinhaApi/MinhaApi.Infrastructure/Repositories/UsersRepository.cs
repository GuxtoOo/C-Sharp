using Microsoft.EntityFrameworkCore;
using MinhaApi.Domain.AggregatesModel;
using MinhaApi.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MinhaApi.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private readonly ApiDbContext _apiDbContext;

        public UsersRepository(ApiDbContext apiDbContext)
        {
            _apiDbContext = apiDbContext;
        }

        public async Task<long> AddAsync(User user)
        {

            var command = await _apiDbContext.Users.AddAsync(user);

            await _apiDbContext.SaveChangesAsync();

            return command.Entity.Id;
        }
                
        public async Task DeleteAsync(long id)
        {
            _apiDbContext.Users.Remove(_apiDbContext.Users.Find(id));

            await _apiDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<dynamic>> GetAsync()
        {
            //Lembrar de fazer a implementação            
            var query = await _apiDbContext.Users.ToListAsync();
            return query;
        }

        public async Task<User> GetByIdAsync(long userId)
        {
            var query = await _apiDbContext.Users
                .FirstOrDefaultAsync(s => s.Id == userId);

            return query;
        }

        public async Task UpdateAsync(long userId, dynamic users)
        {
            var user = await GetByIdAsync(userId);

            //user.SetName("Guxto");
            user.SetDocument("88884444");

            _apiDbContext.SaveChanges();
        }
    }
}
