using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdditionPage : ContentPage
    {
        public AdditionPage()
        {
            InitializeComponent();
        }

        private void addButton_Clicked(object sender, EventArgs e)
        {
            decimal sum = Convert.ToDecimal(firstNumber.Text) + Convert.ToDecimal(secondNumber.Text);
            resultLabel.Text = sum.ToString();
        }

        private void returnButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}