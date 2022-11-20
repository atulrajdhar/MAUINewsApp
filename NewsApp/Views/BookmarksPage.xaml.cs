using NewsApp.Services;
using NewsApp.ViewModels;

namespace NewsApp.Views;

public partial class BookmarksPage : ContentPage
{
	public BookmarksPage(INewsService news)
	{
		InitializeComponent();
		this.BindingContext = new BookmarksViewModel(news);
	}
}