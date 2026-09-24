using SMP_MP.Models;

public class User
{
    #region Properties
    public Guid Id { get; set; }
    public string Username { get; set; }
    public string ProfilePicture { get; set; }
    public string ProfileDescription { get; set; }
    public List<Post> Posts { get; set; }
    public List<FriendRequest> SentFriendRequests { get; set; }
    public List<FriendRequest> ReceivedFriendRequests { get; set; }

    #endregion

    #region Constructor(s)

    public User(Guid id, string username, string profilePicture, string profileDescription, List<Post> posts, List<FriendRequest> sentFriendRequests, List<FriendRequest> receivedFriendRequests)
    {
        Id = id;
        Username = username;
        ProfilePicture = profilePicture;
        ProfileDescription = profileDescription;
        Posts = posts;
        SentFriendRequests = sentFriendRequests;
        ReceivedFriendRequests = receivedFriendRequests;
    }

    #endregion

    #region Methods

    public void Register()
    {
        throw new NotImplementedException();
    }

    public void Login()
    {
        throw new NotImplementedException();
    }

    public void Logout()
    {
        throw new NotImplementedException();
    }

    public void UpdateProfile()
    {
        throw new NotImplementedException();
    }

    public void SendFriendRequest(User recipient)
    {
        throw new NotImplementedException();
    }

    public void AcceptFriendRequest(FriendRequest request)
    {
        throw new NotImplementedException();
    }

    public void RejectFriendRequest(FriendRequest request)
    {
        throw new NotImplementedException();
    }

    public void RemoveFriend(User friend)
    {
        throw new NotImplementedException();
    }

    #endregion

}