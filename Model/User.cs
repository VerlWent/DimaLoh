using System;
using System.Collections.Generic;

namespace demopract2024_2.Model;

public partial class User
{
    public int UserId { get; set; }

    public string UserSurname { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string UserPatronymic { get; set; } = null!;

    public string UserLogin { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public int UserRole { get; set; }

    public virtual ICollection<Order1> Order1s { get; } = new List<Order1>();

    public virtual Role UserRoleNavigation { get; set; } = null!;
}
