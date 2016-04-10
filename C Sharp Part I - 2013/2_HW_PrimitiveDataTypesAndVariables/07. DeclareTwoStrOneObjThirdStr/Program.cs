using System;

namespace _07.DeclareTwoStrOneObjThirdStr
{
    class Program
    {
        static void Main(string[] args)
        {
            string strVar1 = "Hello";
            string strVar2 = "World";
            Object objVar = strVar1 + " " + strVar2;
            string strVar3 = (string)objVar;

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n", strVar1, strVar2, objVar, strVar3);
        }
    }
}
