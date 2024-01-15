using System;
using System.Collections.Generic;

namespace demopract2024_2.Model;

public partial class Manufacturer
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
