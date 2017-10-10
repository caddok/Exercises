using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pangrams
{
    class Pangrams
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine().Replace(" ","").ToLower();
            //char[] alphabet = new[] {'a', 'b', 'c', 'd', 'e', 'f', 'g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            //int[] alphabet = new int[25];
            //Regex alphabet = new Regex("[a-zA-Z]+\S"); ?????
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();
            var result = new string(sentence.Distinct().ToArray());

            Console.WriteLine(result.Length == alphabet.Length ? "pangram" : "not pangram");
        }
    }
}
