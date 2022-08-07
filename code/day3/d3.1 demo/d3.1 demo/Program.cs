using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d3._1_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //将string 转 int （double）怎么办？？？
            String age = "20";
            // 
            /*
             C# Convert 数据类型转换
             数据类型  变量名 = Convert.to数据类型(变量);
             
             
            Convert.ToInt16 	转换为整型(short)
            Convert.ToInt32 	转换为整型(int)
            Convert.ToInt64 	转换为整型(long)
            Convert.ToChar  	转换为字符型(char)
            Convert.ToString    转换为字符串型(string)
            Convert.ToDateTime	转换为日期型(datetime)
            Convert.ToDouble	转换为双精度浮点型(double)
            Conert.ToSingle 	转换为单精度浮点型(float)
            ..............
             
             */
            int age1 = Convert.ToInt32(age);
            Console.WriteLine(age1);
            Console.ReadKey();

            /*
            //把数值*5
            Console.WriteLine("请输入数值");
            String num = Console.ReadLine();
            double num1 = Convert.ToDouble(num);
            Console.WriteLine(num+"* 5 = "+num1 * 5);
            Console.ReadKey();
*/
            
           Console.WriteLine("请输入数值");
           double num1 = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine(num1 + "* 5 = " + num1 * 5);
           Console.ReadKey();
           
            }
    }
}
