using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d2._3转换变量
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1 = 20;
            int n2 = 10;
            Console.WriteLine("n1为{0},n2为{1}", n1, n2);
            //变量位置交换
            Console.WriteLine("转换后n1为{0},n2为{1}", n2, n1);
            Console.ReadKey();
            //如何改变n1 n2 值
            int n3 = n1;
            n1 = n2;
            n2 = n3;
            Console.WriteLine("转换后n1为{0},n2为{1}", n1, n2);
            Console.ReadKey();
            //加减法交换
            n1 = n1 - n2; //20 -10 =10   n1=10
            n2 = n1 + n2; //10 + 10 =20  n2 =20
            n1 = n2 - n1; //20 -10 =10   n1=10
            Console.WriteLine("转换后n1为{0},n2为{1}", n1, n2);
            Console.ReadKey();
        }
    }
}
