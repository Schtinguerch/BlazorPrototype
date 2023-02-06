using System;
using System.Collections.Generic;

namespace ObjectOrientedTestsCasesPrototype.Model;

public partial class TestingType
{
    public int TypeId { get; set; }

    public string TypeName { get; set; } = null!;

    public virtual ICollection<TestCaseRun> TestCaseRuns { get; } = new List<TestCaseRun>();

    public virtual ICollection<TestCase> TestCases { get; } = new List<TestCase>();
}
