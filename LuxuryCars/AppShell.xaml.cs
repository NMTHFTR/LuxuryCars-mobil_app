using LuxuryCars.Views;
namespace LuxuryCars
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(CarsPage), typeof(CarsPage));
            Routing.RegisterRoute(nameof(CarDetailsPage), typeof(CarDetailsPage));
        }
    }
}