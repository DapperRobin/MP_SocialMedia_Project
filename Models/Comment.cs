public class Comment
{
    #region Properties

    public Guid Id { get; set; }
    public Guid PostId { get; set; }
    public User Author { get; set; }
    public string CommentBody { get; set; }
    public DateTime CreatedAt { get; set; }

    #endregion

    #region Constructor(s)

    public Comment(Guid id, Guid postId, User author, string commentBody, DateTime createdAt)
    {
        Id = id;
        PostId = postId;
        Author = author;
        CommentBody = commentBody;
        CreatedAt = createdAt;
    }

    #endregion

}