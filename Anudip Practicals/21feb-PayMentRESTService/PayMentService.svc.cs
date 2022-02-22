using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PayMentRESTService
{

    public class PayMentService : IPayMentService
    {
        public void AddPayee(string Name, string City)
        {
           //write database related insert logic here.
        }
        public string PayBill(string PayId)
        {
            return "Transaction having PayId " + PayId + " is successful";
            //write database related data retrival logic here.
        }

        public void RemovePayee(string Id)
        {
            //write database related delete logic here.
        }

        public void UpdateBillPayment(string PayId, string TransId)
        {
            //write database related update logic here.
        }
    }
}
