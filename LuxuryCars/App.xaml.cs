﻿using LuxuryCars.Models;

namespace LuxuryCars
{
    public partial class App : Application
    {
       
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
         
        }
    }

}