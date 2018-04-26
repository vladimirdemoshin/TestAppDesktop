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
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Numerics;
using System.Data;
using System.Collections;
using TestApp.Manager;
using TestApp.Contract;

namespace TestApp.Client
{
    public partial class MainWindow : Window
    {
        public static DataAccessManager Manager = new DataAccessManager();
        private BasketManager basketManager;

        public MainWindow()
        {
            InitializeComponent();
            basketManager = new BasketManager();
        }

        private void BtnAddItemClick(object sender, RoutedEventArgs e)
        {
            string itemID = TxtBoxItemID.Text;
            var item = Manager.GetItem(itemID);
            if (item == null) MessageBox.Show("No item with such ItemID in DB, please try again");
            else
            {
                basketManager.AddItem(item);
                MessageBox.Show("Item added successfully!");
            }
        }

        private void BtnOpenAdminFormClick(object sender, RoutedEventArgs e)
        {
            Admin adminForm = new Admin();
            adminForm.ShowDialog();
        }

        private void TxtBoxItemID_GotFocus(object sender, RoutedEventArgs e)
        {
            TxtBoxItemID.Text = "";
        }

        private void BtnRemoveSelectedItemClick(object sender, RoutedEventArgs e)
        {
            var selectedItemIndex = BasketItemsListView.SelectedIndex;
            if(selectedItemIndex == -1 )
            {
                MessageBox.Show("Please, select item first");
                return;
            }
            var item = (Item_dc)BasketItemsListView.Items[selectedItemIndex];
            bool isRemoved = basketManager.RemoveItem(item.ItemID);
            if (isRemoved) MessageBox.Show(String.Format("Successfully Removed Item With ItemID: {0}", item.ItemID));
            else MessageBox.Show("Failed");
        }

        private void BtnTransactionClick(object sender, RoutedEventArgs e)
        {
            int total = basketManager.GetTotal();
            if(total == 0)
            {
                MessageBox.Show("Basket is empty! Add some items first");
                return;
            }
            var basket = basketManager.GetBasket();
            basketManager.DropBasket();
            if (MainWindow.Manager.CreateTransaction(basket))
                MessageBox.Show(String.Format("Transaction successfully created! Total Price: {0}", total));
            else
                MessageBox.Show("Failed");
        }

        private void BtnRefreshBasketListViewClick(object sender, RoutedEventArgs e)
        {
            BasketItemsListView.ItemsSource = basketManager.GetBasket();
        }
    }
}
