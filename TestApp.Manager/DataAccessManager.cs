using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using TestApp.DataAccess;
using TestApp.Contract;
using System.Xml.Linq;
using System.Collections.ObjectModel;


namespace TestApp.Manager
{
    public class DataAccessManager
    {
        DataAccessServiceReference.DataAccessServiceClient client;
        string bindingName = "WSHttpBinding_IDataAccessService";
        public DataAccessManager()
        {
            client = new DataAccessServiceReference.DataAccessServiceClient(bindingName);
        }

        public bool AddItem(String itemID, String description, int price)
        {
            return client.AddItem(itemID, description, price);
        }

        public bool DeleteItem(String itemID)
        {
            return client.DeleteItem(itemID);
        }

        public Item_dc GetItem(String itemID)
        {
            var item = client.GetItem(itemID);
            if (item == null) return null;
            else return new Item_dc(item.ItemID, item.Description, item.Price);
        }

        public List<Item_dc> GetItems()
        {
            var result = new List<Item_dc>();
            var items = client.GetItems();
            if (items == null) return null;
            else
            {
                foreach(var item in items)
                    result.Add(new Item_dc(item.ItemID, item.Description, item.Price));
                return result;
            }
        }

        public bool CreateTransaction(List<Item_dc> basket)
        {
            return client.CreateTransaction(basket.ToArray());
        }
               
    }
}
