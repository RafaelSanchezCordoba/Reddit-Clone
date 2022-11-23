namespace Shared.Models;

public class Comment
{
 
    public int Id { get; set; }
    public int PostId{ get; set; }
    public string Message { get; set; }
    public User Owner { get;  set; }
    
       public Comment( User owner,int postId, string message)
        {
            PostId = postId;
            Message = message;
            Owner = owner;
        }

    private Comment(){}
    
}