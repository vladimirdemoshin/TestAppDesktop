using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TestApp.Contract
{
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface IBasketService
    {
        [OperationContract(IsInitiating = true, IsTerminating = false)]
        void AddItem(Item_dc item);

        [OperationContract(IsInitiating = true, IsTerminating = false)]
        bool RemoveItem(string item);

        [OperationContract(IsInitiating = true, IsTerminating = false)]
        List<Item_dc> GetBasket();

        [OperationContract(IsInitiating = false, IsTerminating = true)]
        void DropBasket();

        [OperationContract(IsInitiating = true, IsTerminating = false)]
        int GetTotal();
    }
}
