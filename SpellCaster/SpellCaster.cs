using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SpellCaster
{
    class SpellCaster
    {
        static void Main(string[] args)
        {
            var spell = Console.ReadLine().Split(new Char[] { ',', ' ' });
            var rearrangeSpell = new StringBuilder();
            int loopLength = spell.OrderBy(n => n.Length).Last().Length;
            int pos = 0;
            for (int i = loopLength - 1; i >= 0; i--)
            {
                for (int j = 0; j < spell.Length; j++)
                {
                    int val = spell[j].Length - (pos + 1);
                    if (val >= 0 && val <= spell[j].Length)
                    {
                        rearrangeSpell.Append(spell[j][val]);
                    }
                }
                pos++;
            }

            for (int i = 0; i < rearrangeSpell.Length; i++)
            {
                var currentChar = rearrangeSpell[i];
                int letterValue = char.ToLower(currentChar) - 'a' + 1;
                int position = letterValue + i;

                if (position > rearrangeSpell.Length - 1)
                {
                    position %= rearrangeSpell.Length;
                }

                rearrangeSpell.Remove(i, 1);
                rearrangeSpell.Insert(position, currentChar);

            }
            //char[] result = rearrangeSpell.ToString().ToCharArray();
            //result = MovingCharacters(result);
            //foreach (var letter in result)
            //{
            //    Console.Write(letter);
            //}
            //Console.WriteLine();
        }
        //static char[] MovingCharacters(char[] result)
        //{
        //    for (int i = 0; i < rearrangeSpell; i++) 
        //    {
        //        int letterValue = char.ToLower(result[i]) - 'a' + 1; 
        //        int position = letterValue + i; 
        //        if (position > result.Length - 1) 
        //        {
        //            position %= result.Length;
        //        }

        //        if (i < position)
        //        {
        //            result = MovingCharFromLeftToRight(result, position, i);
        //        }
        //        else if (position < i)
        //        {
        //            result = MovingCharFromRightToLeft(result, position, i);
        //        }
        //    }
        //    return result;
        //}
        //static char[] MovingCharFromLeftToRight(char[] result, int position, int i)
        //{
        //    for (int j = i; j < position; j++)
        //    {               
        //        char temp = result[j];
        //        result[j] = result[j + 1];
        //        result[j + 1] = temp;
        //    }
        //    return result;
        //}
        //static char[] MovingCharFromRightToLeft(char[] result, int position, int i)
        //{
        //    for (int j = i; j > position; j--)
        //    {
        //        char temp = result[j];
        //        result[j] = result[j - 1];
        //        result[j - 1] = temp;
        //    }
        //    return result;
        //}
    }
}

