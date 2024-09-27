namespace IR2024.Onion.ApplicationCore.ApplicationServices;

public interface IEmailSender
{
    void SendEmail(string to, string subject, string body);
}