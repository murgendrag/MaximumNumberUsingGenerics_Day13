using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericstestMaximum_Day13
{
    
    public class TestNumbers<T> where T :IComparable
    {
        public T d, e, g;
        public TestNumbers(T d ,T e, T g)
        {
            this.d = d;
            this.e = e;
            this.g = g;
        }
        public  T findmaximumnumber()
        {
            if (d.CompareTo(e) == 1 && d.CompareTo(g) == 1)
            {
              Console.WriteLine("d is largest" + d);
              return d;
            }
            if (e.CompareTo(d) == 1 && e.CompareTo(g) == 1)
            {
              Console.WriteLine("e is largest number " + e);
              return e;
            }
            if (g.CompareTo(d) == 1 && g.CompareTo(e) == 1)
            {
              Console.WriteLine("g is largest number " + g);
              return g;
            }
            return default;
        }
    }
}
