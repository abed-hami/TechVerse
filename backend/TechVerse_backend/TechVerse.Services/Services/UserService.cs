using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechVerse.Core.Interfaces;
using TechVerse.Core.Models;
using TechVerse.Services.Interfaces;

namespace TechVerse.Services.Services
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _userRepository.GetAllUsers();
        }

        public async Task<User> GetUserById(int id)
        {
            return await _userRepository.GetUserById(id);
        }

        public async Task AddUser(User user)
        {
            if (ValidateUser(user))
            {
                await _userRepository.AddUser(user);
            }
            else
            {
                throw new ArgumentException("Invalid user data");
            }
        }

        public async Task UpdateUser(User user)
        {
            await _userRepository.UpdateUser(user);
        }

        public async Task DeleteUser(int id)
        {
            await _userRepository.DeleteUser(id);
        }

        private bool ValidateUser(User user)
        {
            if (user.Id != null)
            {
                return true;
            }
            return false;
        }
    }
}
