using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TestApp.Contract
{
    [ServiceContract]
    public interface IDataAccessService
    {
        [OperationContract]
        bool AddItem(String itemID, String description, int price);

        [OperationContract]
        bool DeleteItem(String itemID);

        [OperationContract]
        Item_dc GetItem(String itemID);

        [OperationContract]
        List<Item_dc> GetItems();

        [OperationContract]
        bool CreateTransaction(List<Item_dc> basket);
    }
}
