﻿using System;
using System.Collections.Generic;

namespace WPFPersonalTracking.DB;

public partial class Taskstate
{
    public int Id { get; set; }

    public string NameState { get; set; } = null!;

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
