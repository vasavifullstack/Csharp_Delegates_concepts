using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//func -- input 16 upto and also as well as return type shuld be anything except void or bool

//Restaruent example 
namespace FuncNamespace
{

    // desingn anonymous mehtod with delegate
    //// Delegate that returns a string (for order preparation messages)
    //public delegate string OrderPreparation(string order);

    //// Delegate that returns void (for order confirmation)
    //public delegate void OrderConfirmation(string order);

    //// Delegate that returns bool (to check availability)
    //public delegate bool OrderAvailability(string order);


    // Define a delegate for restaurant tasks
    //delegate void RestaurantTask(string taskDetails);   //Madan has created this.
    class Program
    {
        static void Main()
        {


            //OrderPreparation Lambda_prepareOrder = (string order) =>
            //{
            //    return $"Main Course Chef is preparing: {order}";
            //};


            //Func<    (string order) =>
            //   {
            //       return $"Main Course Chef is preparing: {order}";
            //   };



            //Func<string> takeOrder = () =>
            //     {
            //         return "Main Course Chef is Preparing : Pasta";
            //     };


            //string orderName = takeOrder();   //F11  , F10 next lines
            //Console.WriteLine(orderName);


            //16
            //Func<int,string> takeOrder = (int EmpId) =>
            //{
            //    return $"Main Course Chef is Preparing : Pasta and EmpID {EmpId}";
            //};



            //string orderName = takeOrder(1);   //F11  , F10 next lines
            //Console.WriteLine(orderName);



            //Func<string, string> takeOrder = (string EmpId) =>
            //{
            //    return $"Main Course Chef is Preparing : Pasta and EmpID  : {EmpId}";
            //};


            //string details = takeOrder("BirayaniZone:101");   //F11  , F10 next lines
            //Console.WriteLine(details);



            Func<int, string, string> takeOrder = (int EmpId, string Location) =>
            {
                return $"Main Course Chef is Preparing : Pasta and EmpID  : {EmpId} , Location : {Location}";
            };


            string details = takeOrder(101, "Hyderabad");   //F11  , F10 next lines
            Console.WriteLine(details);



            // Func delegate with two input parameters and decimal output
            Func<int, string, decimal> GetPrice = (int productId, string productName) =>
            {
                return 125000.99m;
            };
            //Console.WriteLine($"Price of product (Laptop): {GetPrice(1, "Laptop")}");


            List<int> productIDs = new List<int>();
            productIDs.Add(1);
            productIDs.Add(2);
            //       1
            decimal productGetPrice1 = GetPrice(productIDs[0], "Iphone");
            Console.WriteLine(productGetPrice1);


            decimal productGetPrice2 = GetPrice(productIDs[1], "Laptop");
            Console.WriteLine(productGetPrice2);

        }

    }
}
