using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
    //desingn anonymous mehtod with delegate
    // Delegate that returns a string (for order preparation messages)
    //public delegate string OrderPreparation(string order);

    //// Delegate that returns void (for order confirmation)
    //public delegate void OrderConfirmation(string order);

    //// Delegate that returns bool (to check availability)
    //public delegate bool OrderAvailability(string order);

    // Define a delegate for restaurant tasks
    delegate void RestaurantTask(string taskDetails);


    class Program
    {
        static void Main()
        {
            // Anonymous method for taking orders.takeOrder is delegate variable.
            RestaurantTask takeOrder = delegate (string orderName)
            {
                Console.WriteLine("Waiter: Taking order for " + orderName);
            };

            RestaurantTask prepareFood = delegate (string orderName)
            {
                Console.WriteLine("Kitchen: Preparing " + orderName);
            };

            // Anonymous method for serving food
            RestaurantTask serveFood = delegate (string orderName)
            {
                Console.WriteLine("Waiter: Serving " + orderName);
            };
            string order = "Pasta";

            takeOrder(order);
            prepareFood(order);
            serveFood(order);

        }
    }
}