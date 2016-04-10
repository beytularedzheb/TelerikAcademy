using System;
using System.IO;
using System.Security;

public class PrintFileContent
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Please enter the full file path:");
            string path = Console.ReadLine();
            PrintContent(path);
        }
        catch (DirectoryNotFoundException)
        {
            Console.Error.WriteLine("You entered a nonexistent directory!");
        }
        catch (FileNotFoundException)
        {
            Console.Error.WriteLine("Unable to find the file!");
            Console.Error.WriteLine("Make sure you enter the correct file name.");
        }
        catch (PathTooLongException)
        {
            Console.Error.WriteLine("You entered a too long path!");
        }
        catch (ArgumentNullException)
        {
            Console.Error.WriteLine("This is not a path!");
        }
        catch (ArgumentException)
        {
            Console.Error.WriteLine("This is not a path!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.Error.WriteLine("You can not access this file!");
        }
        catch (NotSupportedException)
        {
            Console.Error.WriteLine("The path is in an invalid format!");
        }
        catch (IOException)
        {
            Console.Error.WriteLine("Error opening file!");
        }
        catch (SecurityException)
        {
            Console.Error.WriteLine("You do not have the required permission to read this file!");
        }
    }

    public static void PrintContent(string path)
    {
        Console.WriteLine(File.ReadAllText(path));
    }
}