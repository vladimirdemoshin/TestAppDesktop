using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace TestApp.Contract
{
    [DataContract]
    [Serializable]
    public class Item_dc
    {
        public Item_dc()
        {

        }
        public Item_dc(string itemID, string description, int price)
        {
            ItemID = itemID;
            Description = description;
            Price = price;
        }
        [DataMember]
        public string ItemID { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public int Price { get; set; }
    }
}
