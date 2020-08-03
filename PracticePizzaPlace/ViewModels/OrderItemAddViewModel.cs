﻿using Microsoft.AspNetCore.Mvc.Rendering;
using PracticePizzaPlace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticePizzaPlace.ViewModels
{
    public class OrderItemAddViewModel
    {
        public OrderItemType Type { get; set; }
        public int CustomerID { get; set; }
        public int InventoryID { get; set; }
        public InventoryItemType InventoryItemType { get; set; }
        public decimal Price { get; set; }
        public List<InventoryItem> OrderItemDetails { get; set; }

        public IEnumerable<SelectListItem> InventoryList { get; set; }

        public OrderItemAddViewModel()
        {
            OrderItemDetails = new List<InventoryItem>();
            InventoryList = new List<SelectListItem>();
        }
    }
}
