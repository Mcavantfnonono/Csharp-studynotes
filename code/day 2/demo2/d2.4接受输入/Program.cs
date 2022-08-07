using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d2._4接受输入
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("姓名?");
            Console.ReadLine();
            Console.WriteLine("年龄?");
            Console.ReadLine();
            Console.WriteLine("班级?");
            Console.ReadLine();


            //接受输入 Console.ReadLine();
            Console.WriteLine("请输入密码?");
            String password = Console.ReadLine();
            Console.WriteLine("你的密码是{0}", password);

            Console.WriteLine("用户名?");
            String un1 = Console.ReadLine();
            Console.WriteLine("你的用户名是{0}", un1);
            Console.ReadKey();

        }
    }
}
