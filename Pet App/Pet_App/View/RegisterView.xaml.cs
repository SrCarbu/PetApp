﻿using Pet_App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pet_App.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterView : ContentPage
    {
        private RegisterViewModel viewModel;
        public RegisterView()
        {
            InitializeComponent();
            viewModel = new RegisterViewModel();
            BindingContext = viewModel;
            viewModel.Navigation = Navigation;
        }
    }
}