using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    //Sigleton Pattern
    public class Store
    {
        public string Name { get; set; }
        public List<Vendor> Vendors { get; set; } = new List<Vendor>();
        public List<Item> Items { get; set; } = new List<Item>();
        public List<Item> ShoppingCart { get; set; } = new List<Item>();

        public static readonly Store Instance = new Store();

        //Constuctor    
        private Store(){}
    }
}
