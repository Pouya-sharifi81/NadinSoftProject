using Nadin.Domain.Model;

namespace Nadin.Domain.Contract;

public interface IUserRepository
{
    Task<User> Authenticate(string username, string password);
    Task<User> GetById(int id);
    Task Add(User user);
}