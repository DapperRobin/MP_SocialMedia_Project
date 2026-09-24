public class Post
{
    #region Properties
    public Guid Id { get; set; }
    public User Author { get; set; }
    public string Title { get; set; }
    public string TextBody { get; set; }
    public string PostImage { get; set; }
    public int PostLikes { get; set; }
    public DateTime CreatedAt { get; set; }
    public string LocationTag { get; set; }
    public List<Comment> Comments { get; set; }

    #endregion  

    #region Constructor(s)
    public Post(Guid id, User author, string title, string textBody, string postImage, int postLikes, DateTime createdAt, string locationTag)
    {
        Id = id;
        Author = author;
        Title = title;
        TextBody = textBody;
        PostImage = postImage;
        PostLikes = postLikes;
        CreatedAt = createdAt;
        LocationTag = locationTag;
        Comments = new List<Comment>();
    }

    #endregion

    #region Methods

    public void LikePost()
    {
        PostLikes++;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    #endregion
}