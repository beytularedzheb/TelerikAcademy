using System;

namespace _06.DeclareBoolVarGender
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isFemale = false;
            char gender = 'x';

            try
            {
                while (gender != 'm' && gender != 'f')
                {
                    Console.WriteLine("Please enter your gender (m/f):");
                    gender = char.Parse(Console.ReadLine());
                    gender = Char.ToLower(gender);
                }

                if (gender == 'm')
                    isFemale = false;
                else if (gender == 'f')
                    isFemale = true;

                Console.WriteLine("isFemale = {0}", isFemale);
            }
            catch
            {
                Console.WriteLine("This is not character!");
            }
        }
    }
}
