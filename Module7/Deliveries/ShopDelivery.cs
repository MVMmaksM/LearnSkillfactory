using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module7.Companies;

namespace Module7.Deliveries
{
    internal sealed class ShopDelivery : Delivery<Company>
    {
        public string? AddressShop { get; set; }
        public ShopDelivery(string name, Company company, string description, string addressShop) : base(name, company, description)
        {
            AddressShop = addressShop;
        }
        public override string ShowInfoDelivery()
        {
            return base.ShowInfoDelivery() + $"адрес магазина: {AddressShop}";
        }
    }
}
