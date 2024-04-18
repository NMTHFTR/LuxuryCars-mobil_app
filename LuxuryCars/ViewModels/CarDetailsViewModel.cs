using CommunityToolkit.Mvvm.ComponentModel;
using LuxuryCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LuxuryCars.ViewModels
{
    [QueryProperty(nameof(SelectedCar),"SelectedCar")]
    public partial class CarDetailsViewModel : ObservableObject
    {
        [ObservableProperty]
        Car selectedCar;


        public ICommand goToCars { get; set; }

        public CarDetailsViewModel()
        {
            goToCars = new Command(async () => {
                try
                {
                    Uri uri = new Uri("https://bgs.jedlik.eu/luxurycars/car");
                    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
                }
                catch (Exception ex)
                {
                    // An unexpected error occurred. No browser may be installed on the device.
                }
            });



           
        }

    }

    
}
