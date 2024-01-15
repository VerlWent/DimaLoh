using System;
using System.Collections.Generic;

namespace demopract2024_2.Model;

public partial class OrderStatus
{
    public int Id { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<Order1> Order1s { get; } = new List<Order1>();
}
