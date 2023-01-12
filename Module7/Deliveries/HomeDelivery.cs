using Module7.Deliveries;
using Module7.Companies;

namespace Module7.Deliveries
{
    internal sealed class HomeDelivery : Delivery<Company>
    {
        public string HomeAddress { get; set; }
        public HomeDelivery(string name, Company company, string description, string homeAddress) : base(name, company, description)
        {
            HomeAddress = homeAddress;
        }

        public override string ShowInfoDelivery()
        {
           return base.ShowInfoDelivery() + $"адрес доставки: {HomeAddress}";
        }
    }
}
