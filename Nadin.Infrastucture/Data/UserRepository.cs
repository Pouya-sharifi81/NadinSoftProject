using Microsoft.EntityFrameworkCore;
using Nadin.Domain.Contract;
using Nadin.Domain.Model;
using Nadin.Infrastucture.Context;

namespace Nadin.Infrastucture.Data;

public class UserRepository : IUserRepository
{
    private readonly NadinContext _context;

    public UserRepository( NadinContext context)
    {
        _context = context;
    }
    public async Task<User> Authenticate(string username, string password)
    {
        return await _context.Users.SingleOrDefaultAsync(x => x.Username == username && x.Password == password);
    }

    public async Task<User> GetById(int id)
    {
        return await _context.Users.FindAsync(id);
    }

    public async Task Add(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
    }
}