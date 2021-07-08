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

            //add a customer
            var newCust = new Customer()
            {
                id = 0,
                Name = "meijer",
                State = "MN",
                Sales = 100000,
                Active = true
            };
            var rc = custCtrl.Add(newCust);
            

            // Get customer by Id
            var cust = custCtrl.GetByID(1);
            Console.WriteLine(cust.id + cust.Name + cust.Sales + cust.State);

           //update a customer
            cust.Sales = 99999;
            var rc1 = custCtrl.Update(cust);
            Console.WriteLine(cust.id + cust.Name + cust.Sales + cust.State);


            // Get All customers
            var customers = custCtrl.GetAll();
            foreach (var c in customers)
            {
                Console.WriteLine(c.id + c.Name + c.Sales + c.State);
            }
            //add an order
            var ordCtrl = new OrdersController();
            var newOrd = new Order()
            {
                Id = 0,
                Date = new DateTime(2021, 12, 2),
                Description = "Need stuff - test3",
                CustomerId = 5,
            };
            var od = ordCtrl.Add(newOrd);


            // Get order by Id
            var ord = ordCtrl.GetByID(1);
            Console.WriteLine(ord.Id +" "+ ord.Date + ord.Description + ord.CustomerId);

            //update a order
            ord.Description = "test 3";
            var ord1 = ordCtrl.Update(ord);
            Console.WriteLine(ord.Id + " " + ord.Date + ord.Description + ord.CustomerId);


            // Get All customers
            var orders = ordCtrl.GetAll();
            foreach (var o in orders)
            {
                Console.WriteLine(o.Id + ""  + o.Date + o.Description+ o.CustomerId);
            }

        }
    }
}
