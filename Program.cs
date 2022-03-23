using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericstestMaximum_Day13
{
    public class Program
    {
       static void Main(string[] args)
        {
            int d;
            float g;
            TestNumbers<int> obj = new TestNumbers<int>(45,56,67);
            d = obj.findmaximumnumber();
            Console.WriteLine("maximum value" + d);

            TestNumbers<float> obj1 = new TestNumbers<float>(34.5f, 56.7f, 23.5f);
            g = obj1.findmaximumnumber();
            Console.WriteLine("maximum value" + g);

        }
    }
}
