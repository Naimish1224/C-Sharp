using System;

namespace ControlStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Control Statements!");

            int nbr = 5;

            switch (nbr)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                default:
                    break;
            }



            Console.WriteLine("Bye");
        }
    }
}