using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Products
{
    internal abstract class Product<TArticle> : IShowInfo
    {
        public TArticle? Article { get; }
        public virtual string? Name { get;}
        public virtual string? Description { get;}
        public virtual string? Category { get;}
        public virtual decimal Price { get;}

        public virtual void ShowInfo()
        {
            Console.WriteLine();
        }
    }
}
