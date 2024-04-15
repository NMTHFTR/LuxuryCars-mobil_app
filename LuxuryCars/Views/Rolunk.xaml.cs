using LuxuryCars.ViewModels;

namespace LuxuryCars.Views;


public partial class Rolunk : ContentPage
{

    public Rolunk()
    {
        InitializeComponent();
        
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("localhost:");
    }
}