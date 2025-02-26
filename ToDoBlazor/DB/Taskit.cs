using System;
using System.Collections.Generic;

namespace ToDoBlazor.DB;

public partial class Taskit
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public ulong IsCompleted { get; set; }
}
