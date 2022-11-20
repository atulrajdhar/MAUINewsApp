using NewsApp.Models;
using NewsApp.Services;
using NewsApp.ViewModels;

namespace NewsApp.Views;

public partial class ArticlePage : ContentPage, IQueryAttributable
{
	private INewsService _news;
	public ArticlePage(INewsService news)
	{
		_news = news;
		InitializeComponent();
	}

	public void ApplyQueryAttributes(IDictionary<string, object> query)
	{
		if (query.FirstOrDefault(a => a.Key.Equals("article")).Value is Article a)
		{
			this.BindingContext = new ArticleViewModel(_news, a);
		}
	}
}