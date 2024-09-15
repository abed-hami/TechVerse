using System;
using System.Collections.Generic;

namespace TechVerse.Core.Models;

public partial class Payment
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int OrderId { get; set; }

    public int Amount { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public DateTime Date { get; set; }

    public string Status { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
