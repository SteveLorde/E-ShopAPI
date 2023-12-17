﻿using System.Security.Cryptography;
using System.Text;
using API.Data;
using API.Data.DTOs;
using API.Data.Models;
using API.Services.Authentication.Model;
using Microsoft.EntityFrameworkCore;

namespace API.Services.Authentication;

class Authentication : IAuthentication
{
    private readonly DataContext _db;

    public Authentication(DataContext db)
    {
        _db = db;
    }
    
    public async Task<bool> Login(UserDTO usertologin)
    {
        try
        {
            bool checklogin = false;
            //1st, check username in database
            bool checkuser = await _db.Users.AnyAsync(x => x.username == usertologin.username);
            if (checkuser)
            {
                //2nd verify password
                bool checkpassword = await VerifyPassword(usertologin);
                if (checkpassword)
                {
                    checklogin = true;
                }

                return true;
            }
            else
            {
                checklogin = false;
            }
            
            return checklogin;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<bool> Register(UserDTO usertoregister)
    {
        try
        {
            //1-hash password
            Hash hashedpassword = await HashPassword(usertoregister);
            //2-create new user
            User newuser = new User
            {
                username = usertoregister.username,
                pass_salt = hashedpassword.salt,
                hashedpassword = hashedpassword.hash,
                usertype = "user"
            };
            //3-add to database
            await _db.Users.AddAsync(newuser);
            return true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<User> GetUserInfo(AuthRequestDTO request)
    {
        User user = await _db.Users.FirstAsync(x => x.Id == request.user.Id);
        return user;
    }
    
    
    private async Task<Hash> HashPassword(UserDTO user)
    {
        string salt = GenerateSalt();
        string hashedpassword = GenerateHashedPassword(user.password, salt);
        Hash userhash = new Hash()
        {
            hash = hashedpassword,
            salt = salt
        };
        return userhash;
    }
    
    private string GenerateHashedPassword(string password, string salt)
    {
        byte[] passwordbytes = Encoding.UTF8.GetBytes(password);
        byte[] saltbytes = Convert.FromBase64String(salt);

        byte[] combinedbytes = new byte[saltbytes.Length + passwordbytes.Length];
        Buffer.BlockCopy(saltbytes,0,combinedbytes, 0, saltbytes.Length);
        Buffer.BlockCopy(passwordbytes,0,combinedbytes, saltbytes.Length, passwordbytes.Length);

        SHA256 sha256 = SHA256.Create();
        byte[] hashedbytes = sha256.ComputeHash(combinedbytes);
        string hashedpassword = Convert.ToBase64String(hashedbytes);
        return hashedpassword;
    }

    private async Task<bool> VerifyPassword(UserDTO loginrequest)
    {
        User usertoverfiy = await _db.Users.FirstAsync(x => x.username == loginrequest.username);
        string passwordtoverify = GenerateHashedPassword(loginrequest.password, usertoverfiy.pass_salt);

        if (passwordtoverify == usertoverfiy.hashedpassword)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    private static string GenerateSalt()
    {
        byte[] salt = new byte[16];
        var rng = new RNGCryptoServiceProvider();
        rng.GetBytes(salt);
        string base64salt = Convert.ToBase64String(salt);
        return base64salt;
    }
    
    
    
}