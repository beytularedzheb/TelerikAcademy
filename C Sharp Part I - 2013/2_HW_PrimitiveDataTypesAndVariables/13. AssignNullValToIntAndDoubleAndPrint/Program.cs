using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.AssignNullValToIntAndDoubleAndPrint
{
    class Program
    {
        static void PrintVar(int? v1, double? v2)
        {
            Console.Write("Integer: ");

            if (v1.HasValue)
                Console.WriteLine(v1);
            else
                Console.WriteLine("null");

            Console.Write("Double: ");

            if (v2.HasValue)
                Console.WriteLine(v2);
            else
                Console.WriteLine("null");

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int? iVar = null;
            double? dVar = null;
            PrintVar(iVar, dVar);

            iVar = 2;
            dVar = 5.2D;
            PrintVar(iVar, dVar);
        }
    }
}
