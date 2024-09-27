using IR2024.PnA.ApplicationDomain.Entities;

namespace IR2024.PnA.ApplicationDomain;

public interface IUserService
{
    void AddUser(User newUser);
}