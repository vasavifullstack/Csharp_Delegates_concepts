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

    //HERE delegate different return type like string,void,bool so we can three delegate for three method
    //delegate signature should be match then delegate call the method otherwise no call



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
            //create an instance to call the method
            Restaurant restaurant = new Restaurant();
            //by using delegate we can call the method


            //restaurant.
            // here delegate type delegate variable
            //OrderPreparation preparationDelegate;
            //preparationDelegate = restaurant.PrepareMainCourse;

            // Create delegates for different tasks
            // assigning the method to delegate

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
            //availabilityDelegate call the checkorderAvailability method if it is tru
            bool isOrderAvailable1 = availabilityDelegate(order);//true = true
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