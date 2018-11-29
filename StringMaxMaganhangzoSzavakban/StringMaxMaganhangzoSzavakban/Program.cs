using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMaxMaganhangzoSzavakban
{
    class Program
    {
        public static int megszamolMaganhangzokSzamat(String s)
        {
            int db = 0;
            for (int i = 0; i < s.Length; i++)
            {
                switch (char.ToUpper(s.ElementAt(i)))
                {
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        db++;
                        break;
                }
            }
            return db;
        }
        static void Main(string[] args)
        {
            String[] szavak = {
                "almafa",
                "diofa",
                "szederbokor",
                "eperfa",
                "akacfa",
                "csipkebokor",
                "szilvafa",
                "szelidgesztenyefa",
                "bukkfa",
                "malnabokor"
            };

            int max = -1;
            foreach (String s in szavak)
            {
                int m;
                if ((m = megszamolMaganhangzokSzamat(s)) > max)
                    max = m;
            }
            Console.WriteLine("A legtöbb magánhangzót tartalmazó szóban a magánhangzók száma: " + max);
            Console.ReadKey();
        }
    }
}
