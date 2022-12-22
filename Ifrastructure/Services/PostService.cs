public class PostService
{
  public List<Post> posts;

  public PostService()
  {
    posts = new List<Post>();
  }
  public List<Post> GetPost()
  {
    return posts;
  }
  public void AddPost(Post post)
  {
    posts.Add(post);
  }
  public void UpdatePost(Post post)
  {
    var find = posts.FirstOrDefault(x => x.Id == post.Id);
    if(find== null) {
      System.Console.WriteLine("not found");
      return;
    }
    find.Id = post.Id;
    find.Title = post.Title;
    find.Description = post.Description;
    find.voteAmount = post.voteAmount;
  }
  public void Delete(int Id)
  {
    var find = posts.FirstOrDefault(x => x.Id == Id);
    posts.Remove(find);
  }
}