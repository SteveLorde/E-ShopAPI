using System.ComponentModel.DataAnnotations.Schema;

namespace API.Data.Models;



public class User
{
    public int UserId { get; set; }
    public string username { get; set; }
    [NotMapped]
    public string? password { get; set; }
    public string? pass_salt { get; set; }
    public string? hashedpassword { get; set; }
    public string usertype { get; set; }
    
    public enum usertypes {
        User,
        Admin
    }


}