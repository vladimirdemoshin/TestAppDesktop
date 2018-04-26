using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using TestApp.Contract;

namespace TestApp.Service
{
    public class BasketService : IBasketService
    {
        private List<Item_dc> basket;

        public BasketService()
        {
            basket = new List<Item_dc>();
        }

        public void AddItem(Item_dc item)
        {
            basket.Add(item);
        }

        public bool RemoveItem(String itemID)
        {
            for(int i=basket.Count-1;i>=0;i--)
                if(basket[i].ItemID == itemID)
                {
                    basket.RemoveAt(i);
                    return true;
                }
            return false;
        }

        public List<Item_dc> GetBasket()
        {
            return basket;
        }

        public void DropBasket()
        {
        }

        public int GetTotal()
        {
            int total = 0;
            foreach (var item in basket)
                total += item.Price;
            return total;
        }

    }
}
