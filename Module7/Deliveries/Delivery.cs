using Module7.Companies;

namespace Module7.Deliveries
{
    internal abstract class Delivery<TCompany> where TCompany: Company, IShowInfo
    {
        public string? Name { get; set; }
        public TCompany? Company { get; set; }
        public string? Description { get; set; }
        public Delivery(string name, TCompany company, string description)
        {
            Name = name;
            Company = company;
            Description = description;
        }
        public virtual string ShowInfoDelivery() 
        {
            return $"Информация о доставке:\nназвание: {Name}\nописание: {Description}\n" + Company?.ShowInfo(); 
        }
    }
}
