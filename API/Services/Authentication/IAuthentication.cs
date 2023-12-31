﻿using API.Data.DTOs;
using API.Data.Models;

namespace API.Services.Authentication;

public interface IAuthentication
{
    public Task<bool> Login(UserDTO usertologin);
    public Task<string> LoginTest(UserDTO usertologin);
    public Task<bool> Register(UserDTO usertoregister);
    public Task<string> GetUserInfo();
}