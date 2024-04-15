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
            new CollectionItem{title="embed://911_GT3.mp4"},
        };
        CaruselView.ItemsSource = items;

    }
}