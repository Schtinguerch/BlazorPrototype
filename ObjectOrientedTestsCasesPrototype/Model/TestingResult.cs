using System;
using System.Collections.Generic;

namespace ObjectOrientedTestsCasesPrototype.Model;

public partial class TestingResult
{
    public int ResultId { get; set; }

    public string ResultName { get; set; } = null!;

    public virtual ICollection<TestCaseRun> TestCaseRuns { get; } = new List<TestCaseRun>();
}
