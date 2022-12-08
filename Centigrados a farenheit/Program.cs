using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCentigrados
{
    class Program
    {
        static void Main(string[] args)
        {

            double c, f;

            Console.WriteLine("Dame os datos de los centigrados");
            c = Convert.ToDouble(Console.ReadLine());

            f = (c * 1.8) + 32;

            Console.WriteLine("Los grados convertidos a Farenheit son:{0}", f);

        }
    }
}
