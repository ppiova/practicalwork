﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinClase02.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToolbarItemPage : ContentPage
    {
        public ToolbarItemPage()
        {
            InitializeComponent();
        }
        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPage());
        }
    }
}