using System;

class Company
{
    // представката 'c' пред променливите е за Company,
    // a 'm' - Manager

    // Company
    static string cName;
    static string cAddress;
    static ulong cPhoneNum;
    static ulong cFaxNum;
    static string cWebSite;

    // Manager
    static string mFirstName;
    static string mLastName;
    static ulong mPhoneNum;
    static ulong mAge; 
     
    // Възрастта (mAge) е от тип ulong, защото искам да мога
    // да я валидирам чрез функцията Validate(). Иначе е по-добре 
    // примерно да е от тип byte.

    static void Main(string[] args)
    {      
        SetCompanyInfo();
        SetManagerInfo();

        Console.WriteLine("Please press ENTER to see all the information.");
        Console.ReadLine();
        Console.Clear();

        PrintAllInfo();
    }

    static void SetCompanyInfo()
    {
        Console.WriteLine("Please enter company's information.");
        Console.WriteLine();

        Console.Write("Name: ");
        cName = Console.ReadLine();

        Console.Write("Address: ");
        cAddress = Console.ReadLine();

        Console.Write("Phone number: ");
        // Използвам ref, защото искам променливата да е входно-изходна
        Validate(ref cPhoneNum);

        Console.Write("Fax number: ");
        Validate(ref cFaxNum);

        Console.Write("Web site: ");
        cWebSite = Console.ReadLine();
    }

    static void SetManagerInfo()
    {
        Console.WriteLine();
        Console.WriteLine("Please enter manager's information.");
        Console.WriteLine();

        Console.Write("First name: ");
        mFirstName = Console.ReadLine();

        Console.Write("Last name: ");
        mLastName = Console.ReadLine();

        Console.Write("Age: ");
        Validate(ref mAge);

        Console.Write("Phone number: ");
        Validate(ref mPhoneNum);
    }

    static void Validate(ref ulong someVar)
    {
        do
        {
            if (ulong.TryParse(Console.ReadLine(), out someVar))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid number.. Please try again... ");
            }
        }
        while (someVar <= 0);
    }

    static void PrintAllInfo()
    {
        Console.WriteLine("Information about the company.");
        Console.WriteLine();

        Console.WriteLine("Name: {0}", cName);
        Console.WriteLine("Address: {0}", cAddress);
        Console.WriteLine("Phone number: {0}", cPhoneNum);
        Console.WriteLine("Fax number: {0}", cFaxNum);
        Console.WriteLine("Web site: {0}", cWebSite);
        Console.WriteLine();

        Console.WriteLine("Information about company's manager.");
        Console.WriteLine();

        Console.WriteLine("Name: {0} {1}", mFirstName, mLastName);
        Console.WriteLine("Age: {0}", mAge);
        Console.WriteLine("Phone number: {0}", mPhoneNum);
    }
}

