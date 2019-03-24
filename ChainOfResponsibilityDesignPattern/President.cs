using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPattern
{
    // Concrete Handler 3
   public class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 100000.0)
            {
                Console.WriteLine($"{this.GetType().Name} approved Request # {purchase.Number}");
            }
            else
            {
                Console.WriteLine($"Request# :{purchase.Number} requires an executive meeting!");
            }
        }
    }
}
