using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaWithReturntypes
{

    // desingn anonymous mehtod with delegate
    // Delegate that returns a string (for order preparation messages)
    public delegate string OrderPreparation(string order);

    // Delegate that returns void (for order confirmation)
    public delegate void OrderConfirmation(string order);

    // Delegate that returns bool (to check availability)
    public delegate bool OrderAvailability(string order);


    // Define a delegate for restaurant tasks
    //delegate void RestaurantTask(string taskDetails);   //Madan has created this.


    class Program
    {
        static void Main()
        {
            //  zero
            //-------------------string---------------
            //OrderPreparation prepareOrder = delegate (string order)
            //{
            //    return $"Main Course Chef is preparing: {order}";
            //};


            OrderPreparation Lambda_prepareOrder = (string order) =>
            {
                return $"Main Course Chef is preparing: {order}";
            };

            //string coffe1Order =  prepareOrder("Coffee");
            string coffe2Order = Lambda_prepareOrder("Coffee");



            //------------------------------void----

            //OrderConfirmation confirmOrder = delegate (string order)
            //{
            //    Console.WriteLine($"Order confirmed: {order}");
            //};
            //--------------(or)---
            OrderConfirmation lambda_confirmOrder = (string order) =>
            {
                Console.WriteLine($"Order confirmed: {order}");
            };

            // confirmOrder("Coffee");
            lambda_confirmOrder("Coffee");


            //----bool property
            //OrderAvailability availbleorder = delegate (string order)     //Pasta
            // {
            //     string[] availableItems = { "Pasta", "Ice Cream", "Mojito", "Coffee" };
            //     //code .....
            //     foreach (string availableItem in availableItems)
            //     {
            //         if (availableItem == order)
            //         {
            //             return true;    // If a match is found, return true (item is available)
            //         }
            //     }
            //     return false;  // If no match is found, return false (item is not available)
            // };

            //----------------------(or)
            OrderAvailability lambda_availbleorder = (string order) =>    //Pasta
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
            };

            //bool isAvailebl =  availbleorder("coffee");
            bool isAvailebl1 = lambda_availbleorder("coffee");



            //Practive wil mek you perfect..

            //Talent without hardword is  ---->   you are nothing

        }
    }
}