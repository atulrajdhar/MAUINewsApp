using NewsApp.Models;
using NewsApp.Services;

namespace NewsApp.ViewModels;
public class BookmarksViewModel
{
    public ICollection<Article> Articles { get; set; }
    public Command TappedCommand { get; set; }

    public BookmarksViewModel(INewsService news)
    {
        this.Articles = news.GetBookmarkedArticles();

        this.TappedCommand = new Command<Article>((article) =>
        {
            var query = new Dictionary<string, object>()
            {
                { "article", article }
            };
            Shell.Current.GoToAsync("//bookmarks/article", query);
        });            
    }
}
