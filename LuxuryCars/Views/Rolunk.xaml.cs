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
        try
        {
            Uri uri = new Uri("https://bgs.jedlik.eu/luxurycars/");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {
            // An unexpected error occurred. No browser may be installed on the device.
        }
    }
}