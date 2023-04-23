using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int tuoi = 18;
            Console.WriteLine("Tuoi cua toi la: {0}", tuoi);
            //tuoi = 20;
            Console.WriteLine("Hai nam sau tuoi cua toi la: {0}", tuoi+2);
            Console.WriteLine("Hai nam sau tuoi cua toi la: {0}", tuoi );
            //tuoi = tuoi + 20;
            Console.WriteLine("Hai muoi nam sau tuoi cua toi la: {0}", tuoi+22);
            Console.WriteLine("Hai muoi nam sau tuoi cua toi la: {0}", tuoi );
            Console.ReadKey();
        }
    }
}
