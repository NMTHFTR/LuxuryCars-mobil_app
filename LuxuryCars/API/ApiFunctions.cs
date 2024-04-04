using LuxuryCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuxuryCars.API
{
    public static class ApiFunctions
    {
        public static List<Car> GetCars()
        {
            List<Car> carList = new List<Car>();
            Parallel.Invoke(() =>
            {
                string url = "https://bgs.jedlik.eu/luxurycars/luxurycars/api/carsAll";
                carList = HTTPConnection<List<Car>>.Get(url).Result;
            });
            return carList;
        }

        public static Car GetSpecifiedCar(int id)
        {
            Car car = new Car();
            Parallel.Invoke(() =>
            {
                string ulr = $"https://bgs.jedlik.eu/luxurycars/luxurycars/api/cars/{id}";
                car = HTTPConnection<Car>.Get(ulr).Result;
            });
            return car;
        }

    }
}
