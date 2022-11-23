namespace Shared.Models;

public class Post
{
    public int Id { get; set; }
    public string Title { get; private set; }
    public string Body { get; set; }
    public string Owner { get; private set; }
    
    

    public Post(string owner, string title, string body)
    {
        Owner = owner;
        Title = title;
        Body = body;
    }
    
    private Post(){}
}