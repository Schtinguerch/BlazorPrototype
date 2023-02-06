using System;
using System.Collections.Generic;

namespace ObjectOrientedTestsCasesPrototype.Model;

public partial class TestCase
{
    public int CaseId { get; set; }

    public string CheckText { get; set; } = null!;

    public string ExpectedResult { get; set; } = null!;

    public string? Comment { get; set; }

    public int? OverridedCaseId { get; set; }

    public int TestMapId { get; set; }

    public int TypeId { get; set; }

    public virtual ICollection<TestCase> InverseOverridedCase { get; } = new List<TestCase>();

    public virtual TestCase? OverridedCase { get; set; }

    public virtual TestMap TestMap { get; set; } = null!;

    public virtual TestingType Type { get; set; } = null!;
}
