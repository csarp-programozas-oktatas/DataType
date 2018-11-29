using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringSzavakBetuinekOsszekeverese
{
    class Program
    {
        static void Main(string[] args)
        {
            OsszekeverhetoString s1 = new OsszekeverhetoString("ab");
            Console.WriteLine(s1.getOsszekevert());

            OsszekeverhetoString s2 = new OsszekeverhetoString("abc");
            Console.WriteLine(s2.getOsszekevert());

            OsszekeverhetoString s3 = new OsszekeverhetoString("abcd");
            Console.WriteLine(s3.getOsszekevert());

            OsszekeverhetoString s4= new OsszekeverhetoString("Szoftverfejlesztő");
            Console.WriteLine(s4.getOsszekevert());

            OsszekeverhetoString s = new OsszekeverhetoString(
                "Készítsen programot amely a billentyűzetről egy változóba beolvas egy számot");
            Console.WriteLine(s.getOsszekevert());
            Console.ReadKey();
        }
    }
}
