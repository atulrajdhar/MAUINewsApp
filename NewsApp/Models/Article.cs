namespace NewsApp.Models;
public class Article
{
    public Article(string id, string title, string subtitle, string imageURL, string category, string time)
    {
        Id = id;
        Title = title;
        Subtitle = subtitle;
        ImageURL = imageURL;
        Category = category;
        Time = time;
    }

    public string Id { get; }
    public string Title { get; }
    public string Subtitle { get; }
    public string ImageURL { get; }
    public string Category { get; }
    public string Time { get; }



}
