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
    public partial class ImageButton : ContentPage
    {
        public ImageButton()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Bar1.Progress = 1;
            Bar1.ProgressColor = Color.Black;
            btn.ImageSource = "icon_about.png";



        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            myImageButton.ImageSource = "me.jpg";
        }
    }
}