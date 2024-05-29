using Nadin.Domain.Contract;
using Nadin.Domain.Model;
using Nadin.Infrastucture.Data;

namespace Nadin.Infrastucture.Service;

public class UserService
{
    private readonly IUserRepository _userRepository;
    private readonly IJwtTokenService _jwtTokenService;

    public UserService(IUserRepository userRepository, IJwtTokenService jwtTokenService)
    {
        _userRepository = userRepository;
        _jwtTokenService = jwtTokenService;
    }

    public async Task<User> Authenticate(string username, string password)
    {
        var user = await _userRepository.Authenticate(username, password);

        if (user == null)
            return null;

        user.Token = _jwtTokenService.GenerateToken(user.Id.ToString(), user.Role);
        return user;
    }

    public async Task<User> GetById(int id)
    {
        return await _userRepository.GetById(id);
    }

    public async Task Register(User user)
    {
        await _userRepository.Add(user);
    }
}
