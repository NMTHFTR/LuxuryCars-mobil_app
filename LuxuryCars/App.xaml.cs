using LuxuryCars.Models;

namespace LuxuryCars
{
    public partial class App : Application
    {
        public static List<Car> CarList { get; set; }
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
            //Task.Run(async () =>
            //{


            //});
            //}

            //protected override void OnStart()
            //{

            //}
        }
    }

}