using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varijable1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ocjena; double brojocjena = 0; double zbrojocjena = 0;
            double prosjek=0;
            string uputa = "Upiši ocjenu: ";
            string ispis = "Prosjek je: ";
            do
            {
                Console.Write(uputa);
                ocjena = Convert.ToInt32(Console.ReadLine());
                if(ocjena>=1 && ocjena <= 5)
                {
                    brojocjena++;
                    zbrojocjena += ocjena;
                }else if (ocjena == 0)
                {
                    prosjek = zbrojocjena / brojocjena;
                    Console.Write(ispis);
                    Console.WriteLine(prosjek);
                }
                else
                {
                    Console.WriteLine("Molimo unesite uspravnu ocjenu(1-5)!");
                }
               
               
                
            } while (ocjena != 0);
            
            Console.ReadKey();
        }
    }
}
