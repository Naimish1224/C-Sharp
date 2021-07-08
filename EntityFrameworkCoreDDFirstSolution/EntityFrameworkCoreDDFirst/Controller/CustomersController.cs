using EntityFrameworkCoreDDFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameworkCoreDDFirst.Controller
{
    public class CustomersController
    {
        readonly AppDbContext _context;

        public List<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public Customer GetByID(int id)
        {
            return _context.Customers.Find(id);
        }
        public CustomersController()
        {
            _context = new AppDbContext();
        }


    }
}
