using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class CaesarCipher
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            string message = Console.ReadLine();
            int encryption = Convert.ToInt32(Console.ReadLine());
            char[] arr = message.ToCharArray();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                result.Append(EncryptedChar(t, encryption));
            }
            Console.WriteLine(result.ToString());
        }

        static char EncryptedChar(char c, int k)
        {
            if (!char.IsLetter(c))
            {
                return c;
            }
            int basic = char.IsLower(c) ? 'a' : 'A';
            return (char)(((c - basic) + k) % 26 + basic);
        }
    }
}
