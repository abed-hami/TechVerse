using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechVerse.Core.Interfaces;
using TechVerse.Core.Models;

namespace TechVerse.Core.Repository
{
    public class UserRepository:IUserRepository
    {
        private readonly TechVerseContext _dbContext;

        public UserRepository(TechVerseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _dbContext.Set<User>().ToListAsync();
        }

        public async Task<User> GetUserById(int id)
        {
            return await _dbContext.Set<User>().FindAsync(id);
        }

        public async Task AddUser(User user)
        {
            await _dbContext.Set<User>().AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateUser(User user)
        {
            var existingEntity = _dbContext.Set<User>().Local.FirstOrDefault(e => e.Id == user.Id);
            if (existingEntity != null)
            {
                _dbContext.Entry(existingEntity).State = EntityState.Detached;
            }

            _dbContext.Entry(user).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteUser(int id)
        {
            var user = await _dbContext.Set<User>().FindAsync(id);
            if (user != null)
            {
                _dbContext.Set<User>().Remove(user);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
