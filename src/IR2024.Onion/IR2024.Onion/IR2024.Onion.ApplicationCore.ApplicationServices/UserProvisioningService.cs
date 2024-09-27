using IR2024.Onion.ApplicationCore.DomainModel;
using IR2024.Onion.ApplicationCore.DomainServices;

namespace IR2024.Onion.ApplicationCore.ApplicationServices;

public class UserProvisioningService : IUserProvisioningService
{
    private readonly IUserService _userService;
    private readonly IEmailSender _emailSender;

    public UserProvisioningService(IUserService userService, IEmailSender emailSender)
    {
        _userService = userService;
        _emailSender = emailSender;
    }

    public void ProvisionUser(string username, string firstname, string lastname, string? email)
    {
        var newUser = new User()
        {
            Username = username,
            Firstname = firstname,
            Lastname = lastname,
            Email = email
        };
        _userService.AddUser(newUser);

        if (email != null)
            _emailSender.SendEmail(email, "Welcome to our platform", $"Welcome to our platform, {firstname}!");
    }
}