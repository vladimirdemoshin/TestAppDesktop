using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using TestApp.Contract;
using TestApp.DataAccess;

namespace TestApp.Service
{
    public class DataAccessService : IDataAccessService
    {
        DataAccessRepository Repository = new DataAccessRepository();

        public bool AddItem(String itemID, String description, int price)
        {
            return Repository.AddItem(itemID,description,price);
        }

        public bool DeleteItem(String itemID)
        {
            return Repository.DeleteItem(itemID);
        }

        public Item_dc GetItem(String itemID)
        {
            var items = Repository.GetItems();
            foreach(var item in items)
                if (item.ItemID == itemID) return new Item_dc(item.ItemID, item.Description, item.Price);
            return null;
        }

        public List<Item_dc> GetItems()
        {
            var result = new List<Item_dc>();
            var items = Repository.GetItems();
            foreach (var item in items)
                result.Add(new Item_dc(item.ItemID, item.Description, item.Price));
            if(result.Count == 0) return null;
            return result;
        }

        public bool CreateTransaction(List<Item_dc> basket)
        {
            return Repository.CreateTransaction(basket);
        }
    }
}
