using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void submitButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SuccessPage());
        }

        private void addButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdditionPage());
        }

        private void listButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListViewPage());
        }
    }
}
