using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErrandModel.ErrandsModels;

namespace ErrandModel.ErrandsLogic
{
    public class CustomerLogic
    {
        private static ErrandsDatabaseContext _context = new ErrandsDatabaseContext();
        public int AddCustomer(string firstName, string lastName, string address, string postalCode, string city, string phone, string email)
        {
            Customer customer = new Customer();
            customer.FirstName = firstName;
            customer.LastName = lastName;
            customer.Address = address;
            customer.PostCode = postalCode;
            customer.City = city;
            customer.Phone = phone;
            customer.Email = email;

            _context.Add(customer);
            _context.SaveChanges();
            return customer.Id;
        }

        public int AddErrand(int customerId, string errandName, string description)
        {
            Errand errand = new Errand();
            errand.Name = errandName;
            errand.Description = description;
            errand.Status = 1;
            _context.Add(errand);
            _context.SaveChanges(true);
            int errandNumber = errand.Id;

            Contact contact = new Contact();
            contact.Date = DateTime.Now;
            contact.Customer = customerId;
            contact.Errand = errandNumber;
            _context.Add(contact);
            _context.SaveChanges();
            return errandNumber;
        }

        public List<Errand> SearchErrandByCustomer(int customerId)
        {
            var queryContacts = from contact in _context.Contacts
                               where contact.Customer == customerId
                               select contact;
            List<Contact> result = queryContacts.ToList();

            List<Errand> errandList = new List<Errand>();
            foreach(Contact contact in result)
            {
                var queryErrands = from errand in _context.Errands
                                   where errand.Id == contact.Id
                                   select errand;
                errandList.AddRange(queryErrands);
            }
            return errandList;
        }

        public List<Customer> SearchCustomerByLastName(string name)
        {
            var queryCustomers = from cust in _context.Customers
                                 where cust.LastName == name
                                 orderby cust.LastName ascending
                                 select cust;
            return queryCustomers.ToList();
        }

        public List<Customer> GetCustomers()
        {
            var rows = _context.Customers.ToList();
            return rows;
        }

        public List<Customer> SearchCustomerById(int id)
        {
            var queryCustomers = from cust in _context.Customers
                                 where cust.Id == id
                                 orderby cust.Id ascending
                                 select cust;
            return queryCustomers.ToList();
        }
    }
}
