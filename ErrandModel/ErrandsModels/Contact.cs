using System;
using System.Collections.Generic;

namespace ErrandModel.ErrandsModels
{
    public partial class Contact
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Customer { get; set; }
        public int Errand { get; set; }

        public virtual Customer CustomerNavigation { get; set; } = null!;
        public virtual Errand ErrandNavigation { get; set; } = null!;
    }
}
