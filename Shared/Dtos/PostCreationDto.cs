using Shared.Models;

namespace Shared.Dtos;

public class PostCreationDto
{
    public string OwnerUsername { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }

    public PostCreationDto(string ownerUsername, string title, string body)
    {
        OwnerUsername = ownerUsername;
        Title = title;
        Body = body;
    }
}