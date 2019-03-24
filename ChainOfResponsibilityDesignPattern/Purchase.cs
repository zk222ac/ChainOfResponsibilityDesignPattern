using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPattern
{
   public class Purchase
   {
       public int Number { get; set; }
       public double Amount { get; set; }
       public string Purpose { get; set; }

       // Constructor 
       public Purchase(int number, double amount, string purpose)
       {
           Number = number;
           Amount = amount;
           Purpose = purpose;
       }

       public override string ToString()
       {
           return $"{nameof(Number)}: {Number}, {nameof(Amount)}: {Amount}, {nameof(Purpose)}: {Purpose}";
       }
   }
}
