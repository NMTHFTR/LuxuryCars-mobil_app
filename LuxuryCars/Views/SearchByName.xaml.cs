using LuxuryCars.ViewModels;
namespace LuxuryCars.Views;

public partial class SearchByName : ContentPage
{
	public SearchByName(SearchByNameViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}
}