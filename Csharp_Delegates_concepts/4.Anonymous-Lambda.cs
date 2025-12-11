using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethodsToLambda
{

    //desingn anonymous mehtod with delegate
    // Delegate that returns a string (for order preparation messages)
    //public delegate string OrderPreparation(string order);

    //// Delegate that returns void (for order confirmation)
    //public delegate void OrderConfirmation(string order);

    //// Delegate that returns bool (to check availability)
    //public delegate bool OrderAvailability(string order);


    // Define a delegate for restaurant tasks
    delegate void RestaurantTask(string taskDetails);   //Madan has created this.


    class Program
    {
        static void Main()
        {

            // Anonymous method for taking orders by using lambda method =>
            //remove delegate and  replace with lambda.
            RestaurantTask takeOrder = (string orderName) =>
            {
                Console.WriteLine("Waiter: Taking order for " + orderName);
            };

            // Anonymous method for preparing food
            RestaurantTask prepareFood = (string orderName) =>
            {
                Console.WriteLine("Kitchen: Preparing " + orderName);
            };


            // Anonymous method for serving food
            RestaurantTask serveFood = (string orderName) =>
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