using System;
using System.Collections.Generic;
using System.ComponentModel;
using Week5_input.Models;
using Week5_input.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week5_input.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}