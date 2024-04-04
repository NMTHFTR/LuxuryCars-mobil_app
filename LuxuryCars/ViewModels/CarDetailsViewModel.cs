using CommunityToolkit.Mvvm.ComponentModel;
using LuxuryCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuxuryCars.ViewModels
{
    [QueryProperty(nameof(SelectedCar),"SelectedCar")]
    public partial class CarDetailsViewModel : ObservableObject
    {
        [ObservableProperty]
        Car selectedCar;



    }
}
