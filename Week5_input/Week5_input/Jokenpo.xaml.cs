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
    public partial class Jokenpo : ContentPage
    {
        string[] images = {"stone", "paper", "scissor"};
        public Jokenpo()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Random myRandom = new Random();
            int machineOption = myRandom.Next(0, 3);
            MachineButton.ImageSource = images[machineOption]+".png";
            if(btn.Text != images[machineOption])
            {
                if(btn.Text == "stone")
                {
                    if (images[machineOption] == "scissor")
                    {
                        BarPlayer.Progress += 0.1;
                    }
                    else
                    {
                        BarMachine.Progress += 0.1;
                    }
                }else if(btn.Text == "scissor")
                {
                    if(images[machineOption] == "stone")
                    {
                        BarMachine.Progress += 0.1;
                    }
                    else
                    {
                        BarPlayer.Progress += 0.1;
                    }
                }
                else
                {
                    BarMachine.Progress += 0.1;
                }
            }
            if(BarMachine.Progress == 1)
            {
                Win.Text = "Machine Wins";

            }
            else if(BarPlayer.Progress ==1)
            {
                Win.Text = "Player Wins";
            }

        }
    }
}