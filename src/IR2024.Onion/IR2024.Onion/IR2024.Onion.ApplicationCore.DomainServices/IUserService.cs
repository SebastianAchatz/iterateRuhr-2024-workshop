using IR2024.Onion.ApplicationCore.DomainModel;

namespace IR2024.Onion.ApplicationCore.DomainServices;

public interface IUserService
{
    void AddUser(User newUser);
}