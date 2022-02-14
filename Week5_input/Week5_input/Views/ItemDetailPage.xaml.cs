using System.ComponentModel;
using Week5_input.ViewModels;
using Xamarin.Forms;

namespace Week5_input.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}