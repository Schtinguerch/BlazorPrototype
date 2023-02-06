using System;
using System.Collections.Generic;

namespace ObjectOrientedTestsCasesPrototype.Model;

public partial class TestMap
{
    public int MapId { get; set; }

    public string MapName { get; set; } = null!;

    public string? Comment { get; set; }

    public int MapVersion { get; set; }

    public virtual ICollection<TestCase> TestCases { get; } = new List<TestCase>();

    public virtual ICollection<TestMapInherition> TestMapInheritionContainerTestMaps { get; } = new List<TestMapInherition>();

    public virtual ICollection<TestMapInherition> TestMapInheritionHoldedTestMaps { get; } = new List<TestMapInherition>();
}
