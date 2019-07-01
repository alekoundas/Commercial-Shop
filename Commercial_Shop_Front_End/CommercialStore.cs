using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd;

namespace Commercial_Shop_Front_End
{ 
    public partial class CommercialStore : Form
    {
        BindingSource ItemsBinding = new BindingSource();
        BindingSource CartItemsBinding = new BindingSource();


        public CommercialStore()
        {
            Store store = Store.Instance;
            InitializeComponent();
            SyntheticData();
            ItemsBinding.DataSource = store.Items.Distinct().ToList();
            ItemsListBox.DataSource = ItemsBinding;

            ItemsListBox.DisplayMember = "Display";
            ItemsListBox.ValueMember = "Display";

            CartItemsBinding.DataSource = store.ShoppingCart.Distinct().ToList();
            ShoppingCartListBox.DataSource = CartItemsBinding;
            ShoppingCartListBox.DisplayMember = "Count";
            ShoppingCartListBox.ValueMember = "Count";

        }

        private void SyntheticData()
        {
            Store store = Store.Instance;
            store.Name = "Market";


            store.Vendors.Add(new Vendor("Bill", "Smith", .5));
            store.Vendors.Add(new Vendor("Bill", "Smith", .5));
            store.Vendors.Add(new Vendor("Bill", "Smith", .5));
            store.Items.Add(new Item("Coca-Cola", "Beverage", 1.10M, store.Vendors[0]));
            store.Items.Add(new Item("Fizz-Cola", "Beverage", 1.10M, store.Vendors[0]));
            store.Items.Add(new Item("Kit-Kat", "Sweet", 1.0M, store.Vendors[0]));
            store.Items.Add(new Item("NewsPaper", "Paper", 1.90M, store.Vendors[0]));
            store.Items.Add(new Item("Coca-Cola - zero", "Beverage", 1.10M, store.Vendors[0]));

        }

        private void AddToCart(object sender, EventArgs e)
        {
            //Store store = Store.Instance;

            //if (ShoppingCartListBox.Items.Contains(ItemsListBox.SelectedItem))
            //{
            //    store.ShoppingCart.Where(x => x.Title == ItemsListBox.SelectedItem.);
            //}
            Store.Instance.ShoppingCart.Add((Item)ItemsListBox.SelectedItem);

            CartItemsBinding.ResetBindings(true);
           
        }
    }
}
