using System;
using System.Collections.Generic;

namespace TechVerse.Core.Models;

public partial class Cart
{
    public int Id { get; set; }

    public string Status { get; set; } = null!;

    public int UserId { get; set; }

    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    public virtual User User { get; set; } = null!;
}
