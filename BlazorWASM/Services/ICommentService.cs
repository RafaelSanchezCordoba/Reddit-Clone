using Shared.DTOs;
using Shared.Models;

namespace HttpClients.ClientInterfaces;

public interface ICommentService
{
    Task CreateAsync(CommentCreationDto dto);
    public Task<ICollection<Comment?>> GetAsync();
    public Task<ICollection<Comment?>> GetByPostAsync(int postId);

}