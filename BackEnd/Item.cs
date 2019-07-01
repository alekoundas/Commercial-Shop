using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class Item
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Sold { get; set; } = false;
        public bool PaymentDistributed { get; set; } = false;


        //Reflection For Output Shopping Cart Count
        public string Count
        {
            get
            {
                                                                            // From Sigleton Pattern \\
                return String.Format($"{Title}    -    ${Price}       x" + (Store.Instance.ShoppingCart.Where(x=>x.Title==Title).Count()));
            }
        }

        //Reflection For Output Items
        public string Display
        {
            get
            {
                return String.Format($"{Title}    -    ${Price}");
            }
        }


        public Vendor Owner { get; set; }

        public Item(string title, string desc, decimal price, Vendor owner)
        {
            Title = title;
            Description = desc;
            Price = price;
            Owner = owner;
        }
    }
}
