using WebFinalProject.Models;
namespace WebFinalProject.Services.Users;

public interface IUserRepository
{
    Task<User> Search(string username);
    Task<Guid> Create(User user);
    Task<Guid> GetbyID(Guid ID);
}