using NewsApp.Services;
using NewsApp.ViewModels;

namespace NewsApp.Views;

public partial class HomePage : ContentPage
{
	public HomePage(INewsService news)
	{
		InitializeComponent();
		this.BindingContext = new HomeViewModel(news);
	}
}