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

namespace LuxuryCars.ViewModels
{
    public partial class SearchByNameViewModel: ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Car> cars;


        private string _name;

        public string name
        {
            get { return _name; }
            set
            {
                _name = value;
                if (!string.IsNullOrEmpty(_name))
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
            List<Car> list = ApiFunctions.GetCars();
            var filteredList = from car in list
                               where car.marka_modelnev.ToLower().Contains(name.ToLower())
                               select car;
            Cars.Clear();
            Cars.ToList().ForEach(car => Cars.Add(car));
        }


    }
}
