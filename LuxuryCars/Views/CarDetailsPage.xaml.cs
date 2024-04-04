using LuxuryCars.ViewModels;

namespace LuxuryCars.Views;

public partial class CarDetailsPage : ContentPage
{
	public CarDetailsPage(CarDetailsViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}
}