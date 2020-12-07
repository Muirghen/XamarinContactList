﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinContactList.Views;

namespace XamarinContactList
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PeoplePage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
