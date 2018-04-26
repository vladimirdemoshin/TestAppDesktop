using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TestApp.Contract;

namespace TestApp.Manager
{
    public class BasketManager
    {
        BasketServiceReference.BasketServiceClient client;
        string bindingName = "WSHttpBinding_IBasketService";

        public BasketManager()
        {
            client = new BasketServiceReference.BasketServiceClient(bindingName);
        }

        public void AddItem(Item_dc item)
        {
            client.AddItem(item);
        }

        public bool RemoveItem(String itemID)
        {
            return client.RemoveItem(itemID);
        }

        public List<Item_dc> GetBasket()
        {
            var basket = client.GetBasket();
            if (basket == null) return null;
            else return client.GetBasket().ToList();
        }

        public void DropBasket()
        {
            client.DropBasket();
            client = new BasketServiceReference.BasketServiceClient(bindingName);
        }

        public int GetTotal()
        {
            return client.GetTotal();
        }

    }
}
