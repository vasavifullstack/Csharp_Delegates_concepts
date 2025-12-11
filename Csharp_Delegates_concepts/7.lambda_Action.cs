using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdasWithActionDelegate
{

    // built in delegate.Action-return void.no return type
    internal class Program
    {
        //// desingn anonymous mehtod with delegate
        //// Delegate that returns a string (for order preparation messages)
        //public delegate string OrderPreparation(string order);

        //// Delegate that returns void (for order confirmation)
        //public delegate void OrderConfirmation(string order);

        //// Delegate that returns bool (to check availability)
        //public delegate bool OrderAvailability(string order);

        static void Main()
        {

            Action confirmOrder1 = () =>
            {
                Console.WriteLine($"Waiter: Order for 'Pasta' confirmed.");
            };

            confirmOrder1();



            Action<string> confirmOrder2 = (string orderName) =>
            {
                Console.WriteLine($"Waiter: Order for {orderName} confirmed.");
            };

            confirmOrder2("Coffee");


            Action<string, string> confirmOrder3 = (string orderName, string orderDetail) =>
            {
                Console.WriteLine($"Waiter: Order for {orderName} confirmed. Details: {orderDetail}");
            };
            confirmOrder3("Pasta", "Extra Cheese");


            Action<string, string, decimal> confirmOrder4 = (string orderName, string orderDetail, decimal Price) =>
            {
                Console.WriteLine($"Waiter: Order for {orderName} confirmed. Details: {orderDetail} and Price is {Price}");
            };
            confirmOrder4("Pasta", "Extra Cheese", 100.99m);



            //16 paramerts

        }
    }
}
