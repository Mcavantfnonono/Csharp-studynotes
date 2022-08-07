using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @bool
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool类型 有两个结果 True false

            int a1 = 100;
            int a2 = 5;
            Console.WriteLine(a1 > a2);         //True
            int t1 = 3;
            int t3 = 9999;
            bool t2 = t1 > t3;      //False
            Console.WriteLine(t2);
            Console.ReadKey();

        }
    }
}
