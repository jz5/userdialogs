﻿using System;
using Samples.Pages;
using Xamarin.Forms;


namespace Samples
{

    public class App : Application
    {

        public App()
        {
            this.MainPage = new NavigationPage(new MasterDetailPage
            {
                Master = new MenuPage(),
                Detail = new StandardPage()
            });
        }
    }
}
