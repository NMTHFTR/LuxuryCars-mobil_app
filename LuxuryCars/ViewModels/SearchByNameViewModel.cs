using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuxuryCars.Models;
using System.Windows.Input;
using LuxuryCars.API;
using CommunityToolkit.Maui.Core.Extensions;
using LuxuryCars.Views;

namespace LuxuryCars.ViewModels
{
    public partial class SearchByNameViewModel: ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Car> cars;

        [ObservableProperty]
        Car selectedCar;

        private string _name;

        public string name
        {
            get { return _name; }
            set
            {
                _name = value;
                if (!string.IsNullOrEmpty(name))
                {
                    searchCars();
                }
                else
                {
                    Cars.Clear();
                }
            }
        }

        public ICommand returnCommand { get; set; }

        public SearchByNameViewModel()
        {
            returnCommand = new Command(async () => {
                searchCars();
            });
        }

        private async void searchCars()
        {
            List<Car> list = ApiFunctions.GetCars().ToList();
            var filteredList = list.Where(x => x.marka_modelnev.ToLower().Contains(name.ToLower())).ToList();
                
           
            Cars = filteredList.ToObservableCollection<Car>();
        }


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

    }
}
