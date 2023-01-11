using Module7.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Deliveries
{
    internal abstract class Delivery<TCompany> where TCompany: Company
    {
        public string? Name { get; set; }
        public TCompany? Company { get; set; }
        public string? Description { get; set; }
        public abstract void ShowInfoDelivery();
    }
}
