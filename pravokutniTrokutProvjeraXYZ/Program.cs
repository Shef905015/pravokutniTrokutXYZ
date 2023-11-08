using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pravokutniTrokutProvjeraXYZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x,y, z;

            unosX:Console.WriteLine("Unesite prvu katetu: ");
            x = Convert.ToInt32(Console.ReadLine());

            if (x < 0)
            {
                Console.WriteLine("Ponovno unesite Prvu katetu.");
                goto unosX;
            }

            unosY:Console.WriteLine("Unesite drugu katetu: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (y < 0)
            {
                Console.WriteLine("Ponovno unesite drugu katetu.");
                goto unosY;
            }

        unosZ: Console.WriteLine("Unesite hipotenuzu: ");
            z = Convert.ToInt32(Console.ReadLine());

            if(z < 0)
            {
                Console.WriteLine("Ponovno unesite hipotenuzu.");
                goto unosZ;
            }



            if(x*x + y*y == z*z)
            {
                Console.WriteLine("Vaš trokut je pravokutan!");
            }

            else
            {
                Console.WriteLine("Vaš trokut nije pravokutan!");
            }







            Console.ReadKey();

        }
    }
}
