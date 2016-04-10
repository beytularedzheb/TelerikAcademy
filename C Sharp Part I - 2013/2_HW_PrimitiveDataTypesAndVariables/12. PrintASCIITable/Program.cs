using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.PrintASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char symbol = '\u0000'; symbol <= '\u007F'; symbol++)
            {
                if ((byte)symbol == 7)
                {
                    Console.WriteLine("{0} = bell", (byte)symbol);
                }
                else if ((byte)symbol == 0)
                {
                    Console.WriteLine("{0} = null", (byte)symbol);
                }
                else if ((byte)symbol == 32)
                {
                    Console.WriteLine("{0} = space", (byte)symbol);
                }
                else if ((byte)symbol == 8)
                {
                    Console.WriteLine("{0} = backspace", (byte)symbol);
                }
                else if ((byte)symbol == 9)
                {
                    Console.WriteLine("{0} = horizontal tab", (byte)symbol);
                }
                else if ((byte)symbol == 10)
                {
                    Console.WriteLine("{0} = NL line feed, new page", (byte)symbol);
                }
                else if ((byte)symbol == 13)
                {
                    Console.WriteLine("{0} = carriage return", (byte)symbol);
                }
                else if ((byte)symbol == 127)
                {
                    Console.WriteLine("{0} = DEL", (byte)symbol);
                }
                else Console.WriteLine("{0} = {1}", (byte)symbol, symbol);       
            }
        }
    }
}
