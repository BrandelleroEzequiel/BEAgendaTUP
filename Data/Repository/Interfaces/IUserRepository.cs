using BEAgenda.Entities;

namespace BEAgenda.Data.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetListUsers();
        Task<User> GetUserById(int Id);
        Task DeleteUser(User user);
        Task<User> AddUser(User user);
        Task UpdateUser(User user);
    }
}
