using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesWithReturns
{

    // Delegate that returns a string (for order preparation messages)
    public delegate string OrderPreparation(string order);

    // Delegate that returns void (for order confirmation)
    public delegate void OrderConfirmation(string order);

    // Delegate that returns bool (to check availability)
    public delegate bool OrderAvailability(string order);


    class Restaurant
    {
        // Returns preparation message as a string
        public string PrepareMainCourse(string order)
        {
            return $"Main Course Chef is preparing: {order}";
        }
        //Confirm the order      
        public void ConfirmOrder(string order)
        {
            Console.WriteLine($"Order confirmed: {order}");
        }

        // Checks if the order is available using a foreach loop
        public bool CheckOrderAvailability(string order)     //Pasta
        {
            string[] availableItems = { "Pasta", "Ice Cream", "Mojito", "Coffee" };
            //code .....
            foreach (string availableItem in availableItems)
            {
                if (availableItem == order)
                {
                    return true;    // If a match is found, return true (item is available)
                }
            }
            return false;  // If no match is found, return false (item is not available)
        }

    }

    class Program
    {
        public static void Main()
        {

            Restaurant restaurant = new Restaurant();
            //restaurant.

            //OrderPreparation preparationDelegate;
            //preparationDelegate = restaurant.PrepareMainCourse;

            // Create delegates for different tasks
            OrderPreparation preparationDelegate = restaurant.PrepareMainCourse;  // Delegate to prepare orders
            OrderConfirmation confirmationDelegate = restaurant.ConfirmOrder;  // Delegate to confirm orders
            OrderAvailability availabilityDelegate = restaurant.CheckOrderAvailability;  // Delegate to check availability

            // Customer places an order for "Pasta"
            string order = "Pasta";

            Console.WriteLine("Checking order availability...");

            bool isOrderAvailable = availabilityDelegate(order);
            if (isOrderAvailable)
            {
                //Get the Message
                string message = preparationDelegate(order);
                Console.WriteLine(message);

                //Confirm the Order
                confirmationDelegate(order);
            }



            // Customer places an order for "Pasta"
            string order1 = "Coffee";

            Console.WriteLine("\nChecking order availability...");
            bool isOrderAvailable1 = availabilityDelegate(order);
            //No coofee
            if (isOrderAvailable1)
            {
                //Get the Message
                string message = preparationDelegate(order1);
                Console.WriteLine(message);

                //Confirm the Order
                confirmationDelegate(order1);
            }
            else
            {
                Console.WriteLine($"Your order {order1} is not available....");
            }

        }
    }
}