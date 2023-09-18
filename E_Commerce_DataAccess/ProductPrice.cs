﻿using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_DataAccess
{
    public class ProductPrice
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
        public string Publisher { get; set; }
        public double Price { get; set; }
    }
}