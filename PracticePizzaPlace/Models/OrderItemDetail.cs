using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticePizzaPlace.Models
{
    public enum OrderItemDetailType
    {
        Size,
        Flavor,
        Topping,
        Sauce,
        Cheese,
        Crust

    }

    public class OrderItemDetail
    {
        public int ID { get; set; }
        public OrderItemDetailType Type { get; set; }

        //public InventoryItem Item { get; set; }

    }
}
