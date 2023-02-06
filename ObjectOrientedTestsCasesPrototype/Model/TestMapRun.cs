using System;
using System.Collections.Generic;

namespace ObjectOrientedTestsCasesPrototype.Model;

public partial class TestMapRun
{
    public int RunId { get; set; }

    public string RunName { get; set; } = null!;

    public string? Comment { get; set; }

    public int RunOrderNumber { get; set; }

    public virtual ICollection<TestCaseRun> TestCaseRuns { get; } = new List<TestCaseRun>();
}
