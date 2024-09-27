using System.Text.Json;
using IR2024.Onion.ApplicationCore.DomainModel;
using IR2024.Onion.ApplicationCore.DomainServices;

namespace IR2024.Onion.Infra;

public class FileSystemUserRepository : IUserRepository
{
    private readonly string _path;

    public FileSystemUserRepository(string path)
    {
        _path = path;
    }
    
    public void SaveUser(User user)
    {
        var filePath = Path.Combine(_path, $"{user.Username}.json");
        File.WriteAllText(filePath, JsonSerializer.Serialize(user));
    }

    public User? GetUserByUsername(string userName)
    {
        var filePath = Path.Combine(_path, $"{userName}.json");
        if (!File.Exists(filePath))
        {
            return null;
        }

        var fileContent = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<User>(fileContent);
    }
}