using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyszeruAdattipusokEnum
{
    enum Allat { KUTYA, MACSKA, TEHEN, LO };
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            bool vanMegHang = true;
            do
            {
                Allat allat = (Allat)rnd.Next(0, 5);
                switch (allat)
                {
                    case Allat.KUTYA:
                        Console.WriteLine("Vau, vau...");
                        break;
                    case Allat.MACSKA:
                        Console.WriteLine("Mijau...");
                        break;
                    case Allat.TEHEN:
                        Console.WriteLine("Múúúú...");
                        break;
                    case Allat.LO:
                        Console.WriteLine("Nyihaha...");
                        break;
                    default:
                        vanMegHang = false;
                        break;
                }
            } while (vanMegHang);
            Console.ReadKey();
        }
    }
}
