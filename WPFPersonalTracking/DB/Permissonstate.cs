using System;
using System.Collections.Generic;

namespace WPFPersonalTracking.DB;

public partial class Permissonstate
{
    public int Id { get; set; }

    public string PermissionState { get; set; } = null!;

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();
}
