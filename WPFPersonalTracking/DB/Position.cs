﻿using System;
using System.Collections.Generic;

namespace WPFPersonalTracking.DB;

public partial class Position
{
    public int Id { get; set; }

    public string? PositionName { get; set; }

    public int DepartmentId { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}