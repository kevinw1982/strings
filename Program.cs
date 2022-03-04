using System;

namespace strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myname = "Kevin";
            string message = "My Name is " + myname;
            string capsMessage = message.ToUpper();
            string lowMessage = message.ToLower();

            Console.WriteLine("Hello World!");
            Console.WriteLine(message);
            Console.WriteLine(capsMessage);
            Console.WriteLine(lowMessage);
            Console.Read();
        }
    }
}
