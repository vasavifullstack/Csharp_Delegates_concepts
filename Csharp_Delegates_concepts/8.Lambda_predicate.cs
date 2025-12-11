using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdasWithPredicateDelegate
{
    internal class Program
    {

        //// desingn anonymous mehtod with delegate
        //// Delegate that returns a string (for order preparation messages)
        //public delegate string OrderPreparation(string order);

        //// Delegate that returns void (for order confirmation)
        //public delegate void OrderConfirmation(string order);

        //// Delegate that returns bool (to check availability)
        public delegate bool OrderAvailability(string order);



        static void Main()
        {
            ////----------------------(or)
            //_______________________ lambda_availbleorder = (string order) =>    //Pasta
            //{
            //    string[] availableItems = { "Pasta", "Ice Cream", "Mojito", "Coffee" };
            //    //code .....
            //    foreach (string availableItem in availableItems)
            //    {
            //        if (availableItem == order)
            //        {
            //            return true;    // If a match is found, return true (item is available)
            //        }
            //    }
            //    return false;  // If no match is found, return false (item is not available)
            //};

            // 1 == 1
            // if(100 == 100){
            //   .............code
            // }

            Predicate<string> isEqual = (string orderName) =>
            {
                return orderName == "pasta";
            };

            bool isPastaEqual1 = isEqual("pasta");

            bool isPastaEqual2 = isEqual("Coffee");

            Console.WriteLine(isPastaEqual1);   // true;
            Console.WriteLine(isPastaEqual2);   // false;


            List<string> employees = new List<string> { "John", "Peter", "Mery", "Doe" };  // 4 members


            Predicate<string> isEmpChecking = (string empName) =>
            {
                foreach (var employee in employees)
                {
                    if (employee == empName)
                    {
                        return true;
                    }
                }
                return false;
            };


            OrderAvailability order1 = (string empName) =>
            {
                foreach (var employee in employees)
                {
                    if (employee == empName)
                    {
                        return true;
                    }
                }
                return false;
            };

            bool isEmpThier1 = isEmpChecking("John");// true
            Console.WriteLine(isEmpThier1);
            bool isEmpThier2 = isEmpChecking("Peter");  // true
            Console.WriteLine(isEmpThier2);


            bool isEmpThier3 = isEmpChecking("Madan");  // false
            Console.WriteLine(isEmpThier3);
        }
    }
}
