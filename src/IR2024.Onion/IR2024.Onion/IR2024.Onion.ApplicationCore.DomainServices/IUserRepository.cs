using IR2024.Onion.ApplicationCore.DomainModel;

namespace IR2024.Onion.ApplicationCore.DomainServices;

public interface IUserRepository
{
    void SaveUser(User user);
    User? GetUserByUsername(string userName);
}