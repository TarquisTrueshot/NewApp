using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NewApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0; // declare the count variable.

        // This event is called when the click me button is clicked.
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"You clicked {count} times!";
        }

        // This event is called when the reset button is clicked.
        void Handle_ResetClicked(object sender, System.EventArgs e)
        {
            count = 0;
            clickMeBtn.Text = $"Click Me!";
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
