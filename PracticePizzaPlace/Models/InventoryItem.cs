using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticePizzaPlace.Models
{
    public enum InventoryItemType
    {
        Size,
        Flavor,
        Topping,
        Sauce,
        Cheese,
        Crust

    }
    public class InventoryItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public InventoryItemType Type { get; set; }
        public int QuantityRemaining { get; set; }
        public decimal PricePerUnit { get; set; }

    }
}
