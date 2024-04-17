using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LuxuryCars.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LuxuryCars.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [RelayCommand]
        async void forgas(object? parameter)
        {
            Image img = (Image)parameter;
            await img.RotateTo(9720, 50000);
        }

        //async void Appearing(object? parameter)
        //{

        //    try 
        //    {
               
        //        //while (true)
        //        //{
        //        //    Image img = (Image)parameter;
        //        //    await img.RotateTo(9720, 50000);
        //        //}
        //    } 
        //    catch(Exception ex)
        //    { 

        //    }
        //}

        public ICommand goToCars { get; set; }

        public MainPageViewModel()
        {
            goToCars = new Command(async () => {
                await Shell.Current.GoToAsync(nameof(CarsPage));
            });
        }

     



    }
}
