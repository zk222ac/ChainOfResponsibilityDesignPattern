using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPattern
{
    // The 'Handler' abstract class
    // approve a purchase request based on their title
    public abstract class Approver
    {
        protected Approver _successor;
        
        public void SetSuccessor(Approver successor)
        {
            _successor = successor;
        }
        // method stub --> abstract method without implementation
       public abstract void ProcessRequest(Purchase purchase);

    }

   
}
