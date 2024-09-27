using IR2024.Onion.ApplicationCore.DomainModel;

namespace IR2024.Onion.ApplicationCore.DomainServices;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public void AddUser(User newUser)
    {
        var existingUser = _userRepository.GetUserByUsername(newUser.Username);
        if(existingUser != null)
        {
            throw new Exception("User already exists");
        }
        _userRepository.SaveUser(newUser);
    }
}