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
                await Shell.Current.GoToAsync("localhost:");
            });



           
        }

    }

    
}
