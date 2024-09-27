using IR2024.Onion.ApplicationCore.DomainModel;
using Moq;

namespace IR2024.Onion.ApplicationCore.DomainServices.Tests;

public class UserServiceTests
{
    [Fact]
    public void UserService_AddUser_Throws_Exception_When_User_With_Same_Name_Exists()
    {
        // Arrange
        var userRepository = new Mock<IUserRepository>();
        
        var userService = new UserService(userRepository.Object);
        var existingUser = new User
        {
            Username = "testuser"
        };
        userRepository.Setup(x => x.GetUserByUsername("testuser"))
            .Returns(existingUser);
        
        // Act
        var newUser = new User
        {
            Username = "testuser"
        };
        
        // Assert
        Assert.Throws<Exception>(() => userService.AddUser(newUser));
    }
}