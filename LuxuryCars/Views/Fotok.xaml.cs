using CommunityToolkit.Mvvm.ComponentModel;
using LuxuryCars.Models;
using System.Collections.ObjectModel;

namespace LuxuryCars.Views;


public partial class Fotok : ContentPage
{
    
    public Fotok()
	{
		InitializeComponent();
        
          var items=new List<CollectionItem> {
            new CollectionItem{image="https://s1.cdn.autoevolution.com/images/gallery/BENTLEY-Continental-GTC-6460_13.jpg",name = "sziszi"},
            new CollectionItem{image="https://s1.cdn.autoevolution.com/images/gallery/ROLLS-ROYCE-Wraith-4791_29.jpg", name = "akukas"},
            new CollectionItem{image="https://s1.cdn.autoevolution.com/images/gallery/NISSAN-GT-R-5603_18.jpg", name = "aaa"},
            new CollectionItem{image="https://s1.cdn.autoevolution.com/images/gallery/BUGATTI-Chiron-5583_35.jpg", name = "stb"},
            new CollectionItem{image="https://s1.cdn.autoevolution.com/images/gallery/DODGE-Challenger-SRT-Demon-5978_19.jpg",name="idk"},
        };
        CaruselView.ItemsSource = items;


        var items2 = new List<CollectionItem> {
            new CollectionItem{image="embed://911_GT3.mp4",name = "sziszi"},
            new CollectionItem{image="embed://Ferrari_488_GTB.mp4", name = "akukas"},
            new CollectionItem{image="embed://Lamborghini.mp4", name = "aaaa"},
            new CollectionItem{image="embed://M8.mp4", name = "stb"},
        };
        //CaruselView2.ItemsSource = items;

    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://bgs.jedlik.eu/luxurycars/car");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {
            // An unexpected error occurred. No browser may be installed on the device.
        }
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(CarsPage));
    }

    
}