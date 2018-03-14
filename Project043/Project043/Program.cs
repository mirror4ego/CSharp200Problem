using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project043
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = new object();
            object obj1 = new object();
            if (typeof(object) == obj.GetType())
            {
                Console.WriteLine("같은 타입");
            }

            Console.WriteLine(obj.ToString());
            Console.WriteLine(obj.GetType());
            Console.WriteLine(obj.GetHashCode());
            Console.WriteLine(obj1.GetHashCode());

            if (obj.Equals(obj1))
            {
                Console.WriteLine("같은 개체");
            }
            else
            {
                Console.WriteLine("다른 개체");
            }

            Program pro = new Program();
            Console.WriteLine(pro.GetType());
            Console.WriteLine(pro.GetHashCode());

        }
    }
}
