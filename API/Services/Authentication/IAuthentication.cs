using API.Data.DTOs;

namespace API.Services.Authentication;

public interface IAuthentication
{
    public Task Login(UserDTO usertologin);
    public Task Register(UserDTO usertoregister);
}