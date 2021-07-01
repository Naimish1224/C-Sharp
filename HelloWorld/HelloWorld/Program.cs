using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("abc");


            Console.WriteLine("Hello World!");

            String firstName = "Bob";
            string lastName = "Smith";


            int n1 = 5;
            int n2 = 7;

            int sum = n1 + n2;

            Console.WriteLine(firstName + "" + lastName);
            Console.WriteLine("sum =" + sum);

            // p47 var identifier
            var name1 = "Nick Patel";

            // single line comment
            /* multi
             line comment
            */


            // page 52
            double price1 = 25.00;

            Console.Write("Whats your name?: ");
            String name2 = Console.ReadLine();
            Console.WriteLine("Hi, my name is " + name2);

            String choice = "y";
            while (choice.Equals("y"))
            {
                Console.WriteLine("Continue?");
                choice = Console.ReadLine();


                if (sum > 10)
                {
                    Console.WriteLine(">10");
                }
                else
                {
                    Console.WriteLine("<10");
                }
            }
        }
    }
}
