﻿using System;
using System.Collections.Generic;

namespace TechVerse.Core.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Brand { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Img { get; set; } = null!;

    public int BasePrice { get; set; }

    public string Label { get; set; } = null!;

    public int Quantity { get; set; }

    public int CategoryId { get; set; }

    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<ProductVariant> ProductVariants { get; set; } = new List<ProductVariant>();
}
