using System;
using System.Collections.Generic;

namespace demopract2024_2.Model;

public partial class Orderproduct
{
    public int Id { get; set; }

    public string Article { get; set; } = null!;

    public int? Count { get; set; }

    public int OrderProductId { get; set; }

    public virtual Product ArticleNavigation { get; set; } = null!;

    public virtual Order1 IdNavigation { get; set; } = null!;
}
