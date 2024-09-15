using System;
using System.Collections.Generic;

namespace TechVerse.Core.Models;

public partial class Coupon
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Type { get; set; } = null!;

    public int Value { get; set; }

    public DateTime ExpireyDate { get; set; }

    public int MinOrder { get; set; }

    public string Status { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
