using LuxuryCars.ViewModels;

namespace LuxuryCars.Views;

    public partial class MainPage : ContentPage
    {

        public MainPage(MainPageViewModel vm)
        {
            InitializeComponent();
            this.BindingContext = vm;
        }

   
}
