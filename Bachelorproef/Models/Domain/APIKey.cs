using System;
using System.Collections.Generic;
using System.Text;

namespace DataGatherer.Models.Domain
{
    class APIKey
    {
        public string Key { get; set; }
        public DateTime LastTimeCalled { get; set; }

        public APIKey(string key)
        {
            Key = key;
            LastTimeCalled = DateTime.Now.AddSeconds(-10);
        }

        public void CallKey()
        {
            LastTimeCalled = DateTime.Now;
        }
    }
}

