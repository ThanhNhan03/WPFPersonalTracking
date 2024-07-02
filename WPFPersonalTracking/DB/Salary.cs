using System;
using System.Collections.Generic;

namespace WPFPersonalTracking.DB;

public partial class Salary
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public int Amount { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }

    public virtual Employee Employee { get; set; } = null!;

    public virtual Salarymonth MonthNavigation { get; set; } = null!;
}
