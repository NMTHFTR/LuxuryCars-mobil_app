using LuxuryCars.ViewModels;

namespace LuxuryCars.Views;

public partial class CarsPage : ContentPage
{
	public CarsPage(CarViewModel vm)
	{
		InitializeComponent();
        this.BindingContext = vm;
    }
}