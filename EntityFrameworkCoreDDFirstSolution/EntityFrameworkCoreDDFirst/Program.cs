using EntityFrameworkCoreDDFirst.Controller;
using EntityFrameworkCoreDDFirst.Models;
using System;
using System.Linq;

namespace EntityFrameworkCoreDDFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var custCtrl = new CustomersController();

            // Get customer by Id
            var cust = custCtrl.GetByID(1);
            Console.WriteLine(cust.id + cust.Name + cust.Sales + cust.State);

           // Get All customers
            var customers = custCtrl.GetAll();
            foreach(var c in customers)
            {
                Console.WriteLine(c.id + c.Name + c.Sales+ c.State);
            }
        }
    }
}
