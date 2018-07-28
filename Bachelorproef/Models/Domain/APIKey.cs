using System;
using System.Collections.Generic;
using System.Text;

namespace DataGatherer.Domain
{
    class APIKey
    {
        string Key { get; set; }
        DateTime LastTimeCalled { get; set; }
        DateTime LastTimeFinished { get; set; }
    }
}

