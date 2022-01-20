using System;
using System.Collections.Generic;

namespace ErrandModel.ErrandsModels
{
    public partial class ErrandStatus
    {
        public ErrandStatus()
        {
            Errands = new HashSet<Errand>();
        }

        public int Id { get; set; }
        public string Status { get; set; } = null!;

        public virtual ICollection<Errand> Errands { get; set; }
    }
}
