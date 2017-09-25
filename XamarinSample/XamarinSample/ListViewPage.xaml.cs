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
    public partial class ListViewPage : ContentPage
    {
        public List<String> shoppingList = new List<String>();

        public ListViewPage()
        {
            InitializeComponent();
            shoppingList = new List<string>();
        }

        private void addButton_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(newItemEntry.Text))
            {
                
            }
            else
            {
                shoppingList.Add(newItemEntry.Text);
                shoppingListListView.ItemsSource = shoppingList;
                newItemEntry.Text = "";
            }
        }

        private void clearButton_Clicked(object sender, EventArgs e)
        {
            shoppingList = new List<string>();
            shoppingListListView.ItemsSource = shoppingList;
        }

        private void Return_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}