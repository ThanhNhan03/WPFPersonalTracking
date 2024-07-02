using System;
using System.Collections.Generic;

namespace WPFPersonalTracking.DB;

public partial class Task
{
    public int Id { get; set; }

    public int? EmployeeId { get; set; }

    public DateOnly? TaskStartDate { get; set; }

    public DateOnly? TaskDeliveryDate { get; set; }

    public int? TaskState { get; set; }

    public string? TaskTitle { get; set; }

    public string? TaskContent { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual Taskstate? TaskStateNavigation { get; set; }
}
