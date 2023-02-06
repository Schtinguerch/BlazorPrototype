using System;
using System.Collections.Generic;

namespace ObjectOrientedTestsCasesPrototype.Model;

public partial class TestCaseRun
{
    public int RunId { get; set; }

    public string CheckText { get; set; } = null!;

    public string ExpectedResult { get; set; } = null!;

    public string? Comment { get; set; }

    public int TypeId { get; set; }

    public int ResultId { get; set; }

    public int TestRunId { get; set; }

    public string? RunComment { get; set; }

    public string? TicketUrl { get; set; }

    public virtual TestingResult Result { get; set; } = null!;

    public virtual TestMapRun TestRun { get; set; } = null!;

    public virtual TestingType Type { get; set; } = null!;
}
