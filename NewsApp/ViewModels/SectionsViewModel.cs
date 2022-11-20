using NewsApp.Models;
using NewsApp.Services;

namespace NewsApp.ViewModels;
public class SectionsViewModel
{
	public SectionsViewModel(INewsService news)
	{
		this.Sections = news.GetCategories();
	}
    public ICollection<Category> Sections { get; set; }
}
