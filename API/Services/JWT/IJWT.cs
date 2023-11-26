using API.Data.Models;


namespace API.Services.JWT;

public interface IJWT
{
    public string CreateToken(User user);
}