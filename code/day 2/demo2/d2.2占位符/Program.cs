using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d2._2占位符
{
    class Program
    {
        static void Main(string[] args)
        {


            int q1 = 1;
            int q2 = 2;
            int q3 = 3;



            Console.WriteLine("这里是" + q1 + ",这里是" + q2 + ",这里是" +q3 +"\n");
            Console.ReadKey();

            /*占位符:
             * 使用方法：先挖个{}坑，再填个{}坑。
             ，后多填了没效果、少填了程序出异常
             占位符 按照{0}  {1} {2} ...顺序输出

            */
            Console.WriteLine("这里是{0},这里是{1},这里是{2}", q1, q2, q3);
            //占位符少填了!!!!!!!!!!!  程序异常
            Console.ReadKey();

            //Console.WriteLine("这里是{0},这里是{1},这里是{2}", q1, q2);
            //占位符多填了!!!!!!!!!!!   
            Console.WriteLine("这里是{0},这里是{1},这里是{2}",q1,q2,q3,q3);
            Console.ReadKey();


            //Console.WriteLine("这里是{0},这里是{1},这里是{2}",q1,q2,q3,q3);==  Console.WriteLine("这里是{0},这里是{1},这里是{2}", q1, q2, q3);
            //占位符 按照{0}  {1} {2} ...顺序输出
            Console.WriteLine("这里是{0},这里是{2},这里是{1}", q1, q2, q3);


            Console.ReadKey();
            Console.WriteLine("{0},{1},{2}", q1, q2, q3);
            Console.Read();

        }
    }
}
