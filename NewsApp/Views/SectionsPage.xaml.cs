using NewsApp.Services;
using NewsApp.ViewModels;

namespace NewsApp.Views;

public partial class SectionsPage : ContentPage
{
	public SectionsPage(INewsService news)
	{
		InitializeComponent();
		this.BindingContext = new SectionsViewModel(news);
	}
}