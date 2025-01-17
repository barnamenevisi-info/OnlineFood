﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Online_food.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ItemId { get; set; }
        public ICollection<CategoryToProduct> CategoryToProducts { get; set; }
        public Item Item { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
