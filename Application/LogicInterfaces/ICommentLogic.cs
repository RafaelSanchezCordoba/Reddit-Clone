using Shared.DTOs;
using Shared.Models;

namespace Application.LogicInterfaces;

public interface ICommentLogic
{
    Task<Comment> CreateAsync(CommentCreationDto commentToCreate);
    public Task<IEnumerable<Comment?>> GetAsync();
    public Task<IEnumerable<Comment?>> GetByPostAsync(int postId);
}