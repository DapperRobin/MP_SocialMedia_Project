public interface IApiService
{
    Task<IEnumerable<Post>> GetFeedAsync();
    Task LikePostAsync(string postId);

}