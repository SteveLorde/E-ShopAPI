using API.Services.Mail.Model;

namespace API.Services.Mail;

public interface IMailService
{
    public Task SendEmailAsync(MailDTO mailRequest);
}