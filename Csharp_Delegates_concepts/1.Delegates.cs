using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Delegates_concepts
{
    public delegate void KitchenSection(string order);  //delegate signature,kitchenSection is delegate type .
                                                        //delegate type -store address of a method and call it later.
    class Restaurant
    {

        // Methods that will be assigned to the delegate
        public void MainCourseSection(string order) {
            Console.WriteLine($"Main Course Chef is preparing: {order}"); // Main course sectio

        }
        // Methods that will be assigned to the delegate
        public void DessertSection(string order)
        {
            Console.WriteLine($"Dessert Chef is preparing: {order}"); // Dessert section
        }

        // Methods that will be assigned to the delegate
        public void DrinksSection(string order)
        {
            Console.WriteLine($"Drinks Section is preparing: {order}");// Drinks section


            
            }
        }
          class Customer
        {
            static void Main()
            {
                Restaurant restaurant = new Restaurant();

            // "Waiter" acts as the delegate that routes orders
            KitchenSection waiter;

            Console.WriteLine("\nCustomer places order for Main Course...");
            waiter = restaurant.MainCourseSection;
            waiter("Pasta");// Call the delegate .
                            // Here the delegate calls the MainCourseSection method and passes the order as parameter
                            // The MainCourseSection method is then executed
                            // Here waiter is a delegate that points to the MainCourseSection method

            Console.WriteLine("\nCustomer places order for Ice cream...");
            waiter = restaurant.DessertSection;
            waiter("Ice cream");


            Console.WriteLine("\nCustomer places order for Mojito...");
            waiter = restaurant.DrinksSection;
            waiter("Mojito");


        }
    }
    }