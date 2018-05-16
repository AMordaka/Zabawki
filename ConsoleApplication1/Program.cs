using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    class Program
    {

        



        static void Main(string[] args)
        {
            TestWatki test = new TestWatki();
            System.Threading.Thread thread1 = new System.Threading.Thread(test.test1);
            System.Threading.Thread thread2 = new System.Threading.Thread(test.test1);

            thread1.Start();


        }
    }

}
