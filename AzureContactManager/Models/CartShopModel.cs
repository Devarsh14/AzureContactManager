using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AzureContactManager.Models
{
    public class CartShopModel
    {
       
    }
    public class Cart
    {
        List<ShoppingCartItem> items = new List<ShoppingCartItem>();
        
        
        public IEnumerable<ShoppingCartItem> Items
        {
            get { return items; }
        }

        //methods 

    }
}