using System;
using System.Collections.Generic;

namespace demopract2024_2.Model;

public partial class Point
{
    public int Id { get; set; }

    public int? Index { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Order1> Order1s { get; } = new List<Order1>();
}
