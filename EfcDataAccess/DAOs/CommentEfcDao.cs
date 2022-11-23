using Application.DaoInterfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Shared.Models;

namespace EfcDataAccess.DAOs;

public class CommentEfcDao : ICommentDao
{
    private readonly PostContext context;

    public CommentEfcDao(PostContext context)
    {
        this.context = context;
    }

    public async Task<Comment> CreateAsync(Comment comment)
    {
        EntityEntry<Comment> newComment = await context.Comments.AddAsync(comment);
        await context.SaveChangesAsync();
        return newComment.Entity;
    }

    public async Task<IEnumerable<Comment?>> GetAsync()
    {
        IEnumerable<Comment> comments = context.Comments.AsEnumerable();
        return await Task.FromResult(comments);
    }

    public async Task<IEnumerable<Comment?>> GetByPostAsync(int postId)
    {
        Comment? existing = await context.Comments.FirstOrDefaultAsync(u =>
            u.PostId  == postId);
        List<Comment> comments = new List<Comment>();
        comments.Add(existing);
        return comments;
    }
}