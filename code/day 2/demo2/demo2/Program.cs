using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             变量使用
             先声明再赋值再使用
             
             
             */


            int n;  //定义int类型变量n
           
            n = 100; //给n赋值100

            int a = 100;  //定义int类型变量a,给a赋值100

            string p = "皮皮哦";  //string 字符串类型            
            char zz = 'a';  //char字符类型	用来存储单个字符必须用‘ ’  只能存一个字符；不能存储空！！！！！！！！！！！！！     
            // 加号两边有一边有字符串：连接作用 
            Console.WriteLine("hello" + "world");
            Console.WriteLine("hello" + 1); 

            //如何多个变量同时声明打印变量？
            int s1 = 1, s2 = 2, s3 = 123, s343 = 14;
            Console.WriteLine(s1 + ","+s2+","+s3+","+s343);
            Console.WriteLine("{0}，{1}，{2},{3}",s1,s2,s3,s343);
            Console.WriteLine(s1+s2+s3+s343);












            //char cp2 = 'bb'; //报错！！！！！！
            char cp1 = '\b'; //在里面表示一个转义字符
            string cp2 = "wd";
            string cp3 = "pc";
            Console.Write("====================================================================================\n");
            Console.Read();

            Console.WriteLine(cp2 + cp1 + "cp1" + cp3);
            //wcp1pc
            Console.Read();

            float f = 1.1F; // 浮点类型
            
            decimal dm = 23333333333333333333333333M;
            double db = 1234;

            Console.Write(a+n+p+zz+f+dm+db); //打印变量
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("===========================运算符===============================");
            Console.Read();


           /// 运算符
           ///+
            int a1 = 10;
            int b1 = 55;
            int c;
            c = a1 + b1;
            Console.Write("a1的值" + a1);
            Console.Write("\n");
            Console.Write("b1的值" + b1);
            Console.Write("\n");
            Console.Write("c的值"+c);
            Console.Write("\n");
            ///"a1+b1的值" + 
            Console.Write(a1+b1);
            Console.Write("\n");
            Console.Write("a1+b1的值" + a1 + b1);
            Console.Write("\n");
            Console.Read();
            Console.Write("\n");
            /// -
            int c2 = a1 - b1;
            Console.Write("\n");
            Console.Write("a1-b1的值" + c2);
            Console.Write("\n");
            Console.Read();
            Console.Write("\n");
            /// *  ÷
            Console.Write("a1*b1的值" + a1*b1);
            Console.Write("\n");
            Console.Write("a1/b1的值" + a1 / b1);
            Console.Write("\n");
            


            
            double c3 =  a1 / b1;
            Console.Write("c3的值:" + c3);



            Console.Read();
            /// %
             Console.Write("\n");
            Console.Write("a1%b1的值:");
            Console.Write(a1 % b1);

            Console.Write("\n");

            Console.Read();
            Console.Write("\n");
            ///自增、自减运算符
            Console.Read();

            if (a1 ==10)
            {
                a1++;
            }


            Console.Write("a1++的值" + a1);
            Console.Write("\n");

            while (b1 > 5)
            {
                b1--;
            }

            Console.Write("b1--的值" +  b1);
            Console.Write("\n");
            Console.Read();

            int apo = 100;
            Console.WriteLine(apo);
            Console.Read();

            String name = "abc";
            String email = "oooooo@qq.com";
            int age = 99;
            Console.WriteLine("我是" + name + "今年" + age + "岁" + "邮箱" + email);
            Console.WriteLine("我是{0},今年{1}岁，邮箱{2}", name, age, email);
            Console.Read();
        }
    }
}
