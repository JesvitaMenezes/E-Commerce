﻿namespace Ecom.Repository.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public string ImageUrl { get; set; }
        // ... other properties ...
    }
}