using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyszeruAdattipusokString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "   Ez itt egy elég hosszú mondat.   ";
            int poz = 0;
            if (s.Length > 0)
                while (s.ElementAt(poz) == ' ')
                    poz++;
            int db = 0;
            while (poz < s.Length)
            {
                if (s.ElementAt(poz) == ' ')
                {
                    db = db + 1;
                    //Ha két szóköz van egymás után vagy egy szóköz után vége van a stringnek.
                    if (((poz + 1) < s.Length) && (s.ElementAt(poz + 1) == ' ') ||
                         (poz + 1 >= s.Length)
                       )
                    {
                        db = db - 1;
                        break;
                    }
                }
                poz = poz + 1;
            }
            //Egyel több szó van, mint szóköz a szavak között
            if (s.Length > 0)
                db = db + 1;
            Console.WriteLine("\nA '" + s + "' mondatban " + db + " szó van.");
            Console.ReadKey();
        }
    }
}
