using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceDemo
{
    class Program
    {
        static double cost_per_km = 10.0;
        static double cost_per_min = 1.0;
        static int min_fair = 5;

        public static double calculate(double distance, int time)
        {
            double total = distance * cost_per_km + time * cost_per_min;
            if (total < 5)
            {
                return min_fair;
            }
            return total;
        }
        public static void Main(string[] args)
        {
            Program c = new Program();
            double d = calculate(5.0, 5);
            Console.WriteLine(d);
        }
    }
}
