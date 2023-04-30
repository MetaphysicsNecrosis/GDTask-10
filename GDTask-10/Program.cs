using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDTask_10
{
    internal class Program
    {
        const String toAdd = "ай";
        static public String ToAi(String s) 
        {
            if (s == null || s == " ") 
            {
                return s;
            }
            String output = "";
            char? memChar = null;
            int i = 0;
            for (i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i])) 
                {
                    memChar = s[i];
                    i++;
                    break;
                }
                output += s[i];
            }

            for (; i < s.Length; i++)
            {
                output+= s[i];
            }

            if (memChar != null)
            {
                output += memChar;
                output += toAdd;
            }

            return output;
        }
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split(' ').Select(n => ToAi(n)).ToList();
            String s1 = "";
            for(int i = 0;i < s.Count - 1;i++)
            {
                s1 += s[i];
                s1 += ' ';
            }
            s1 += s[s.Count - 1];
            Console.WriteLine(s1);
            Console.ReadKey();
        }
    }
}
