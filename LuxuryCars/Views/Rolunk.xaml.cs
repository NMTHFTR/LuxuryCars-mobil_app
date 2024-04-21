using LuxuryCars.ViewModels;
using Microsoft.Maui.Maps;

namespace LuxuryCars.Views;


public partial class Rolunk : ContentPage
{

    public Rolunk()
    {
        InitializeComponent();
        terkep.Pins.Add(new Microsoft.Maui.Controls.Maps.Pin()
        {
            Location = new Location(47.682362, 17.630301),
            Label = "Luxury Cars / 103-as terem"
        });
        terkep.MoveToRegion(MapSpan.FromCenterAndRadius(new Location(47.682362, 17.630301), Distance.FromKilometers(1)));
        
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