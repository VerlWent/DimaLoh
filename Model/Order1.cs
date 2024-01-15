using System;
using System.Collections.Generic;

namespace demopract2024_2.Model;

public partial class Order1
{
    public int OrderId { get; set; }

    public DateOnly? OrderDate { get; set; }

    public DateOnly OrderDeliveryDate { get; set; }

    public int OrderPickupPoint { get; set; }

    public int? OrderCode { get; set; }

    public int OrderStatus { get; set; }

    public int? OrderUser { get; set; }

    public virtual Point OrderPickupPointNavigation { get; set; } = null!;

    public virtual OrderStatus OrderStatusNavigation { get; set; } = null!;

    public virtual User? OrderUserNavigation { get; set; }

    public virtual ICollection<Orderproduct> Orderproducts { get; } = new List<Orderproduct>();
}
