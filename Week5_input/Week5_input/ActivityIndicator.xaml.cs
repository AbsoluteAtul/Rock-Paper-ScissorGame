using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week5_input
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityIndicator : ContentPage
    {
        public ActivityIndicator()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Bar1.Progress = 1;
            Bar1.ProgressColor = Color.Black;
            Bar2.ProgressTo(0.9, 5000, Easing.Linear);
            Bar3.ProgressTo(1, 5000, Easing.BounceIn);

        }
    }
}