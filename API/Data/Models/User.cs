namespace API.Data.Models;

public interface User
{
    public int UserId { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public string usertype { get; set; }
    
}