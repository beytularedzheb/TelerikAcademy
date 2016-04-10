using System;

namespace _14.ExchangeBits_Bonus
{
    class ExchangeBitsBonus
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter an unsigned integer number: ");
                uint uintVar = uint.Parse(Console.ReadLine());

                Console.Write("Please enter an positive number (0 - 31) P = ? ");
                byte p = byte.Parse(Console.ReadLine());

                Console.Write("Please enter an positive number (0 - 31) Q = ? ");
                byte q = byte.Parse(Console.ReadLine());

                // Броят на битовете N, които могат бъдат разменени може да е най-много 
                // N = 32 минус най-лявата зададена позиция, т.е p - ako e по-голям от q и 
                // q - ако q е по-голям от p. Ако са равни няма значение кой ще се избере.
                // ИЛИ (ако р е по-голям от q => N1 = p-q, в противен случай K1 = q-p)
                // N = N < N1 ? N : N1

                byte bigger = (byte)(p >= q ? p - q : q - p);

                byte n = (byte)(p >= q ? 32 - p : 32 - q);
                n = (byte)(n < bigger ? n : bigger);

                byte k;

                do
                {
                    Console.Write("How many bits you want to change (0 - {0}) K = ? ", n);
                    k = byte.Parse(Console.ReadLine());
                }
                while(k < 0 || k > n);

                uint value1, value2, mask;

                Console.WriteLine("\n" + Convert.ToString(uintVar, 2).PadLeft(32, '0'));

                k = (byte)(p + k - 1);

                while (p <= k)
                {
                    mask = (uint)(1 << p);
                    value1 = (uintVar & mask) / mask;

                    mask = (uint)(1 << q);
                    value2 = (uintVar & mask) / mask;

                    mask = (uint)(1 << q);
                    uintVar = value1 == 0 ? uintVar & ~mask : uintVar | mask;

                    mask = (uint)(1 << p);
                    uintVar = value2 == 0 ? uintVar & ~mask : uintVar | mask;

                    p++;
                    q++;
                }

                Console.WriteLine("\n" + Convert.ToString(uintVar, 2).PadLeft(32, '0') + "\n");
            }
            catch
            {
                Console.WriteLine("Incorrect data");
            }
        }
    }
}
