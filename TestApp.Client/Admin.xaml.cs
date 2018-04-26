using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using TestApp.Manager;
using TestApp.Contract;

namespace TestApp.Client
{
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void BtnShowItemsClick(object sender, RoutedEventArgs e)
        {
            ItemsListView.ItemsSource = MainWindow.Manager.GetItems();
        }

        private void BtnAddItemClick(object sender, RoutedEventArgs e)
        {
            String itemID = TxtBoxItemID.Text;
            String description = TxtBoxDescription.Text;
            String priceString = TxtBoxPrice.Text;
            int price;
            bool isValid = Int32.TryParse(priceString, out price);
            if(!isValid)
            {
                MessageBox.Show("Price has to be integer, please try again");
                return;
            }
            bool isAdded = MainWindow.Manager.AddItem(itemID, description, price);
            if (isAdded)
            {
                MessageBox.Show("Item added to DB successfully!");
            }
            else
            {
                MessageBox.Show("Failed");
            }

        }

        private void BtnRemoveSelectedItemClick(object sender, RoutedEventArgs e)
        {
            var selectedItemIndex = ItemsListView.SelectedIndex;
            var item = (Item_dc)ItemsListView.Items[selectedItemIndex];
            bool isRemoved = MainWindow.Manager.DeleteItem(item.ItemID);
            if (isRemoved) MessageBox.Show(String.Format("Successfully Delete From DB Item With ItemID: {0}", item.ItemID));
            else MessageBox.Show("Failed");
        }

        private void TxtBoxItemID_GotFocus(object sender, RoutedEventArgs e)
        {
            TxtBoxItemID.Text = "";
        }

        private void TxtBoxDescription_GotFocus(object sender, RoutedEventArgs e)
        {
            TxtBoxDescription.Text = "";
        }

        private void TxtBoxPrice_GotFocus(object sender, RoutedEventArgs e)
        {
            TxtBoxPrice.Text = "";
        }
    }
}
