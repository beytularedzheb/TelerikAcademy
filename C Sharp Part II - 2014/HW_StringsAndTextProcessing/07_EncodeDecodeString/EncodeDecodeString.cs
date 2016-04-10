using System;
using System.Text;

class EncodeDecodeString
{
    static void Main()
    {
        string message = Console.ReadLine();
        string cipher = Console.ReadLine();

        if (message != null && cipher != null)
        {
            string encoded = Encode(message, cipher);
            Console.WriteLine(encoded);
            Console.WriteLine(Decode(encoded, cipher));
        }
    }

    static string Encode(string str, string cipher)
    {
        StringBuilder encoded = new StringBuilder(str.Length);

        for (int i = 0; i < str.Length; i++)
        {
            encoded.Append((char)(str[i] ^ cipher[i % cipher.Length]));
        }

        return encoded.ToString();
    }

    static string Decode(string str, string cipher)
    {
        return Encode(str, cipher);
    }
}