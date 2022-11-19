using NewsApp.Views;

namespace NewsApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("article", typeof(ArticlePage));
	}
}
