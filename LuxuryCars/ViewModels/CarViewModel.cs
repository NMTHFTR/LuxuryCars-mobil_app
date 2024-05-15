using LuxuryCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using System.Windows.Input;
using LuxuryCars.Models;
using LuxuryCars.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Text.Json;
using CommunityToolkit.Maui.Core.Extensions;
using LuxuryCars.API;
using LuxuryCars.Views;

namespace LuxuryCars.ViewModels
{
    public partial class CarViewModel : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Car> cars;

        [ObservableProperty]
        Car selectedCar;

        async partial void OnSelectedCarChanged(Car value)
        {
            if (SelectedCar != null)
            {
                Dictionary<string, object> navParameters = new Dictionary<string, object>()
                {
                    {"SelectedCar", SelectedCar}
                };
                await Shell.Current.GoToAsync($"{nameof(CarDetailsPage)}", true, navParameters);
            }
        }

        [RelayCommand]
        async void Appearing()
        {
            Cars = ApiFunctions.GetCars().ToObservableCollection();
            SecureStorage.SetAsync("Cars", JsonSerializer.Serialize(Cars));
        }


        
    }
}