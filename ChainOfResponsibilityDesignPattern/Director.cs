using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPattern
{
    // Director --> 'ConcreteHandler' Class 
   public class Director : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000.0)
            {
                Console.WriteLine($"{this.GetType().Name} approved Request # {purchase.Number}");
            }
            else
            {
                // we pass the request to the successor 
                // and invoke the ProcessRequest Method again 
                // Recursive method : call itself so many times until being satisfied
                _successor?.ProcessRequest(purchase);
            }
        }
    }
}
