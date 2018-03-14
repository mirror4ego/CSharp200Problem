using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Project109
{
    class ThreadT
    {
        public void Go()
        {
            for(int i = 0; i < 3000; i++)
            {
                Console.Write("T");
            }
        }
    }

    public class ThreadS
    {
        public void Go()
        {
            for (int i = 0; i < 3000; i++)
            {
                Console.Write("S");
            }
        }
    }

    public class ThreadM
    {
        public void Go()
        {
            for (int i = 0; i < 3000; i++)
            {
                Console.Write("M");
            }
        }
    }

    public class ThreadCompete
    {
        public void Going()
        {
            ThreadT t = new ThreadT();
            ThreadS s = new ThreadS();
            ThreadM m = new ThreadM();

            Thread t1 = new Thread(new ThreadStart(t.Go));
            Thread t2 = new Thread(new ThreadStart(s.Go));
            Thread t3 = new Thread(new ThreadStart(m.Go));

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
