using System;
using System.Net.Security;
using System.Net.WebSockets;
using System.Security.Cryptography;
using System.Threading;

namespace easy.crypt.tool
{
    class Program
    {
        static RSAParameters parameters;

        static string Opetions()
        {
            return "1 - Encrypt | 2 - Decrypt | 3 - ToRSA | 4 - FromRSA | 5 - ToBase64 | 6 - FromBase64 | 0 - Exit";
        }

        static void Execute()
        {
            string line;
            Console.WriteLine("Chose the option:");
            Console.WriteLine(Opetions());
            line = Console.ReadLine();

            if (int.TryParse(line, out int option))
            {
                ExecOperation((Operation)option);
            }
            else
            {
                Reset("Invalid option. Try again.");
            }
        }

        private static void ExecOperation(Operation option)
        {
            switch (option)
            {
                case Operation.Encrypt:
                    Encrypt();
                    break;
                case Operation.Decrypt:
                    Decrypt();
                    break;
                case Operation.ToRSA:
                    ToRSA();
                    break;
                case Operation.FromRSA:
                    FromRSA();
                    break;
                case Operation.ToBase64:
                    ToBase64();
                    break;
                case Operation.FromBase64:
                    FromBase64();
                    break;
                case Operation.Exit:
                    Console.WriteLine("By by...");
                    break;
                default:
                    Reset("Invalid option. Try again.");
                    break;
            }
        }

        private static void FromBase64()
        {
            Console.Clear();
            Console.WriteLine("FROM BASE 64 OPERATION SELECTED...");
            
            Console.WriteLine("Enter with Text Value:");
            var textValue = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(textValue))
            {
                Reset("Invalid value. Try Again.");
            }

            var result = Cryptographer.FromBase64(textValue);

            Reset($"Result value is: {result}");
        }

        private static void ToBase64()
        {
            Console.Clear();
            Console.WriteLine("TO BASE 64 SELECTED...");
            
            Console.WriteLine("Enter with Text Value:");
            var textValue = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(textValue))
            {
                Reset("Invalid value. Try Again.");
            }

            var result = Cryptographer.ToBase64(textValue);

            Reset($"Result value is: {result}");
        }

        private static void FromRSA()
        {
            Console.Clear();
            Console.WriteLine("ENCRYPT OPERATION SELECTED...");
            
            Console.WriteLine("Enter with Text Value:");
            var textValue = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(textValue))
            {
                Reset("Invalid value. Try Again.");
            }

            var result = Cryptographer.FromRsa(textValue, parameters);

            Reset($"Result value is: {result}");
        }

        private static void ToRSA()
        {
            Console.Clear();
            Console.WriteLine("ENCRYPT OPERATION SELECTED...");
            
            Console.WriteLine("Enter with Text Value:");
            var textValue = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(textValue))
            {
                Reset("Invalid value. Try Again.");
            }

            var result = Cryptographer.ToRsa(textValue, parameters);

            Reset($"Result value is: {result}");
        }

        private static void Decrypt()
        {
            Console.Clear();
            Console.WriteLine("DECRYPT OPERATION SELECTED...");
            Console.WriteLine("Enter with Pass Phrase:");
            var passPhrase = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(passPhrase))
            {
                Reset("Invalid value. Try Again.");
            }

            Console.WriteLine("Enter with Text Value:");
            var textValue = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(textValue))
            {
                Reset("Invalid value. Try Again.");
            }

            var result = Cryptographer.Decrypt(textValue, passPhrase);

            Reset($"Result value is: {result}");
        }

        private static void Encrypt()
        {
            Console.Clear();
            Console.WriteLine("ENCRYPT OPERATION SELECTED...");
            Console.WriteLine("Enter with Pass Phrase:");
            var passPhrase = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(passPhrase))
            {
                Reset("Invalid value. Try Again.");
            }

            Console.WriteLine("Enter with Text Value:");
            var textValue = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(textValue))
            {
                Reset("Invalid value. Try Again.");
            }

            var result = Cryptographer.Encrypt(textValue, passPhrase);

            Reset($"Result value is: {result}");
        }

        private static void Reset(string value)
        {
            Console.Clear();
            Console.WriteLine(value);
            Execute();
        }

        static void Main(string[] args)
        {
            parameters = new RSACryptoServiceProvider(2048).ExportParameters(true);
            Execute();
        }
    }
}
