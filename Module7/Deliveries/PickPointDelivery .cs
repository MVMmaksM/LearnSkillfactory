using Module7.Companies;

namespace Module7.Deliveries
{
    internal sealed class PickPointDelivery : Delivery<Company>
    {
        public string? AddressPickPoint { get; set; }
        public PickPointDelivery(string name, Company company, string description, string addressPickPoint) : base(name, company, description)
        {
            AddressPickPoint= addressPickPoint;
        }
        
        public override string ShowInfoDelivery()
        {
            return base.ShowInfoDelivery() + $"адрес пункта выдачи: {AddressPickPoint}";
        }
    }
}
