using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErrandModel.ErrandsModels;
using ErrandModel.ErrandsLogic;

namespace Datalagring_Inlamningsuppgift_1.Views
{
    internal class ErrandView
    {
        public string Name { get; }
        public string Description { get; }
        public string Created { get; }
        public string LastChanged { get; }
        public string Status { get; }
        public string Number { get; }
        public string CustomerId { get; }

        public ErrandView(Errand errand)
        {
            CustomerLogic customerLogic = new CustomerLogic();
            Name = errand.Name;
            Description = errand.Description;
            Number = errand.Id.ToString();
            errand.Contacts.OrderBy(x => x.Date);
            Created = errand.Contacts.First().Date.ToString();
            CustomerId = errand.Contacts.First().Customer.ToString();
            LastChanged = errand.Contacts.Last().Date.ToString();
            List<ErrandStatus> statusList = customerLogic.GetStatuses();
            ErrandStatus statusItem = new ErrandStatus();
            if (statusList.Exists(x => x.Id == errand.Status))
            {
                statusItem = statusList.Find(x => x.Id.Equals(errand.Status));
                if (statusItem != null)
                { 
                    Status = statusItem.Status;
                }
                
            }
        }
    }
}
