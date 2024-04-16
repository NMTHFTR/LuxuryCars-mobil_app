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
            new CollectionItem{title="https://s1.cdn.autoevolution.com/images/gallery/BENTLEY-Continental-GTC-6460_13.jpg"},
            new CollectionItem{title="https://s1.cdn.autoevolution.com/images/gallery/ROLLS-ROYCE-Wraith-4791_29.jpg"},
            new CollectionItem{title="https://s1.cdn.autoevolution.com/images/gallery/NISSAN-GT-R-5603_18.jpg"},
            new CollectionItem{title="https://s1.cdn.autoevolution.com/images/gallery/BUGATTI-Chiron-5583_35.jpg"},
            new CollectionItem{title="https://s1.cdn.autoevolution.com/images/gallery/DODGE-Challenger-SRT-Demon-5978_19.jpg"},
        };
        CaruselView.ItemsSource = items;
        
    }
}