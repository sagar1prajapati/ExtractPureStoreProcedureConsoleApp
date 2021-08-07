using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProcedureCompare
{
    class Program
    {
        static readonly string textFile = @"c:\users\sagar\documents\visual studio 2015\Projects\StoreProcedureCompare\StoreProcedureCompare\SP.txt";
        static void Main(string[] args)
        {
          string Procedure  = ExtractProcedure.ExtractPureProcedure(textFile);
            Console.WriteLine(Procedure);
            Console.ReadKey();
        }
    }
}
