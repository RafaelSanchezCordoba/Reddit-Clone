using Shared.Dtos;
using Shared.Models;

namespace HttpClients.ClientInterfaces;

public interface IPostService
{
    Task CreateAsync(PostCreationDto dto); 
    Task<ICollection<Post>> GetAsync(
        string? userName,
        string? titleContains
    );
    
    Task<PostBasicDto> GetByIdAsync(int id);
    Task DeleteAsync(int id);
}