using Module7.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Manufacturers
{
    internal sealed class ClothingManufacturer<TProduct>: Manufacturer 
    {
        public List<TProduct> Products { get;}
        public ClothingManufacturer(string name, string address, string phoneNumber, string country, List<TProduct> products, string description = "Не указано", string email = "Не указан", string site = "Не указан") : base(name, address, phoneNumber, country, description, email, site)
        {
            Products = products;
        }

        public void AddProduct(TProduct product) 
        {
            Products.Add(product);
        }
    }
}
