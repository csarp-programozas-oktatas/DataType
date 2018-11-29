    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringSzavakBetuinekOsszekeverese
{
    class OsszekeverhetoString
    {
        private string s;
        public OsszekeverhetoString(string s)
        {
            this.s=s;
        }
        public String getOsszekevert()
        {
            if (s.Length < 3)
                return s;
            String tmp = s;
            if (s.Length == 4)
            {
                int k1 = 1;
                int k2 = 2;
                char c1 = tmp.ElementAt(k1);
                char c2 = tmp.ElementAt(k2);
                tmp = tmp.Substring(0, k1) + c2 + tmp.Substring(k1 + 1);
                tmp = tmp.Substring(0, k2) + c1 + tmp.Substring(k2 + 1);
            }
            else
            {
                Random rnd = new Random();
                int hanyszor = (int)(rnd.Next(s.Length));
                for (int i = 0; i < hanyszor; i++)
                {
                    int k1 = rnd.Next(s.Length - 2) + 1;
                    int k2 = rnd.Next(s.Length - 2) + 1;
                    char c1 = tmp.ElementAt(k1);
                    char c2 = tmp.ElementAt(k2);
                    tmp = tmp.Substring(0, k1) + c2 + tmp.Substring(k1 + 1);
                    tmp = tmp.Substring(0, k2) + c1 + tmp.Substring(k2 + 1);
                    //Console.WriteLine(k1+" "+k2+" "+tmp);
                }
            }
            return tmp;
        }
    }
}
