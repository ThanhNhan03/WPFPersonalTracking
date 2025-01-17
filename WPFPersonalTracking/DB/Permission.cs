﻿using System;
using System.Collections.Generic;

namespace WPFPersonalTracking.DB;

public partial class Permission
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public int UserNo { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public int PermissionState { get; set; }

    public string? Explanation { get; set; }

    public int PermissionAmount { get; set; }

    public virtual Employee Employee { get; set; } = null!;

    public virtual Permissonstate PermissionStateNavigation { get; set; } = null!;
}
