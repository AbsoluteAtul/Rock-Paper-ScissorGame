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
    public partial class Editor : ContentPage
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            myLabel.Text = myEntry.Text.ToUpper();
        }
    }
}