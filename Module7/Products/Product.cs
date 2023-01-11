using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module7.Manufacturers;

namespace Module7.Products
{
    internal abstract class Product<TArticle, TManufacturer> where TManufacturer : Manufacturer, IShowInfo
    {
        public TArticle? Article { get; }
        public virtual string? Name { get;}
        public virtual string? Description { get;}
        public virtual string? Category { get;}
        public virtual decimal Price { get;}
        public TManufacturer? Manufacturer { get;}
        public Product(TArticle article, string name, string description, string category, decimal price, TManufacturer? manufacturer)
        {
            Article = article;
            Name = name;
            Description = description;
            Category = category;
            Price = price;
            Manufacturer = manufacturer;
        }

        public virtual string ShowInfo()
        {
            return $"Информация о товаре:\nназвание: {Name}\nартикул: {Article}\nописание: {Description}\nкатегория: {Category}\nцена: {Price}";
        }
    }
}
