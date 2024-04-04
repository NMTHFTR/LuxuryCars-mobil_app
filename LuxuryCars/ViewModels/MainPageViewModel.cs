using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LuxuryCars.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LuxuryCars.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [RelayCommand]
        async void Appearing(object? parameter)
        {
            try 
            {
               
                while (true)
                {
                    Image img = (Image)parameter;
                    await img.RotateTo(9720, 50000);
                }
            } 
            catch(Exception ex)
            { 

            }
        }



       
    }
}
