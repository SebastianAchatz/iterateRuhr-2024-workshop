using IR2024.PnA.ApplicationDomain.Entities;

namespace IR2024.PnA.Ports;

public interface IUserRepository
{
    void SaveUser(User user);
    User GetUserByUsername(string userName);
}