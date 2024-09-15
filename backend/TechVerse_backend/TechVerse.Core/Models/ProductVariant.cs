using System;
using System.Collections.Generic;

namespace TechVerse.Core.Models;

public partial class ProductVariant
{
    public int Id { get; set; }

    public string Color { get; set; } = null!;

    public string ColorValue { get; set; } = null!;

    public int Quantity { get; set; }

    public string Attribute { get; set; } = null!;

    public string AttributeValue { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string Img { get; set; } = null!;

    public int ProductId { get; set; }

    public virtual Product Product { get; set; } = null!;
}
