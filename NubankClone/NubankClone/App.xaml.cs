﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NubankClone {
    public partial class App:Application {
        public App () {
            InitializeComponent();

            MainPage = new HomeNubankClone();
        }

        protected override void OnStart () {
        }

        protected override void OnSleep () {
        }

        protected override void OnResume () {
        }
    }
}
