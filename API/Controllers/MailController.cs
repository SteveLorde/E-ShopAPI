using API.Data.DTOs;
using API.Data.Models;
using API.Services.Authentication;
using API.Services.JWT;
using API.Services.Mail;
using API.Services.Mail.Model;
using API.Services.NewsRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("Mail")]
public class MailController : Controller
{
    private readonly IAuthentication _auth;
    private readonly IJWT _jwt;
    private readonly IMailService _mailService;

    public MailController(IAuthentication auth, IJWT jwt, IMailService mailservice)
    {
        _mailService = mailservice;
    }
    
    [HttpPost("Send")]
    public async Task<IActionResult> Send(MailDTO request)
    {
        try
        {
            await _mailService.SendEmailAsync(request);
            return Ok();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    
    
}