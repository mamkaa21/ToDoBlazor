using System;
using System.Collections.Generic;

namespace ToDoBlazor.DB;

public partial class Taskit
{
    public int Id { get; set; }

    public string Title { get; set; } = "";

    public bool IsCompleted { get; set; }
}

