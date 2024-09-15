using System;
using System.Collections.Generic;

namespace TechVerse.Core.Models;

public partial class GiftCard
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public int Value { get; set; }

    public DateTime ExpireyDate { get; set; }

    public string Status { get; set; } = null!;
}
