using API.Data.Models;

namespace API.Data.DTOs;

public interface AuthRequestDTO
{
    public User user { get; set; }
    public string token { get; set; }
}