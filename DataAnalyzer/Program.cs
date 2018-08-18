using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAnalyzer.Domain;

namespace DataAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Analyzer analyzer = new Analyzer();
            Console.WriteLine("Analysis started");
            analyzer.GatherStats();
            Console.ReadLine();
        }
    }
}
