﻿using System;
using System.Collections.Generic;

namespace WPFPersonalTracking.DB;

public partial class Employee
{
    public int Id { get; set; }

    public int UserNo { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? ImagePath { get; set; }

    public int DepartmentId { get; set; }

    public int PositionId { get; set; }

    public int Salary { get; set; }

    public DateOnly? Birthday { get; set; }

    public string? Adress { get; set; }

    public bool IsAdmin { get; set; }

    public string? Password { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();

    public virtual Position Position { get; set; } = null!;

    public virtual ICollection<Salary> Salaries { get; set; } = new List<Salary>();

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
