namespace IR2024.Onion.ApplicationCore.ApplicationServices;

public interface IUserProvisioningService
{
    void ProvisionUser(string username, string firstname, string lastname, string? email);
}