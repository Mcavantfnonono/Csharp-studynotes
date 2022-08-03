using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d2._7_类型转换
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             类型转换显式 /隐式类型转换   

            隐式类型转换也叫自动类型转换   小转大 例如：
             int aa =3;
             double aa1 = aa;
             
             显式类型转换也叫强制类型转换  大转小 例如：
             (double)Math.Round(((decimal)5 / 8), 3);
             
             
             
             */

            int a1 = 8;
            int a2 = 3;
            double a3 = a1 / a2;
            Console.WriteLine(a3);
            double a4 = a1 * 1.0 / a2;
            Console.WriteLine(a4);

            //  double 变量名 = 整数 / 整数; 结果为整数
            //  double 变量名 = 整数*1.0 / 整数; 结果为小数
            //  double 变量名 = 小数类型 / 整数; 结果为小数


            double d1 = 5;
            int b1 = 3;
            double p2 = d1 / b1;
            Console.WriteLine(p2);
            Console.WriteLine("{0:0.00}",p2);//包留小数点后两位用占位符{0:0.000}0.后面几个零保留几位。
            Console.WriteLine((double)Math.Round(((decimal)d1 / b1), 2));// Math.Round(((decimal)除法运算), 保留几位小数);
            Console.ReadKey();
        }
    }
}
