using System;
using System.Collections.Generic;
using System.Text;

namespace DataGatherer.Domain
{
    class APIKey
    {
        public string Key { get; set; }
        public DateTime LastTimeCalled { get; set; }
        public DateTime LastTimeFinished { get; set; }

        public APIKey(string key)
        {
            Key = key;
            LastTimeCalled = DateTime.Now;
            LastTimeFinished = DateTime.Now;
        }
    }
}

