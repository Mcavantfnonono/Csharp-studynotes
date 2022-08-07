using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            a += 20;  //a= a+20
            int b = 88;
            b -= 6; //b=b-6
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();



            //逻辑运算符
            /*
             &&         与           两个数都非零，则条件为True。
             ||         或           两个数中有任意一个非零，则条件为True。
             !          非           反转一个表达式的
             逻辑表达式结果为bool值，
             */
            bool i1 = true;
            bool i2 = false;
            Console.WriteLine(true && true );
            Console.WriteLine(true && false);
            Console.WriteLine(true || i2);
            Console.WriteLine(!i1);
            Console.WriteLine(!i2);
            Console.ReadKey();












        }
    }
}
