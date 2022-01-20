using System;
using System.Collections.Generic;

namespace ErrandModel.ErrandsModels
{
    public partial class Customer
    {
        public Customer()
        {
            Contacts = new HashSet<Contact>();
        }

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string LastName { get; set; } = null!;
        public string? Address { get; set; }
        public string? PostCode { get; set; }
        public string? City { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
