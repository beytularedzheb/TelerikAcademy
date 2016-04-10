using System;

namespace _10.MarketingFirmEmployees
{
    public class Employees
    {
        public string firstName;
        public string familyName;
        public byte age;
        public char gender;
        public uint idNumber;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employees employe = new Employees();

            try
            {
                /* Въвеждане на данни от клавиатурата */

                Console.Write("First name: ");
                employe.firstName = Console.ReadLine();
                Console.Write("Family name: ");
                employe.familyName = Console.ReadLine();
                Console.Write("Age: ");
                employe.age = byte.Parse(Console.ReadLine());
                do
                {
                    Console.Write("Gender (m/f): ");
                    employe.gender = char.Parse(Console.ReadLine());
                    employe.gender = Char.ToLower(employe.gender);
                } while (employe.gender != 'm' && employe.gender != 'f');

                do
                {
                    Console.Write("ID number: ");
                    employe.idNumber = uint.Parse(Console.ReadLine());
                } while (employe.idNumber < 2756000 && employe.idNumber > 27569999);

                /* Извеждане на данните */

                Console.WriteLine("\n" + employe.firstName);
                Console.WriteLine(employe.familyName);
                Console.WriteLine(employe.age);
                Console.WriteLine(employe.gender);
                Console.WriteLine(employe.idNumber + "\n");
            }
            catch
            {
                Console.WriteLine("Incorrect data!");
            }
        }
    }
}
