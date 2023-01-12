using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module7.Deliveries;
using Module7.Companies;
using Module7.Products;
using Module7.Manufacturers;

namespace Module7.Orders
{
    internal class Order<TDelivery, TId, TProduct> 
    {
        private List<TProduct> _products;
        public DateTime DateCreate { get;}             
        public TId? ID { get;}
        public TDelivery? Delivery { get; set;}
        public Order(TDelivery delivery, List<TProduct> products, TId id)
        {
            ID = id;
            DateCreate = DateTime.Now;
            Delivery = delivery;
            _products = products;
        }

        public TProduct this[int index]
        { 
            get 
            {
                if (index>=0&&index<_products.Count)
                {
                    return _products[index];
                }
                else
                {
                    return default(TProduct);
                }
            }
            private set
            {
                if (index >= 0 && index < _products.Count)
                {
                    _products[index] = value;
                }
            }
        }
    }
}
