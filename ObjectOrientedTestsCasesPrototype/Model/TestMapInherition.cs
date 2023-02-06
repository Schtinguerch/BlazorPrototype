using System;
using System.Collections.Generic;

namespace ObjectOrientedTestsCasesPrototype.Model;

public partial class TestMapInherition
{
    public int InheritionId { get; set; }

    public int ContainerTestMapId { get; set; }

    public int HoldedTestMapId { get; set; }

    public virtual TestMap ContainerTestMap { get; set; } = null!;

    public virtual TestMap HoldedTestMap { get; set; } = null!;
}
