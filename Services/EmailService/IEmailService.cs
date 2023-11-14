using HD.Models;

namespace HD.Services.EmailService
{
    public interface IEmailService
    {
        void SendEmail(EmailDio request);
    }
}
