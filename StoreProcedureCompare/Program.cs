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
        static readonly string textFileV1 = @"c:\users\sagar\documents\visual studio 2015\Projects\StoreProcedureCompare\StoreProcedureCompare\SP_V1.txt";
        static void Main(string[] args)
        {
          string Procedure  = ExtractProcedure.ExtractPureProcedure(textFile);
          string Procedure2 = ExtractProcedure.ExtractPureProcedure(textFileV1);

            if (String.Equals(Procedure, Procedure2))
            {
                Console.WriteLine("Procedures are Same");
            }else
            {
                Console.WriteLine("Differance Found");
            }

                //Console.WriteLine(Procedure);
            Console.ReadKey();
        }
    }
}
