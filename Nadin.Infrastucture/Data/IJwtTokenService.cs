namespace Nadin.Infrastucture.Data;

public interface IJwtTokenService
{
    string GenerateToken(string userId, string role);
}