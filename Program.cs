using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyConcepts
{
    class Program
    {
        static void Main(string[] args)
        {

            //
            ListOfLists.TestRun();

            //RealTime Recursion Example
            RealTimeRecursion.FindFiles(@"C:\Website\IECWebsiteMaintenance");

            //Recursion
            Console.WriteLine("EnterNumber");
            int number = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("factorial is " + Recursion.Factorial(number).ToString());
            //4! = 4 * (4-1) * (4-2) * (4-3)
            Console.WriteLine("Recursive factorial is " + Recursion.FactorialWithRecursion(number));

            //Method Overloading 
            MethodOverloading calculator = new MethodOverloading();
            Console.WriteLine("Method Overlaoding");
            Console.WriteLine(calculator.add(10, 20));
            Console.WriteLine(calculator.add(10, 20, 30));
            Console.WriteLine(calculator.add(10f, 20f, 30f));
            Console.WriteLine(calculator.add(10f, 20f, 30f, 40f));

            Console.WriteLine("Enter string to reverse > ");
            string mystring = Console.ReadLine();
            Console.WriteLine(mystring.ToReverseString());
            Console.WriteLine(mystring.ToReverseStringUsingStack());
            Console.WriteLine(mystring.ToReverseStringManual());


            Console.ReadLine();


        }
    }
}
