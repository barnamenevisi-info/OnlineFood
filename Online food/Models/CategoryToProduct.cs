﻿namespace Online_food.Models
{
    public class CategoryToProduct
    {
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public Product Product { get; set; }
    }
}
