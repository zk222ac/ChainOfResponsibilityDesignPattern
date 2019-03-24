using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            //  Setup chain of responsibility 
            Approver ronny = new Director();
            Approver bobby = new VicePresident();
            Approver ricky = new President();

            // set successor ............................
            // Ronny is going to have a Successor that is bobby
            ronny.SetSuccessor(bobby);
            // bobby , hus successor will be ricky 
            bobby.SetSuccessor(ricky);
           

            // Generate and Process Purchase Request
            Purchase pRequest = new Purchase(101, 350.00, "Assets");
            ronny.ProcessRequest(pRequest);

            pRequest = new Purchase(102, 33390.00, "Project 1 Hardware stuff");
            ronny.ProcessRequest(pRequest);

            pRequest = new Purchase(103, 144400.00, "Project 2 software stuff");
            ronny.ProcessRequest(pRequest);

            // wait for User 
            Console.ReadKey();

        }
    }
}
