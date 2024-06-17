using System.Security.Cryptography;

namespace Assignment7._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string s1 = "hello";
            string s2 = "elloh";
            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach(char c in s1)
            {
                if (!dic.ContainsKey(c)) { dic[c] = 0;}
                dic[c]++;
            }
            foreach (char c in s2)
            {
                if (!dic.ContainsKey(c)) { dic[c] = 0; }
                dic[c]--;
            }
            int dif = 0;
            foreach(var kvp  in dic) { dif=dif+kvp.Value; }
            if (dif == 0) Console.WriteLine($"{s1} and {s2} are anograms");
            else { Console.WriteLine($"{s1} and {s2} are not anograms"); }
        }
        }
    }
