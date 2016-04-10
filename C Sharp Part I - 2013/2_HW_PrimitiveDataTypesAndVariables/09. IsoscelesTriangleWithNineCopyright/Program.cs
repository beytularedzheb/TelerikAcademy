using System;

namespace _09.IsoscelesTriangleWithNineCopyright
{
    class Program
    {
        static void Main(string[] args)
        {
            char chCopyR = '\u00A9';
            Console.WriteLine("{0, 3}", chCopyR);
            Console.WriteLine("{0, 2}{0}{0}", chCopyR);
            Console.WriteLine("{0}{0}{0}{0}{0}", chCopyR);
        }
    }
}
