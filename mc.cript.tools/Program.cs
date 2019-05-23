using System;

namespace mc.cript.tools
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("1 - Base 64 encode | 2 - Cryptographi | 0 - Close App");
            var input = Console.ReadLine();

            if (input.Equals("1"))
            {
                Console.Clear();
                Console.WriteLine("Touch string value.");
                input = Console.ReadLine();
                Console.WriteLine(Cryptographer.ToBase64(input));
            }
            else if (input.Equals("2"))
            {
                Console.Clear();
                Console.WriteLine("Criptographer Method.");
                Console.WriteLine("Touch password.");
                var password = Console.ReadLine();
                Console.WriteLine("Touch text value.");
                var value = Console.ReadLine();
                Console.WriteLine(Cryptographer.Encrypt(value, password));
            }
            else if (input.Equals("0"))
            {
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("invalid value!");
            }

            Console.WriteLine("Touch 9 to restart.");
            input = Console.ReadLine();

            if (input.Equals("9"))
            {
                Program.Main(null);
            }
        }
    }
}
