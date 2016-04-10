using System;
using System.Globalization;
using System.Text.RegularExpressions;

class EctractDates
{
    static void Main()
    {
        string text = "Birthday: 15.07.1991, New Year:31.12.2013, Valentine\'s day: 45.02.2014";
        Console.WriteLine(text);
        DateTime date;

        foreach (var item in Regex.Matches(text, @"\b\d{2}\.\d{2}\.\d{4}\b"))
        {
            if (DateTime.TryParseExact(item.ToString(), "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            }
        }
    }
}