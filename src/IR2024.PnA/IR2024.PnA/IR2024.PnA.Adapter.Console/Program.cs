// See https://aka.ms/new-console-template for more information

using IR2024.PnA.Adapter;
using IR2024.PnA.ApplicationDomain;
using IR2024.PnA.ApplicationDomain.Entities;

Console.WriteLine("Hello, Workshop!");

var user = new User()
{
    Id = Guid.NewGuid().ToString(),
    Username = "johndoe",
    Firstname = "John",
    Lastname = "Doe"
};
 
var userRepository = new FileSystemUserRepository("/Users/sebastian/Desktop/UserData");
var userService = new UserService(userRepository);
userService.AddUser(user);

Console.WriteLine("Hello, Workshop wir sind fertig!");
Console.ReadLine();
