﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XamForms.DesktopSample.Core
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
    }
}
