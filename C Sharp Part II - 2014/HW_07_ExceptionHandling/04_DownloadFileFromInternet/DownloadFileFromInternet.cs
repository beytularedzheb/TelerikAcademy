using System;
using System.IO;
using System.Net;

public class DownloadFileFromInternet
{
    public static void Main()
    {
        WebClient client = new WebClient();

        try 
        {
            Console.WriteLine("Downloading...");

            client.DownloadFile(
                "http://vladislavdd.files.wordpress.com/2013/01/hello_world.jpg", 
                "helloword.jpg");

            Console.Clear();
            Console.WriteLine("The file been downloaded and saved in current directory:");
            Console.WriteLine(Directory.GetCurrentDirectory());
        }
        catch (WebException webex)
        {
            Console.Error.WriteLine(webex.Message);
        }
        catch (ArgumentNullException)
        {
            Console.Error.WriteLine("This is not a internet address!");
        }
        catch (ArgumentException)
        {
            Console.Error.WriteLine("Invalid internet address");
        }
        catch (UnauthorizedAccessException)
        {
            Console.Error.WriteLine(
                "You do not have the required permission for write in this directory!");
        }
        catch (NotSupportedException notsupex)
        {
            Console.Error.WriteLine(notsupex.Message);
        }
        finally
        {
            client.Dispose();
        }
    }
}