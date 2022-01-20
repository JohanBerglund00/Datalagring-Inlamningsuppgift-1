using System;
using System.Collections.Generic;

namespace ErrandModel.ErrandsModels
{
    public partial class Errand
    {
        public Errand()
        {
            Contacts = new HashSet<Contact>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Status { get; set; }

        public virtual ErrandStatus StatusNavigation { get; set; } = null!;
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
