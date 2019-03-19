using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Extreme_TicTacToe
{
    public  partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int a = 0; 
        public void Handle_Clicked(object sender, System.EventArgs e)
        {
            a++;
            ((Button)sender).Text = $"your sukas level {a}"; 
        }
    }
}
