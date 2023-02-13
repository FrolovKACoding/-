using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace таблица_умножения
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=1, b;
            for (; a < 10; ++a, Console.Write('\n'))
                for (b = 1; b < 10; ++b)
                    Console.Write("{0,3}", a * b);
            Console.ReadKey();
        }
    }
                
}
